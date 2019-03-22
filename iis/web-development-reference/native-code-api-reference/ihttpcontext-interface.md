---
title: "IHttpContext Interface"
ms.date: "10/07/2016"
ms.assetid: 133e92d0-4bba-5224-6deb-f369379be302
ms.author: "robmcm"
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
|[AllocateRequestMemory](../../web-development-reference/native-code-api-reference/ihttpcontext-allocaterequestmemory-method.md)|Allocates a specified amount of memory.|  
|[CancelIo](../../web-development-reference/native-code-api-reference/ihttpcontext-cancelio-method.md)|Cancels any pending send or receive operations.|  
|[CloneContext](../../web-development-reference/native-code-api-reference/ihttpcontext-clonecontext-method.md)|Creates a clone of the current request context.|  
|[DisableNotifications](../../web-development-reference/native-code-api-reference/ihttpcontext-disablenotifications-method.md)|Disables specific notifications that are pending for this request in the current module.|  
|[ExecuteRequest](../../web-development-reference/native-code-api-reference/ihttpcontext-executerequest-method.md)|Executes a child request.|  
|[GetApplication](../../web-development-reference/native-code-api-reference/ihttpcontext-getapplication-method.md)|Retrieves the application container for the current context.|  
|[GetConnection](../../web-development-reference/native-code-api-reference/ihttpcontext-getconnection-method.md)|Retrieves the connection container for the current context.|  
|[GetCurrentExecutionStats](../../web-development-reference/native-code-api-reference/ihttpcontext-getcurrentexecutionstats-method.md)|Retrieves the execution statistics for the current context.|  
|[GetExecuteFlags](../../web-development-reference/native-code-api-reference/ihttpcontext-getexecuteflags-method.md)|Retrieves the execution flags for the current context.|  
|[GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md)|Retrieves the file information container for the current context.|  
|[GetIsLastNotification](../../web-development-reference/native-code-api-reference/ihttpcontext-getislastnotification-method.md)|Indicates whether more notifications are pending for this request within the current module host.|  
|[GetMetadata](../../web-development-reference/native-code-api-reference/ihttpcontext-getmetadata-method.md)|Retrieves the metadata container for the current request context.|  
|[GetModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpcontext-getmodulecontextcontainer-method.md)|Retrieves the module context container for the current context.|  
|[GetNextNotification](../../web-development-reference/native-code-api-reference/ihttpcontext-getnextnotification-method.md)|Retrieves the next notification for the current module host.|  
|[GetParentContext](../../web-development-reference/native-code-api-reference/ihttpcontext-getparentcontext-method.md)|Retrieves a pointer to the parent context for the current context.|  
|[GetPhysicalPath](../../web-development-reference/native-code-api-reference/ihttpcontext-getphysicalpath-method.md)|Retrieves the physical path for the current request.|  
|[GetRequest](../../web-development-reference/native-code-api-reference/ihttpcontext-getrequest-method.md)|Returns the HTTP request container for the current context.|  
|[GetResponse](../../web-development-reference/native-code-api-reference/ihttpcontext-getresponse-method.md)|Returns the HTTP response container for the current context.|  
|[GetResponseHeadersSent](../../web-development-reference/native-code-api-reference/ihttpcontext-getresponseheaderssent-method.md)|Determines whether the HTTP response headers have been sent to the client.|  
|[GetRootContext](../../web-development-reference/native-code-api-reference/ihttpcontext-getrootcontext-method.md)|Retrieves a pointer to the root context for the current context.|  
|[GetScriptMap](../../web-development-reference/native-code-api-reference/ihttpcontext-getscriptmap-method.md)|Retrieves the script map container for the current context.|  
|[GetScriptName](../../web-development-reference/native-code-api-reference/ihttpcontext-getscriptname-method.md)|Retrieves the URL for the current request.|  
|[GetScriptTranslated](../../web-development-reference/native-code-api-reference/ihttpcontext-getscripttranslated-method.md)|Retrieves the physical path of the current request.|  
|[GetServerVarChanges](../../web-development-reference/native-code-api-reference/ihttpcontext-getservervarchanges-method.md)|Retrieves the changes to the server variables for the current context.|  
|[GetServerVariable](../../web-development-reference/native-code-api-reference/ihttpcontext-getservervariable-method.md)|Retrieves a specific server variable.|  
|[GetSite](../../web-development-reference/native-code-api-reference/ihttpcontext-getsite-method.md)|Retrieves the site information container for the current context.|  
|[GetTraceContext](../../web-development-reference/native-code-api-reference/ihttpcontext-gettracecontext-method.md)|Retrieves the trace context container for the current context.|  
|[GetUrlInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-geturlinfo-method.md)|Retrieves the URL information container for the current context.|  
|[GetUser](../../web-development-reference/native-code-api-reference/ihttpcontext-getuser-method.md)|Retrieves the user information container for the current context.|  
|[IndicateCompletion](../../web-development-reference/native-code-api-reference/ihttpcontext-indicatecompletion-method.md)|Indicates the completion of asynchronous work and requests IIS to resume execution on the calling thread.|  
|[MapHandler](../../web-development-reference/native-code-api-reference/ihttpcontext-maphandler-method.md)|Maps a handler for a give URL, HTTP verb pair on a site.|  
|[MapPath](../../web-development-reference/native-code-api-reference/ihttpcontext-mappath-method.md)|Returns the physical path of a relative URL.|  
|[NotifyCustomNotification](../../web-development-reference/native-code-api-reference/ihttpcontext-notifycustomnotification-method.md)|Raises a custom request-level notification.|  
|[PostCompletion](../../web-development-reference/native-code-api-reference/ihttpcontext-postcompletion-method.md)|Indicates the completion of asynchronous work and requests IIS to queue execution to the thread pool.|  
|[ReleaseClonedContext](../../web-development-reference/native-code-api-reference/ihttpcontext-releaseclonedcontext-method.md)|Releases a cloned `IHttpContext` instance.|  
|[SetRequestHandled](../../web-development-reference/native-code-api-reference/ihttpcontext-setrequesthandled-method.md)|Indicates that the handlers for the current request have completed.|  
|[SetServerVariable](../../web-development-reference/native-code-api-reference/ihttpcontext-setservervariable-method.md)|Sets a server variable to a specified value.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpContext2](../../web-development-reference/native-code-api-reference/ihttpcontext2-interface.md)|Represents the reprocessing of an HTTP request and enables the retrieval of information about the original user during asynchronous operation.|  
|[IHttpContext3](../../web-development-reference/native-code-api-reference/ihttpcontext3-interface.md)|Represents the reprocessing of an HTTP request and enables additional support for asynchronous operations.|  
|[IHttpContext4](../../web-development-reference/native-code-api-reference/ihttpcontext4-interface.md)|Represents the reprocessing of an HTTP request and enables additional support for diagnostic operations.|  
  
## Remarks  
 The `IHttpContext` interface represents the main programmatic interface for HTTP modules to access information about the current request-level context. This interface retrieves several additional interfaces that you can use when writing HTTP modules.  
  
 For example, the `GetRequest` and `GetResponse` methods retrieve, respectively, the [IHttpRequest](../../web-development-reference/native-code-api-reference/ihttprequest-interface.md) and [IHttpResponse](../../web-development-reference/native-code-api-reference/ihttpresponse-interface.md) interfaces for the current context. These interfaces allow developers to access or modify the request body and response body, HTTP headers, server behavior, and so on.  
  
 [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] allows you to create and execute child contexts through the `IHttpContext` interface by using the `CloneContext`, `ExecuteRequest`, and `ReleaseClonedContext` methods. IIS also provides the `GetParentContext` and `GetRootContext` methods to help developers write HTTP modules that can change behavior depending on whether the current context is a root, child, or parent context.  
  
 `IHttpContext` also provides several methods to help developers control the behavior of notifications. For example, you can use the `DisableNotifications` method to disable notifications or the `GetIsLastNotification` method to determine whether there are any remaining notifications. Additionally, you can use the `GetNextNotification` method to merge notifications or the `NotifyCustomNotification` method to raise a custom notification.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.0 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)