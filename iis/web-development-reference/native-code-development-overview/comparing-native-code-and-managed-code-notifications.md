---
title: "Comparing Native-Code and Managed-Code Notifications | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7c240516-85f0-441a-8d2a-b8aebd6884a7
caps.latest.revision: 5
author: "shirhatti"
manager: "wpickett"
---
# Comparing Native-Code and Managed-Code Notifications
Although the integrated request-processing pipeline in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] Web server core enables native-code developers to write HTTP modules in C++, the event notifications that are available to native-code and managed-code developers are not identical. Developers who are migrating an HTTP module from a managed language such as C# to native code will have to address these differences when they create their new modules.  
  
## Global Notifications  
 With [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)], developers can now create native-code HTTP modules that process notifications at the global level. In previous versions of IIS, developers could create HTTP modules that processed notifications at only the request-level. HTTP modules that process notifications at the global level are used to process notifications for a variety of server-level events.  
  
 The following table lists the global notification methods that are available to native-code developers.  
  
|Event notification method|Description|  
|-------------------------------|-----------------|  
|OnGlobalApplicationResolveModules|Called when IIS resolves the registered modules.|  
|OnGlobalApplicationStart|Called when IIS starts an application.|  
|OnGlobalApplicationStop|Called when IIS exits an application.|  
|OnGlobalCacheCleanup|Called when IIS clears the cache.|  
|OnGlobalCacheOperation|Called when IIS performs a cache-related operation.|  
|OnGlobalConfigurationChange|Called when a change is made to a configuration file.|  
|OnGlobalCustomNotification|Called when a module raises a user-defined notification.|  
|OnGlobalFileChange|Called when a file within a Web site is changed.|  
|OnGlobalHealthCheck|Called when a health-related operation is executed.|  
|OnGlobalPreBeginRequest|Called before a request enters the integrated request-processing pipeline.|  
|OnGlobalRSCAQuery|Called when a Run-Time Status and Control query is executed.|  
|OnGlobalStopListening|Called when IIS stops accepting new requests.|  
|OnGlobalThreadCleanup|Called when IIS returns a thread to the thread pool.|  
|OnGlobalTraceEvent|Called when a trace event is raised.|  
  
## Comparing Request Notifications  
 Although request notification methods for native-code and managed-code HTTP modules are similar in many ways, they are not completely analogous. For example, the list of deterministic request notification methods is nearly identical for native-code and managed-code modules, yet the list of nondeterministic request notification methods differs greatly.  
  
### Native-Code Deterministic Request Notifications  
 The following table lists the deterministic request notification methods that are available to native-code developers.  
  
|Event notification method|Post-event notification method|  
|-------------------------------|-------------------------------------|  
|OnBeginRequest|OnPostBeginRequest|  
|OnAuthenticateRequest|OnPostAuthenticateRequest|  
|OnAuthorizeRequest|OnPostAuthorizeRequest|  
|OnResolveRequestCache|OnPostResolveRequestCache|  
|OnMapRequestHandler|OnPostMapRequestHandler|  
|OnAcquireRequestState|OnPostAcquireRequestState|  
|OnPreExecuteRequestHandler|OnPostPreExecuteRequestHandler|  
|OnExecuteRequestHandler|OnPostExecuteRequestHandler|  
|OnReleaseRequestState|OnPostReleaseRequestState|  
|OnUpdateRequestCache|OnPostUpdateRequestCache|  
|OnLogRequest|OnPostLogRequest|  
|OnEndRequest|OnPostEndRequest|  
  
### Managed-Code Deterministic Request Notifications  
 The following table lists the deterministic request notification methods that are available to managed-code developers.  
  
|Event notification method|Post-event notification method|  
|-------------------------------|-------------------------------------|  
|BeginRequest|(None)|  
|AuthenticateRequest|PostAuthenticateRequest|  
|AuthorizeRequest|PostAuthorizeRequest|  
|ResolveRequestCache|PostResolveRequestCache|  
|MapRequestHandler|PostMapRequestHandler|  
|AcquireRequestState|PostAcquireRequestState|  
|PreRequestHandlerExecute|(None)|  
|RequestHandlerExecute|PostRequestHandlerExecute|  
|ReleaseRequestState|PostReleaseRequestState|  
|UpdateRequestCache|PostUpdateRequestCache|  
|LogRequest|PostLogRequest|  
|EndRequest|(None)|  
  
### Native-Code Nondeterministic Request Notifications  
 The following table lists the nondeterministic request notification methods that are available to native-code developers.  
  
|Event notification method|Post-event notification method|  
|-------------------------------|-------------------------------------|  
|OnAsyncCompletion|(None)|  
|OnCustomRequestNotification|(None)|  
|OnMapPath|(None)|  
|OnReadEntity|(None)|  
|OnSendResponse|(None)|  
  
### Managed-Code Nondeterministic Request Notifications  
 The following table lists the nondeterministic request notification methods that are available to managed-code developers.  
  
|Event notification method|Post-event notification method|  
|-------------------------------|-------------------------------------|  
|PreSendRequestHeaders|(None)|  
|PreSendRequestContent|(None)|  
  
## See Also  
 [Creating Native-Code HTTP Modules](../../web-development-reference\native-code-development-overview\creating-native-code-http-modules.md)   
 [Designing Native-Code HTTP Modules](../../web-development-reference\native-code-development-overview\designing-native-code-http-modules.md)