---
title: "IHttpContext Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 133e92d0-4bba-5224-6deb-f369379be302
caps.latest.revision: 27
author: "shirhatti"
ms.author: "robmcm"
manager: "wpickett"
---
# IHttpContext Interface
Defines an object that represents the processing context for request-level operations.  
  
## Syntax  
  
```cpp  
class IHttpContext  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpContext` class.  
  
|Name|Description|  
|----------|-----------------|  
|[AllocateRequestMemory](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-allocaterequestmemory-method.md)|Allocates a specified amount of memory.|  
|[CancelIo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-cancelio-method.md)|Cancels any pending send or receive operations.|  
|[CloneContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-clonecontext-method.md)|Creates a clone of the current request context.|  
|[DisableNotifications](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-disablenotifications-method.md)|Disables specific notifications that are pending for this request in the current module.|  
|[ExecuteRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-executerequest-method.md)|Executes a child request.|  
|[GetApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getapplication-method.md)|Retrieves the application container for the current context.|  
|[GetConnection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getconnection-method.md)|Retrieves the connection container for the current context.|  
|[GetCurrentExecutionStats](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getcurrentexecutionstats-method.md)|Retrieves the execution statistics for the current context.|  
|[GetExecuteFlags](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getexecuteflags-method.md)|Retrieves the execution flags for the current context.|  
|[GetFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getfileinfo-method.md)|Retrieves the file information container for the current context.|  
|[GetIsLastNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getislastnotification-method.md)|Indicates whether more notifications are pending for this request within the current module host.|  
|[GetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getmetadata-method.md)|Retrieves the metadata container for the current request context.|  
|[GetModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getmodulecontextcontainer-method.md)|Retrieves the module context container for the current context.|  
|[GetNextNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getnextnotification-method.md)|Retrieves the next notification for the current module host.|  
|[GetParentContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getparentcontext-method.md)|Retrieves a pointer to the parent context for the current context.|  
|[GetPhysicalPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getphysicalpath-method.md)|Retrieves the physical path for the current request.|  
|[GetRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getrequest-method.md)|Returns the HTTP request container for the current context.|  
|[GetResponse](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getresponse-method.md)|Returns the HTTP response container for the current context.|  
|[GetResponseHeadersSent](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getresponseheaderssent-method.md)|Determines whether the HTTP response headers have been sent to the client.|  
|[GetRootContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getrootcontext-method.md)|Retrieves a pointer to the root context for the current context.|  
|[GetScriptMap](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getscriptmap-method.md)|Retrieves the script map container for the current context.|  
|[GetScriptName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getscriptname-method.md)|Retrieves the URL for the current request.|  
|[GetScriptTranslated](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getscripttranslated-method.md)|Retrieves the physical path of the current request.|  
|[GetServerVarChanges](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getservervarchanges-method.md)|Retrieves the changes to the server variables for the current context.|  
|[GetServerVariable](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getservervariable-method.md)|Retrieves a specific server variable.|  
|[GetSite](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getsite-method.md)|Retrieves the site information container for the current context.|  
|[GetTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-gettracecontext-method.md)|Retrieves the trace context container for the current context.|  
|[GetUrlInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-geturlinfo-method.md)|Retrieves the URL information container for the current context.|  
|[GetUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getuser-method.md)|Retrieves the user information container for the current context.|  
|[IndicateCompletion](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-indicatecompletion-method.md)|Indicates the completion of asynchronous work and requests IIS to resume execution on the calling thread.|  
|[MapHandler](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-maphandler-method.md)|Maps a handler for a give URL, HTTP verb pair on a site.|  
|[MapPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-mappath-method.md)|Returns the physical path of a relative URL.|  
|[NotifyCustomNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-notifycustomnotification-method.md)|Raises a custom request-level notification.|  
|[PostCompletion](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-postcompletion-method.md)|Indicates the completion of asynchronous work and requests IIS to queue execution to the thread pool.|  
|[ReleaseClonedContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-releaseclonedcontext-method.md)|Releases a cloned `IHttpContext` instance.|  
|[SetRequestHandled](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-setrequesthandled-method.md)|Indicates that the handlers for the current request have completed.|  
|[SetServerVariable](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-setservervariable-method.md)|Sets a server variable to a specified value.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpContext2](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext2-interface.md)|Represents the reprocessing of an HTTP request and enables the retrieval of information about the original user during asynchronous operation.|  
|[IHttpContext3](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext3-interface.md)|Represents the reprocessing of an HTTP request and enables additional support for asynchronous operations.|  
|[IHttpContext4](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext4-interface.md)|Represents the reprocessing of an HTTP request and enables additional support for diagnostic operations.|  
  
## Remarks  
 The `IHttpContext` interface represents the main programmatic interface for HTTP modules to access information about the current request-level context. This interface retrieves several additional interfaces that you can use when writing HTTP modules.  
  
 For example, the `GetRequest` and `GetResponse` methods retrieve, respectively, the [IHttpRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-interface.md) and [IHttpResponse](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-interface.md) interfaces for the current context. These interfaces allow developers to access or modify the request body and response body, HTTP headers, server behavior, and so on.  
  
 [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] allows you to create and execute child contexts through the `IHttpContext` interface by using the `CloneContext`, `ExecuteRequest`, and `ReleaseClonedContext` methods. IIS also provides the `GetParentContext` and `GetRootContext` methods to help developers write HTTP modules that can change behavior depending on whether the current context is a root, child, or parent context.  
  
 `IHttpContext` also provides several methods to help developers control the behavior of notifications. For example, you can use the `DisableNotifications` method to disable notifications or the `GetIsLastNotification` method to determine whether there are any remaining notifications. Additionally, you can use the `GetNextNotification` method to merge notifications or the `NotifyCustomNotification` method to raise a custom notification.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)