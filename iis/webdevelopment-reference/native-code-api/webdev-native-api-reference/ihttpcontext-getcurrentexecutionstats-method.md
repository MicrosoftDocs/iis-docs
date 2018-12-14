---
title: "IHttpContext::GetCurrentExecutionStats Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 583768f4-5b0d-25af-df8d-3f34126663ca
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::GetCurrentExecutionStats Method
Retrieves the execution statistics for the current context.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetCurrentExecutionStats(  
   DWORD* pdwNotification,  
   DWORD* pdwNotificationStartTickCount = NULL,  
   PCWSTR* ppszModule = NULL,  
   DWORD* pdwModuleStartTickCount = NULL,  
   DWORD* pdwAsyncNotification = NULL,  
   DWORD* pdwAsyncNotificationStartTickCount = NULL  
) const = 0;  
```  
  
#### Parameters  
 `pdwNotification`  
 A pointer to a `DWORD` that contains the current notification.  
  
 `pdwNotificationStartTickCount`  
 A pointer to a `DWORD` that contains the tick count for the start of the current notification.  
  
 `ppszModule`  
 A pointer to a string that contains the name of the current module.  
  
 `pdwModuleStartTickCount`  
 A pointer to a `DWORD` that contains the tick count for the start of the current module.  
  
 `pdwAsyncNotification`  
 A pointer to a `DWORD` that contains the current asynchronous notification.  
  
 `pdwAsyncNotificationStartTickCount`  
 A pointer to a `DWORD` that contains the tick count for the start of an asynchronous notification.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|NO_ERROR|Indicates that the operation was successful.|  
|E_INVALIDARG|Indicates that a specified parameter is not valid.|  
  
## Remarks  
 Developers can use the `GetCurrentExecutionStats` method to retrieve specific execution information for the current context. For example, the `pdwNotification` and `pdwAsyncNotification` parameters contain the values for the current synchronous or asynchronous notification, and the `ppszModule` parameter contains the name of the module for the current context.  
  
 Three of the return parameters, `pdwModuleStartTickCount`, `pdwNotificationStartTickCount`, and `pdwAsyncNotificationStartTickCount`, respectively, contain the tick counts for the start of the module and the start of the current synchronous and asynchronous notifications.  
  
> [!NOTE]
>  The tick count is the number of milliseconds that have elapsed since the system was started. For more information about retrieving tick counts, see the [GetTickCount](http://go.microsoft.com/fwlink/?LinkId=63276) method.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  The module registers for the [RQ_BEGIN_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md), [RQ_MAP_REQUEST_HANDLER](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md), and [RQ_SEND_RESPONSE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notifications.  
  
2.  The module creates a [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) class that contains [OnBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onbeginrequest-method.md), [OnMapRequestHandler](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onmaprequesthandler-method.md), and [OnSendResponse](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onsendresponse-method.md) methods.  
  
3.  When a Web client requests a URL, IIS calls the module's `OnBeginRequest`, `OnMapRequestHandler`, and `OnSendResponse` methods. Each of these methods calls a private method named `RetrieveExecutionStats` that performs the following tasks:  
  
    1.  Retrieves the execution statistics by using the `GetCurrentExecutionStats` method and tests for an error.  
  
    2.  Creates a string that contains the tick count for the start of the current notification.  
  
    3.  Pauses for one second.  
  
    4.  Creates a string that contains the elapsed tick count from the start of the current notification.  
  
    5.  Writes the execution statistics as an event to the application log of the Event Viewer.  
  
4.  The module removes the `CHttpModule` class from memory and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetCurrentExecutionStats#1](IHttpContextGetCurrentExecutionStats#1)]  -->  
  
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
 [IHttpContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)