---
title: "IHttpCompletionInfo::GetCompletionStatus Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d6f1d9fb-5344-13b2-5ffe-eeba3a6a1fd8
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IHttpCompletionInfo::GetCompletionStatus Method
Returns the status of an asynchronous operation.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetCompletionStatus(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 An `HRESULT` that contains the status for the asynchronous operation.  
  
## Remarks  
 The `GetCompletionStatus` method allows you to retrieve the status of an asynchronous operation. When you request an asynchronous operation, [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] creates an [IHttpCompletionInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcompletioninfo-interface.md) interface and passes that interface to your module's [CHttpModule::OnAsyncCompletion](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onasynccompletion-method.md) method to process the asynchronous operation. You can then use the `GetCompletionStatus` method to retrieve the status for the asynchronous operation.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  The module registers for the [RQ_BEGIN_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and [RQ_MAP_REQUEST_HANDLER](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notifications.  
  
2.  The module creates a [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) class that contains [OnBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onbeginrequest-method.md), [OnMapRequestHandler](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onmaprequesthandler-method.md), and `OnAsyncCompletion` methods.  
  
3.  When a Web client requests a URL, IIS calls the module's `OnBeginRequest` method. This method performs the following tasks:  
  
    1.  Clears the existing response buffer and sets the MIME type for the response.  
  
    2.  Creates an example string and returns that to the Web client asynchronously.  
  
    3.  Tests for an error or asynchronous completion. If asynchronous completion is pending, the module returns a pending notification status to the integrated request-processing pipeline.  
  
4.  IIS then calls the module's `OnMapRequestHandler` method. This method performs the following tasks:  
  
    1.  Flushes the current response buffer to the Web client.  
  
    2.  Tests for an error or asynchronous completion. If asynchronous completion is pending, the module returns a pending notification status to the pipeline.  
  
5.  If asynchronous completion is required, IIS calls the module's `OnAsyncCompletion` method. This method performs the following tasks:  
  
    1.  Tests for a valid `IHttpCompletionInfo` interface. If a valid `IHttpCompletionInfo` interface was passed, the method calls the [GetCompletionBytes](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcompletioninfo-getcompletionbytes-method.md) and `GetCompletionStatus` methods, respectively, to retrieve the completed bytes and return the status for the asynchronous operation.  
  
    2.  Creates strings that contain the completion information and writes the information as an event to the application log of the Event Viewer.  
  
6.  The module removes the `CHttpModule` class from memory and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpCompletionInfoIHttpCompletionInfo#1](IHttpCompletionInfoIHttpCompletionInfo#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCompletionInfo Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcompletioninfo-interface.md)   
 [IHttpCompletionInfo::GetCompletionBytes Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcompletioninfo-getcompletionbytes-method.md)