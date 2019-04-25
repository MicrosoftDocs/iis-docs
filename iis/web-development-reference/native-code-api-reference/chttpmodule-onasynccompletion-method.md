---
title: "CHttpModule::OnAsyncCompletion Method"
ms.date: "10/07/2016"
ms.assetid: b11efc80-7135-b1c5-0c2d-93cfda92f783
---
# CHttpModule::OnAsyncCompletion Method
Represents the method that will handle an asynchronous completion event, which occurs after an asynchronous operation has finished processing.  
  
## Syntax  
  
```cpp  
virtual REQUEST_NOTIFICATION_STATUS OnAsyncCompletion(  
   IN IHttpContext* pHttpContext,  
   IN DWORD dwNotification,  
   IN BOOL fPostNotification,  
   IN OUT IHttpEventProvider* pProvider,  
   IN IHttpCompletionInfo* pCompletionInfo  
);  
```  
  
### Parameters  
 `pHttpContext`  
 [IN] A pointer to an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) interface.  
  
 `dwNotification`  
 [IN] A `DWORD` value that contains the bitmask for the related notification.  
  
 `fPostNotification`  
 [IN] `true` to indicate that the notification is for a post-event; otherwise, `false`.  
  
 `pProvider`  
 [IN] A pointer to an [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md) interface.  
  
 `pCompletionInfo`  
 [IN] A pointer to an [IHttpCompletionInfo](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo-interface.md) interface.  
  
## Return Value  
 A [REQUEST_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) value.  
  
## Remarks  
 Unlike many of the other [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) methods that are called by registering for specific notifications, IIS will call a module's `OnAsyncCompletion` method only when an asynchronous operation has finished. For example, when a request-level module calls the [IHttpResponse::WriteEntityChunks](../../web-development-reference/native-code-api-reference/ihttpresponse-writeentitychunks-method.md) method and specifies asynchronous completion, IIS will call the module's `OnAsyncCompletion` method when the operation is complete.  
  
 When IIS calls the `OnAsyncCompletion` method, it will specify the notification type in the `dwNotification` parameter, and it will indicate whether the notification was for an event or post-event by using the `fPostNotification` parameter. IIS also provides an `IHttpCompletionInfo` interface that is pointed to by the `pCompletionInfo` parameter. You can use this interface to retrieve additional information about the asynchronous completion.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  The module registers for the [RQ_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [RQ_MAP_REQUEST_HANDLER](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notifications.  
  
2.  The module creates a `CHttpModule` class that contains [OnBeginRequest](../../web-development-reference/native-code-api-reference/chttpmodule-onbeginrequest-method.md), [OnMapRequestHandler](../../web-development-reference/native-code-api-reference/chttpmodule-onmaprequesthandler-method.md), and `OnAsyncCompletion` methods.  
  
3.  When a Web client requests a URL, IIS calls the module's `OnBeginRequest` method. This method performs the following tasks:  
  
    1.  Clears the existing response buffer and sets the MIME type for the response.  
  
    2.  Creates an example string and returns that to the Web client asynchronously.  
  
    3.  Tests for an error or asynchronous completion. If asynchronous completion is pending, the module returns a pending notification status to the integrated request-processing pipeline.  
  
4.  IIS calls the module's `OnMapRequestHandler` method. This method performs the following tasks:  
  
    1.  Flushes the current response buffer to the Web client.  
  
    2.  Tests for an error or asynchronous completion. If asynchronous completion is pending, the module returns a pending notification status to the pipeline.  
  
5.  If asynchronous completion is required, IIS calls the module's `OnAsyncCompletion` method. This method performs the following tasks:  
  
    1.  Tests for a valid `IHttpCompletionInfo` interface. If a valid `IHttpCompletionInfo` interface was passed, the method calls the [GetCompletionBytes](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo-getcompletionbytes-method.md) and [GetCompletionStatus](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo-getcompletionstatus-method.md) methods, respectively, to retrieve the completed bytes and return the status for the asynchronous operation.  
  
    2.  Creates strings that contain the completion information and writes the information as an event to the application log of the Event Viewer.  
  
6.  The module removes the `CHttpModule` class from memory and then exits.  
  
 [!code-cpp[IHttpCompletionInfoIHttpCompletionInfo#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpCompletionInfoIHttpCompletionInfo/cpp/IHttpCompletionInfoIHttpCompletionInfo.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CHttpModule Class](../../web-development-reference/native-code-api-reference/chttpmodule-class.md)