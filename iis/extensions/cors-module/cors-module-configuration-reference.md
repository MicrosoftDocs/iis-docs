---
title: "CORS Module Configuration Reference | Microsoft Docs"
author: jhkimnew
description: "This article provides an overview of the IIS CORS module and explains the configuration of the module."
ms.author: iiscontent
ms.date: 09/19/2017
ms.topic: article
ms.assetid:
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl:
msc.type: authoredcontent
---
IIS CORS Module Configuration Reference
====================
by IIS Team

> This article provides an overview of the IIS CORS module and explains the configuration of the module.

<a id="_Functionality_Overview"></a>
## Functionality Overview

Microsoft IIS CORS Module is a new IIS module specifically designed for CORS (Cross-origin resource sharing) protocol support.

IIS CORS module enables IIS administrators and website authors to make an IIS server support CORS protocol and properly handle CORS requests based on the CORS rules as defined or configured by users. It also allows the administrators and developers easily define or configure the access rules and to delegate all CORS protocol handling to the module.

### IIS CORS module is a server-side CORS component

CORS protocol defines client/server communication. Usually, browsers (user-agents) which support CORS work as the client-side CORS component, while the IIS server works as the server-side CORS component with the help of IIS CORS module.

A CORS request happens when a client-side CORS component makes a special request to a different domain from the current domain (origin), which is called a cross-origin request.

### CORS preflight request

A CORS preflight request is a CORS request for protocol probing (checking to see if the CORS protocol is understood) and a CORS permission check asking whether the required origin is allowed. The CORS preflight uses OPTIONS method with the ACCESS-CONTROL-REQUEST-METHOD and the ORIGIN request headers. IIS CORS module is designed to serve the CORS preflight requests before other IIS modules handle the same request. The OPTIONS requests are always anonymous, so CORS module provides IIS servers a way to correctly respond to the preflight request even if anonymous authentification needs to be disabled server-wise.

<a id="_IISCORS_Configuration"></a>
## CORS Configuration

The IIS CORS is configured via a site or application *web.config* file and has its own `cors` configuration section within `system.webServer`.

Below are the configuration examples to enable CORS for a site named contentSite with allowing * origin host except the origin host which starts with http://* and for https://*.microsoft.com host origin, the CORS response is customized with various CORS configuration as examples.

 ```xml
 <?xml version="1.0" encoding="UTF-8"?>
 <configuration>
     <system.webServer>
         <cors enabled="true" failUnlistedOrigins="true">
             <add origin="*" />
             <add origin="https://*.microsoft.com"
                  allowCredentials="true"
                  maxAge="120"> 
                 <allowHeaders allowAllRequestedHeaders="true">
                     <add header="header1" />
                     <add header="header2" />
                 </allowHeaders>
                 <allowMethods>
                      <add method="DELETE" />
                 </allowMethods>
                 <exposeHeaders>
                     <add header="header1" />
                     <add header="header2" />
                 </exposeHeaders>
             </add>
             <add origin="http://*" allowed="false" />
         </cors>
     </system.webServer>
 </configuration>
 ```

With the IIS CORS module, you can:

1. Enable, disable CORS for a whole IIS server or for a specific IIS site, an application, a virtual directory, a physical directory or a file (system.webServer/cors).
2. Configure all the origin host domains to be accepted with * origin host rule.
3. Configure the list of specific origin host domains and allow only the CORS request which has the same value of the origin request header as one of listed origin host domains.
4. Configure wild card origin host domains when configuring the list of origin domain such as http://* or https://*.mydomain.com.
5. Configure a list of origin domains which should be disallowed as CORS request.
6. Customize the CORS response header values with the configured values.

## Attributes of the cors element

| **Attribute** | **Description** |
| --- | --- |
| `enabled` | Optional Boolean attribute.<br>Specifies whether CORS is enabled.<br>The default value is `false`. |
| `failUnlistedOrigins` | Optional Boolean attribute.<br>Specifies whether the CORS response status code to be set with 403 if the requested origin is not matched to the configured list of origin or if the origin host is configured to be disallowed.<br>The default value is `false`. |

### Adding Origin rule &lt;add&gt;

<a id="001"></a>
## Origin rules

The `<add>` element of the `<cors>` collection specifies an individual origin to be added to the list of origin rules.

### Attributes of the origin rule

| **Attribute** | **Description** |
| --- | --- |
| `origin` | Required string attribute.<br>Specifies origin host on which to impose an origin rule. You can use an asterisk (\*) to apply this rule to all origin request header values. You can also use an asterisk (\*) as a wildcard for the child subdomain name. If there are multiple origin rules, it is applied to the most specific origin host name.  |
| `allowed` | Optional Boolean attribute.<br>Specifies whether to accept the CORS request for the origin host.<br>The default value is `true`. |
| `allowCredentials` | Optional Boolean attribute.<br>Specifies whether to set the Access-Control-Allow-Credentials: `true` CORS response header. This attribute should be used only for a specific origin host name rather than * origin host for CORS protocol compliance.<br>The default value is `false`. |
| `maxAge` | Optional integer attribute. Duration in seconds.<br>Specifies the value of the `Access-Control-Max-Age` response header for the preflight CORS request. The Access-Control-Max-Age response header is supposed to be set only for the CORS preflight requests. If you don't want to set the Access-Control-Max-Age header in the CORS response, set -1 for this attribute.<br>The default value is `-1`. |

#### Using only * origin host rule

If there is only * origin host rule, IIS CORS module has some different behaviors compared to when there is a specific origin host name rule.
If there is only * origin host rule, IIS CORS module does the following:

1. The value of Access-Control-Allow-Origin response header is set to * regardless of the value of the `origin` request header sent by the client-side CORS component.
2. Vary: `origin` response header is not added because IIS CORS does not generate Access-Control-Allow-Origin response header values other than * and there is no need to use the Vary: `origin` response header value.

### Child Elements of the origin host rule

| **Element** | **Description** |
| --- | --- |
| **allowHeaders** | configures **allowHeaders** collection that is used for the value of the `Access-Control-Allow-Headers` CORS response header for the **origin** host specified in the origin host rule.<br>The `Access-Control-Allow-Headers` response header will be set only for the actual CORS requests rather than the preflight requests. |
| **allowMethods** | configures **allowMethods** collection that is used for the value of the `Access-Control-Allow-Methods` CORS response header for the **origin** host specified in the origin host rule.<br>The `Access-Control-Allow-Methods` response header will be set only for the CORS preflight requests.|
| **exposeHeaders** | configures **exposeHeaders** collection that is used for the value of the `Access-Control-Expose-Headers` CORS response header for the **origin** host specified in the origin host rule.<br>The `Access-Control-Expose-Headers` response header will be set only for the actual CORS requests rather than the preflight requests.|

### Attributes of the allowHeaders element

| **Attribute** | **Description** |
| --- | --- |
| `allowAllRequestedHeaders` | Optional Boolean attribute. If this is true, IIS module will take the value of the given Access-Control-Request-Headers CORS request header and set the Access-Control-Allow-Headers response header with the same value, which means all the given headers are allowed. If this is false, it sets the Access-Control-Allow-Headers response header with the header values of the allowHeaders collection, which means that only the listed headers are allowed. The default value is `false`. |

<a id="_Sample_Code"></a>
## Sample Code

### C#

[!code-csharp[Main](cors-module-configuration-reference/samples/sample1.cs)]

### JavaScript

[!code-csharp[Main](cors-module-configuration-reference/samples/sample2.cs)]

### Command Line (AppCmd)

[!code-console[Main](cors-module-configuration-reference/samples/sample3.cmd)]

### PowerShell

[!code-console[Main](cors-module-configuration-reference/samples/sample4.cmd)]
