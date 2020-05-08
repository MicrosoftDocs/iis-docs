---
title: "IHttpCompletionInfo::GetCompletionBytes Method"
ms.date: "10/07/2016"
ms.assetid: 1562904a-cf4d-50e3-802d-f11702097944
---
# IHttpCompletionInfo::GetCompletionBytes Method
Returns the number of bytes completed for an asynchronous operation.  
  
## Syntax  
  
```cpp  
virtual DWORD GetCompletionBytes(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that contains the number of bytes.  
  
## Remarks  
 The `GetCompletionBytes` method allows you to retrieve the number of bytes that were completed during an asynchronous operation. When an operation completes asynchronously, IIS creates an [IHttpCompletionInfo](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo-interface.md) interface and passes that interface to your module's [CHttpModule::OnAsyncCompletion](../../web-development-reference/native-code-api-reference/chttpmodule-onasynccompletion-method.md) method to process the results of the asynchronous operation. You can then use `GetCompletionBytes` to retrieve the completed bytes for the asynchronous operation.  
  
 For example, if your module requested the [IHttpRequest::ReadEntityBody](../../web-development-reference/native-code-api-reference/ihttprequest-readentitybody-method.md) method to complete asynchronously, `GetCompletionBytes` would return the number of bytes read. Similarly, if your module requested asynchronous completion of the [IIHttpResponse::Flush](../../web-development-reference/native-code-api-reference/ihttpresponse-flush-method.md) method, `GetCompletionBytes` would return the number of bytes flushed to the client. In addition, `GetCompletionBytes` returns the number of bytes that you specify when you call the [IHttpContext::PostCompletion](../../web-development-reference/native-code-api-reference/ihttpcontext-postcompletion-method.md) method.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1. The module registers for the [RQ_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [RQ_MAP_REQUEST_HANDLER](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notifications.  
  
2. The module creates a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class that contains [OnBeginRequest](../../web-development-reference/native-code-api-reference/chttpmodule-onbeginrequest-method.md), [OnMapRequestHandler](../../web-development-reference/native-code-api-reference/chttpmodule-onmaprequesthandler-method.md), and `OnAsyncCompletion` methods.  
  
3. When a Web client requests a URL, IIS calls the module's `OnBeginRequest` method. This method performs the following tasks:  
  
    1. Clears the existing response buffer and sets the MIME type for the response.  
  
    2. Creates an example string and returns that to the Web client asynchronously.  
  
    3. Tests for an error or asynchronous completion. If asynchronous completion is pending, the module returns a pending notification status to the integrated request-processing pipeline.  
  
4. IIS then calls the module's `OnMapRequestHandler` method. This method performs the following tasks:  
  
    1. Flushes the current response buffer to the Web client.  
  
    2. Tests for an error or asynchronous completion. If asynchronous completion is pending, the module returns a pending notification status to the pipeline.  
  
5. If asynchronous completion is required, IIS calls the module's `OnAsyncCompletion` method. This method performs the following tasks:  
  
    1. Tests for a valid `IHttpCompletionInfo` interface. If a valid `IHttpCompletionInfo` interface was passed, the method calls the `GetCompletionBytes` and [GetCompletionStatus](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo-getcompletionstatus-method.md) methods, respectively, to retrieve the completed bytes and return the status for the asynchronous operation.  
  
    2. Creates strings that contain the completion information and writes the information as an event to the application log of the Event Viewer.  
  
6. The module removes the `CHttpModule` class from memory and then exits.  
  
 [!code-cpp[IHttpCompletionInfoIHttpCompletionInfo#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpCompletionInfoIHttpCompletionInfo/cpp/IHttpCompletionInfoIHttpCompletionInfo.cpp#1)]  
  
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
 [IHttpCompletionInfo Interface](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo-interface.md)   
 [IHttpCompletionInfo::GetCompletionStatus Method](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo-getcompletionstatus-method.md)
