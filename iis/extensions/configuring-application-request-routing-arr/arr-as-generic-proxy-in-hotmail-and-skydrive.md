---
title: "ARR as generic proxy in Hotmail and SkyDrive"
author: rick-anderson
description: "This article describes integration and use of the Application Request Routing module as a generic proxy for the Hotmail and SkyDrive web sites allowing both..."
ms.date: 07/25/2012
ms.assetid: c3955f19-2e00-41a6-90d8-d9c5414525d6
msc.legacyurl: /learn/extensions/configuring-application-request-routing-arr/arr-as-generic-proxy-in-hotmail-and-skydrive
msc.type: authoredcontent
---
ARR as generic proxy in Hotmail and SkyDrive
====================
by Amar Shroff

This article describes integration and use of the Application Request Routing module as a generic proxy for the Hotmail and SkyDrive web sites allowing both services to roll out updates to users without any disruption in service across different deployed versions.

## Solution summary

The Application Request Routing proxy (ARR) is one of the core pieces of the gradual deployment system (GD) of Hotmail and SkyDrive, used to roll out new versions of our frontend services. GD incrementally moves blocks of users to the new version of the service as servers get upgraded. Each user experiences the transition from the old to the new version at most once, while many users with shorter sessions will see no impact. To achieve this, users are affinitized to a version of the service and requests may be proxied via ARR to a version-affinitized pool of servers. The system has been built to support both SSL and non-SSL user requests. 

## Versions of relevant components

- Operating system: Windows Server 2008 R2
- Web server: IIS7
- Application runtime: ASP.NET 4.0
- Proxy: ARR 2.0

## ARR integration details

The ARR proxy runs in the same request processing pipeline as the application itself. This was needed to reduce the complexity of migrating from our older deployment system. However, this required careful resolution of conflicts between the new and existing HTTP modules in the IIS request lifecycle. Some of these resolutions are discussed in detail later. The following picture shows updates to the IIS request processing pipeline needed to integrate ARR based on the above requirements. 

[![](arr-as-generic-proxy-in-hotmail-and-skydrive/_static/image3.png)](arr-as-generic-proxy-in-hotmail-and-skydrive/_static/image2.png)

Fig: IIS request pipeline with integration of new HTTP modules and ARR proxy

The affinitized version for a user is determined by a custom http module during the BeginRequest phase of the request lifecycle. If the version of the service running on the current frontend does not match the user's affinitized version, the request is setup for proxying via ARR. The HttpRequest-&gt;SetUrl API which enables changing the request URL and thus set the request up for proxying is available only in the native context. Hence, we added the custom native module. During the MapRequestHandler phase, the ARR module sees that the request URL has been changed and sets the ARR handler as the request handler. The request processing details can be summarized as follows:

| **Request processing event** | **Action if request is proxied** |
| --- | --- |
| BeginRequest | Custom managed module determines that the request is to be proxied and passes this information to the custom native module |
| PostBeginRequest | The custom native module sets proxy URL |
| MapRequestHandler | ARR modules sets ARR handler as the request handler |
| ExecuteRequestHandler | ARR handler proxies the request to the proxy URL |
| EndRequest | Response code is inspected to determine proxy errors |

## ARR configuration

Hotmail and SkyDrive use the following configuration settings to meet our requirements: 

- preserveHostHeader = true.   
The application needs to see the original host header on the proxied request instead of the host header modified for the purpose of ARR routing.
- reverseRewriteHostInResponseHeaders = false.   
In the responses back to the client, ARR must return the location headers as set by the application in case of redirects.

## IIS request pipeline issues and resolution

Listed below are a few of the issues Hotmail and SkyDrive encountered while onboarding ARR and their resolutions:

 ·**Conflicts between ARR and MVC modules while proxying MVC requests**- The Hotmail and SkyDrive applications use ASP.NET MVC. We found that the MVC module (UrlRoutingModule 4.0) sets the MVC handler as the request handler in the PostResolveRequestCache event, which is raised after the ARR module sets the handler for the request as the ARR Handler (during MapRequestHandler). So, we had to control when UrlRoutingModule gets called by overriding the UrlRoutingModule and calling it only when our request was to be handled locally.  
·**Duplicate response headers** - Some response headers are duplicated by ARR when it copies the headers over from the target machine's response before returning the original machine's response to the client. We manually clear these duplicate headers before sending the response back.  
·**Error handling and logging-** The default application error handler, Application\_Error in the Global module, is not called when ARR fails to proxy the request. So, custom error checks need to be done during the EndRequest phase if logging is needed for proxy errors.  
·**Requests hang when ARR minResponseBuffer setting is too low**- ASP.NET 4.0 has a bug which can cause requests to hang when ARR minResponseBuffer setting is too low. [KB 2619333](https://support.microsoft.com/kb/2619333) was created and a fix was provided by ASP.NET team to resolve the issue.  Resolving some of the above issues was challenging since ARR was being integrated into an application with the size and complexity of Hotmail or SkyDrive for the first time.  

## Troubleshooting tips

- [Failed request tracing](../../troubleshoot/using-failed-request-tracing/using-failed-request-tracing-rules-to-troubleshoot-application-request-routing-arr.md) (FREB) logs are your best friend when debugging issues with proxying.FREB records detailed logs of IIS events and changes to the request during each event (request URL, headers, response code, and logging, as well as bytes sent, received, and flushed back to the user). Some of the interesting events tracing collects data on are MapRequestHandler, ExecuteRequest, SendResponse and EndRequest.
- The FREB logs are more helpful when most of the encoding (gzip, SSL, etc.) is removed. When this is done, the requests forwarded and received by ARR and responses sent back from ARR are human readable.
- [WinHttp](https://msdn.microsoft.com/library/windows/desktop/aa382925(v=vs.85).aspx) logs, [NetMon](https://www.microsoft.com/download/details.aspx?id=4865), and other networking tools can be used for low-level debugging on the source and target machines once the issue has been identified via FREB logs.
- Return a custom header indicating which machines the proxy request bounced through, especially if proxying can take multiple hops. These headers can be inspected in [Fiddler](http://www.fiddler2.com/).
- [Proxy chaining](https://blogs.iis.net/wonyoo/archive/2011/03/30/application-request-routing-and-proxy-chain.aspx) can be configured to proxy the ARR request through Fiddler. This can be achieved by updating the proxy element in applicationHost.config file as:&lt;proxy enabled="true" proxy="ChainedProxyHostName" /&gt;
- Inspect response codes during EndRequest in your application. The default application error handler is not called in case of ARR error. Response codes 502 or 400 were logged by ARR in case of the following errors:502 – Bad gateway. Request could not be proxied to the target URL.400 – Incoming connection was dropped. TCP reset could be a possible cause.

## Conclusion

Hotmail and SkyDrive services span across [thousands of servers](http://windowsteamblog.com/windows_live/b/windowslive/archive/2010/04/07/hotmail-tips-the-scales.aspx), so each server uses ARR to proxy a large number of user requests during a rollout. Despite this large scale and the complexity of our applications, ARR integration was simple, effective, and performant. ARR has allowed us to simplify our service architecture and continue providing frequent [application updates](http://windowsteamblog.com/windows_live/b/windowslive/) with minimal to no impact to users of our services.