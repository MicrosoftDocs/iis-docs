---
title: "ASP.NET 2.0 Breaking Changes on IIS 7.0 | Microsoft Docs"
author: leanserver
description: "ASP.NET 2.0 applications on IIS 7.0 and above are hosted using the ASP.NET Integrated mode by default. This new mode enables a myriad of exciting scenarios,..."
ms.author: iiscontent
manager: soshir
ms.date: 03/15/2008
ms.topic: article
ms.assetid: cdb50902-a5ee-4809-9446-169d325d4937
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/building-and-running-aspnet-applications/aspnet-20-breaking-changes-on-iis
msc.type: authoredcontent
---
ASP.NET 2.0 Breaking Changes on IIS 7.0
====================
by [Mike Volodarsky](https://github.com/leanserver)

## Introduction

ASP.NET 2.0 applications on IIS 7.0 and above are hosted using the ASP.NET Integrated mode by default. This new mode enables a myriad of exciting scenarios, including using valuable ASP.NET features such as Forms Authentication for your entire Web site, and developing new ASP.NET modules to do things such as URL rewriting, authorization, logging, and more at the IIS level. For more information about the ASP.NET Integration in IIS, see: [ASP.NET Integration with IIS7 and Above](aspnet-integration-with-iis.md).

While making ASP.NET applications more powerful in IIS 7.0 and above, we also worked diligently to ensure that existing ASP.NET applications continue to work when migrated to this new platform. This was a major challenge for us as we re-architected the entire core engine of ASP.NET, and in the end we were highly successful in meeting it. As a result, most ASP.NET applications should work without change.

This article lists the changes in behavior that you may encounter when deploying your ASP.NET applications on IIS 7.0 and above on Windows Vista SP1 and Windows Server 2008. *Except where noted, these breaking changes occur only when using the default ASP.NET Integrated mode*.

## Using Classic ASP.NET mode

IIS 7.0 and above also offers the ability to run ASP.NET applications using the legacy Classic ASP.NET Integration mode, which works the same way as ASP.NET has worked on previous versions of IIS. However, we strongly recommend that you use a workaround where available to change your application to work in Integrated mode instead. Moving to Classic mode will make your application unable to take advantage of ASP.NET improvements made possible in Integrated mode, leveraging future features from both Microsoft and third parties that may require the Integrated mode. Use Classic mode as a last resort if you cannot apply the specified workaround. For more information about moving to Classic mode, see: [Changing the ASP.NET integration mode](aspnet-integration-with-iis.md#changemode).

Below, I discuss some of the breaking changes in detail. Where available, I include links to blog posts that contain additional details and workaround information. If you require more information on a particular problem, please post a question on the [IIS.NET forums](https://forums.iis.net/ "IIS.NET Forums").

## Breaking Changes

### Migration errors

These errors occur due to changes in how some ASP.NET configuration is applied in Integrated mode. IIS will automatically detect this configuration and issue an error asking you to migrate your application, or move it to Classic Mode if migration is not acceptable (see breaking change #3 below).

#### 1. ASP.NET applications require migration when specifying configuration in `&lt;httpModules&gt;` or `&lt;httpHandlers&gt;`

You will receive a 500 - Internal Server Error. This can include HTTP Error 500.22, and HTTP Error 500.23: *An ASP.NET setting has been detected that does not apply in Integrated managed pipeline mode*. This occurs because ASP.NET modules and handlers should be specified in the IIS &lt;handlers&gt; and &lt;modules&gt; configuration sections in Integrated mode.

##### Workaround

A. You must migrate the application configuration to work properly in Integrated mode. You can migrate the application configuration with AppCmd:

[!code-powershell[Main](aspnet-20-breaking-changes-on-iis/samples/sample1.ps1)]

B. You can migrate manually by moving the custom entries in in the `&lt;system.web&gt;/&lt;httpModules&gt;` and `&lt;system.web&gt;/&lt;httpHandlers&gt;` configuration manually to the `&lt;system.webServer&gt;/&lt;handlers&gt;` and `&lt;system.webServer&gt;/&lt;modules&gt;` configuration sections, and either removing the `&lt;httpHandlers&gt;` and `&lt;httpModules&gt;` configuration OR adding the following to your application's web.config:

[!code-xml[Main](aspnet-20-breaking-changes-on-iis/samples/sample2.xml)]
  

#### 2. ASP.NET applications produce a warning when the application enables request impersonation by specifying `&lt;identity impersonate="true"&gt;` in configuration

You will receive a 500 - Internal Server Error. This is HTTP Error 500.24: *An ASP.NET setting has been detected that does not apply in Integrated managed pipeline mode*. This occurs because ASP.NET Integrated mode is unable to impersonate the request identity in the BeginRequest and AuthenticateRequest pipeline stages.

##### Workaround

A. If your application does not rely on impersonating the requesting user in the BeginRequest and AuthenticateRequest stages (the only stages where impersonation is not possible in Integrated mode), ignore this error by adding the following to your application's web.config: 

[!code-xml[Main](aspnet-20-breaking-changes-on-iis/samples/sample3.xml)]

B. If your application does rely on impersonation in BeginRequest and AuthenticateRequest, or you are not sure, move to Classic mode.

#### 3. You receive a configuration error when your application configuration includes an encrypted `&lt;identity&gt;` section

You will receive a 500 – Internal Server Error. This is HTTP Error 500.19: *The requested page cannot be accessed because the related configuration data for the page is invalid*. The detailed error information indicates that "***Configuration section encryption is not supported***". This occurs because IIS attempts to validate the `&lt;identity&gt;` section and fails to read section-level encryption.

##### Workaround

A. If your application does not have the problem with request impersonation per breaking change #2, migrate your application configuration by using AppCmd as described in breaking change #1:


[!code-powershell[Main](aspnet-20-breaking-changes-on-iis/samples/sample4.ps1)]


This will insure that the rest of application configuration is migrated, and automatically add the following to your application's web.config to ignore the &lt;identity&gt; section:


[!code-xml[Main](aspnet-20-breaking-changes-on-iis/samples/sample5.xml)]


B. If your application does have the problem with request impersonation, move to Classic mode.

### Authentication, Authorization, and Impersonation

In Integrated mode, both IIS and ASP.NET authentication stages have been unified. Because of this, the results of IIS authentication are not available until the PostAuthenticateRequest stage, when both ASP.NET and IIS authentication methods have completed. This causes the following changes:

#### 4. Applications cannot simultaneously use FormsAuthentication and WindowsAuthentication

Unlike Classic mode, it is not possible to use Forms Authentication in ASP.NET and still require users to authenticate with an IIS authentication method including Windows Authentication, Basic Authentication, etc. If Forms Authentication is enabled, all other IIS authentication methods except for Anonymous Authentication should be disabled.  
In addition, when using Forms Authentication, the following changes are in effect:

- The LOGON\_USER server variable will be set to the name of the Forms Authentication user.

- It will not be possible to impersonate the authenticated client. To impersonate the authenticated client, you must use an authentication method that produces a Windows user instead of Forms Authentication.

##### Workaround

A. Change your application to use the pattern explained in [Implementing a two level authentication scheme using Forms Authentication and another IIS authentication method in IIS 7.0](http://mvolo.com/blogs/serverside/archive/2008/02/11/IIS-7.0-Two_2D00_Level-Authentication-with-Forms-Authentication-and-Windows-Authentication.aspx).

#### 5. Windows Authentication is performed in the kernel by default, which may cause HTTP clients that send credentials on the initial request to fail

IIS 7.0 and above Kernel-mode authentication is enabled by default. This improves the performance of Windows Authentication, and simplifies the deployment of Kerberos authentication protocol. However, it may cause some clients that send Windows credentials on the initial request to fail due to a design limitation in kernel-mode authentication. Normal browser clients are not affected because they always send the initial request anonymously.

> [!NOTE]
> This breaking change applies to both Classic and Integrated modes.

##### Workaround

A. Disable kernel-mode authentication by setting the userKernelMode to "false" in the system.webServer/security/authentication/windowsAuthentication section. You can also do it by AppCmd as follows:

[!code-console[Main](aspnet-20-breaking-changes-on-iis/samples/sample6.cmd)]

#### 6. Passport authentication is not supported

You will receive an ASP.NET 500 – Server Error: *The PassportManager object could not be initialized. Please ensure that Microsoft Passport is correctly installed on the server.* Passport authentication is no longer supported on Windows Vista and Windows Server 2008.

> [!NOTE]
> This breaking change applies to both Classic and Integrated modes.

#### 7. HttpRequest.LogonUserIdentity throws an InvalidOperationException when accessed in a module before PostAuthenticateRequest

You will receive an ASP.NET 500 – Server Error: *This method can only be called after the authentication event.* HttpRequest.LogonUserIdentity throws an InvalidOperationException when accessed before PostAuthenticateRequest, because the value of this property is unknown until after the client has been authenticated.

##### Workaround

A. Change the code to not access HttpRequest.LogonUserIdentity until at least PostAuthenticateRequest

#### 8. Client impersonation is not applied in a module in the BeginRequest and AuthenticateRequest stages

The authenticated user is not known until the PostAuthenticateRequest stage. Therefore, ASP.NET does not impersonate the authenticated user for ASP.NET modules that run in BeginRequest and AuthenticateRequest stages. This can affect your application if you have custom modules that rely on the impersonating the client for validating access to or accessing resources in these stages.

##### Workaround

A. Change your application to not require client impersonation in BeginRequest and AuthenticateRequest stages.

### 9. Defining an DefaultAuthentication\_OnAuthenticate method in global.asax throws PlatformNotSupportedException

You will receive an ASP.NET 500 – Server Error: *The DefaultAuthentication.Authenticate method is not supported by IIS integrated pipeline mode*. In Integrated mode, the DefaultAuthenticationModule.Authenticate event in not implemented and hence no longer raises. In Classic mode, this event is raised when no authentication has occurred.

##### Workaround

A. Change application to not rely on the DefaultAuthentication\_OnAuthenticate event. Instead, write an IHttpModule that inspects whether HttpContext.User is *null* to determine whether an authenticated user is present.

#### 10. Applications that implement WindowsAuthentication\_OnAuthenticate in global.asax will not be notified when the request is anonymous

If you define the WindowsAuthentication\_OnAuthenticate method in global.asax, it will not be invoked for anonymous requests. This is because anonymous authentication occurs after the WindowsAuthentication module can raise the OnAuthenticate event.

##### Workaround

A. Change your application to not use the WindowsAuthentication\_OnAuthenticate method. Instead, implement an IHttpModule that runs in PostAuthenticateRequest, and inspects HttpContext.User.

### Request limits and URL processing

The following changes result due to additional restrictions on how IIS processes incoming requests and their URLs.

#### 11. Request URLs containing unencoded "+" characters in the path (not querystring) is rejected by default

You will receive HTTP Error 404.11 – Not Found: *The request filtering module is configured to deny a request that contains a double escape sequence*. This error occurs because IIS is by default configured to reject attempts to doubly-encode a URL, which commonly represent an attempt to execute a canonicalization attack.

##### Workaround

A. Applications that require the use of the "+" character in the URL path can disable this validation by setting the *allowDoubleEscaping* attribute in the *system.webServer/security/requestFiltering* configuration section in the application's web.config. However, this may make your application more vulnerable to malicious URLs:

[!code-xml[Main](aspnet-20-breaking-changes-on-iis/samples/sample7.xml)]

#### 12. Requests with querystrings larger then 2048 bytes will be rejected by default

You will receive an HTTP Error 404.15 – Not Found: *The request filtering module is configured to deny a request where the query string is too long*. IIS by default is configured to reject querystrings longer than 2048 bytes. This may affect your application if it uses large querystrings or uses cookieless ASP.NET features like Forms Authentication and others that cumulatively exceed the configured limit on the querystring size.

> [!NOTE]
> This breaking change applies to both Classic and Integrated modes.

##### Workaround

A. Increase the maximum querystring size by setting the *maxQueryString* attribute on the *requestLimits* element in the *system.webServer/security/requestFiltering* configuration section in your application's web.config:

[!code-xml[Main](aspnet-20-breaking-changes-on-iis/samples/sample8.xml)]

### Changes in response header processing

These changes affect how response headers are generated by the application.

#### 13. IIS always rejects new lines in response headers (even if ASP.NET enableHeaderChecking is set to false)

If your application writes headers with line breaks (any combination of \r, or \n), you will receive an ASP.NET 500 – Server Error: *Value does not fall within the expected range.* IIS will always reject any attempt to produce response headers with line breaks, even if ASP.NET's enableHeaderChecking behavior is disabled. This is done to prevent header splitting attacks.

> [!NOTE]
> This breaking change applies to both Classic and Integrated modes.

#### 14. When the response is empty, the Content-Type header is not suppressed

If the application sets a Content-Type header, it will remain present even if the response is cleared. Requests to ASP.NET content types will typically have the "Content-Type: text/html" present on responses unless overridden by the application.

##### Workaround

A. While this should not typically have a breaking effect, you can remove the Content-Type header by explicitly setting the *HttpResponse.ContentType* property to *null* when clearing the response.

#### 15. When the response headers are cleared with HttpResponse.ClearHeaders, default ASP.NET headers are not generated, which may result in the lack of Cache-Control: private header that prevents the caching of the response on the client

HttpResponse.ClearHeaders does not re-generate default ASP.NET response headers, including "Content-Type: text/html" and "Cache-Control: private", as it does in Classic mode. This is because ASP.NET modules may call this API for requests to any resource type, and therefore generating ASP.NET-specific headers is not appropriate. The lack of the "Cache-Control" header may cause some downstream network devices to cache the response.

##### Workaround

A. Change application to manually generate the Cache-Control: private header when clearing the response, if it is desired to prevent caching in downstream network devices.

### Changes in application and module event processing

These changes affect how the application and module event processing takes place.

#### 16. It is not possible to access the request through the HttpContext.Current property in Application\_Start in global.asax

If your application accesses the current request context in the Application\_Start method in global.asax as part of application initialization, you will receive an ASP.NET 500 – Server Error: *Request is not available in this context.* This error occurs because ASP.NET application initialization has been decoupled from the request that triggers it. In Classic mode, it was possible to indirectly access the request context by accessing the HttpContext.Current property. In Integrated mode, this context no longer represents the actual request and therefore attempts to access the Request and Response objects will generate an exception.

##### Workaround

A. See **[Request is not available in this context exception in Application\_Start](http://mvolo.com/blogs/serverside/archive/2007/11/10/Integrated-mode-Request-is-not-available-in-this-context-in-Application_5F00_Start.aspx)** for a detailed description of this problem and available workarounds.

#### 17. The order in which module event handlers execute may be different then in Classic mode

The following differences exist:

- For each event, event handlers for each module are executed in the order in which modules are configured in the &lt;modules&gt; configuration section. Global.asax event handlers are executed last.

- Modules that register for the PreSendRequestHeaders and PreSendRequestContent events are notified in the reverse of the order in which they appear in the &lt;modules&gt; configuration section

- For each event, synchronous event handlers for each module are executed before asynchronous handlers. Otherwise, event handlers are executed in the order in which they are registered.

Applications that have multiple modules configured to run in either of these events may be affected by these change if they share a dependency on event ordering. This is not likely for most applications. The order in which modules execute can be obtained from a Failed Request Tracing log.

##### Workaround:

A. Change the order of the modules experiencing an ordering problem in the *system.webServer/modules* configuration section.

#### 18. ASP.NET modules in early request processing stages will see requests that previously may have been rejected by IIS prior to entering ASP.NET, which includes modules running in BeginRequest seeing anonymous requests for resources that require authentication

ASP.NET modules can run in any pipeline stages that are available to native IIS modules. Because of this, requests that previously may have been rejected in the authentication stage (such as anonymous requests for resources that require authentication) or other stages prior to entering ASP.NET may run ASP.NET modules. This behavior is by design in order to enable ASP.NET modules to extend IIS in all request processing stages.

##### Workaround

A. Change application code to avoid any application-specific problems that arise from seeing requests that may be rejected later on during request processing. This may involve changing modules to subscribe to pipeline events that are raised later during request processing.

### Other application changes

Other changes in the behavior of ASP.NET applications and APIs.

#### 19. DefaultHttpHandler is not supported, so applications relying on sub-classes of DefaultHttpHandler will not be able to serve requests

If your application uses DefaultHttpHandler or handlers that derive from DefaultHttpHandler, it will not function correctly. In Integrated mode, handlers derived from DefaultHttpHandler will not be able to pass the request back to IIS for processing, and instead serve the requested resource as a static file. Integrated mode allows ASP.NET modules to run for all requests without requiring the use of DefaultHttpHandler.

##### Workaround

A. Change your application to use modules to perform request processing for all requests, instead of using wildcard mapping to map ASP.NET to all requests and then using DefaultHttpHandler derived handlers to pass the request back to IIS.

#### 20. It is possible to write to the response after an exception has occurred

In Integrated mode, it is possible to write to and display an additional response written after an exception has occurred, typically in modules that subscribe to the LogRequest and EndRequest events. This does not occur in Classic mode. If an error occurs during the request, and the application writes to the response in EndRequest after the exception has occurred, the response information written in EndRequest will be shown. This only affects requests that include unhandled exceptions. To avoid writing to the response after an exception, an application should check HttpContext.Error or HttpResponse.StatusCode before writing to the response.

#### 21. It is not possible to use the ClearError API to prevent an exception from being written to the response if the exception has occurred in a prior pipeline stage

##### Workaround

A. Change your application to call Server.ClearError from the Application\_OnError event handler, which is raised whenever an exception is thrown.

#### 22. HttpResponse.AppendToLog does not automatically prepend the querystring to the URL

When using HttpResponse.AppendToLog to append a custom string to the URL logged in the request log file, you will manually need to prepend the querystring to the string you pass to this API. This may result in existing code losing the querystring from the logged URL when this API is used.

##### Workaround

A. Change your application to manually prepend HttpResponse.QueryString.ToString() to the string passed to HttpResponse.AppendToLog.

### Other changes

Other changes.

#### 23. ASP.NET threading settings are not used to control the request concurrency in Integrated mode

The *minFreeThreads*, *minLocalRequestFreeThreads* settings in the *system.web/httpRuntime* configuration section and the *maxWorkerThreads* setting in the *processModel* configuration section no longer control the threading mechanism used by ASP.NET. Instead, ASP.NET relies on the IIS thread pool and allows you to control the maximum number of concurrently executing requests by setting the *MaxConcurrentRequestsPerCPU* DWORD value (default is 12) located in the HKEY\_LOCAL\_MACHINE\SOFTWARE\Microsoft\ASP.NET\2.0.50727.0 key. This setting is global and cannot be changed for individual application pools or applications.

##### Workaround

A. To control the concurrency of your application, set the MaxConcurrentRequestsPerCPU setting.

#### 24. ASP.NET application queues are not used in Integrated mode, so the "ASP.NET Applications\Requests in Application Queue" performance counter will always have a value of 0

ASP.NET does not use application queues in Integrated mode.

#### 25. IIS 7.0 and above always restarts ASP.NET applications when changes are made to the application's root web.config file, so waitChangeNotification and maxWaitChangeNotification attributes have no effect

IIS 7.0 and above monitors changes to the web.config files as well, and cause the ASP.NET application corresponding to this file to be restarted without regard to the ASP.NET change notification settings including the *waitChangeNotification* and *maxWaitChangeNotification* attributes in the system.web/httpRuntime configuration sections.

We hope that your move to the Integrated mode in IIS 7.0 and above is as painless as possible, so you can immediately start to take advantage of the IIS features and the power of Integrated ASP.NET in your applications.

Let us know if you are having trouble with any of these breaking changes, or if you encounter another behavior change in your application not listed here, by posting on the [IIS.NET forums](https://forums.iis.net/ "IIS.NET Forums").