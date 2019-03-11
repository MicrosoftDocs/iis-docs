---
title: "IHttpContext::GetCurrentExecutionStats Method"
ms.date: "10/07/2016"
ms.assetid: 583768f4-5b0d-25af-df8d-3f34126663ca
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
  
### Parameters  
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
>  The tick count is the number of milliseconds that have elapsed since the system was started. For more information about retrieving tick counts, see the [GetTickCount](https://go.microsoft.com/fwlink/?LinkId=63276) method.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  The module registers for the [RQ_BEGIN_REQUEST](../../web-development-reference\native-code-api-reference/request-processing-constants.md), [RQ_MAP_REQUEST_HANDLER](../../web-development-reference\native-code-api-reference/request-processing-constants.md), and [RQ_SEND_RESPONSE](../../web-development-reference\native-code-api-reference/request-processing-constants.md) notifications.  
  
2.  The module creates a [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) class that contains [OnBeginRequest](../../web-development-reference\native-code-api-reference/chttpmodule-onbeginrequest-method.md), [OnMapRequestHandler](../../web-development-reference\native-code-api-reference/chttpmodule-onmaprequesthandler-method.md), and [OnSendResponse](../../web-development-reference\native-code-api-reference/chttpmodule-onsendresponse-method.md) methods.  
  
3.  When a Web client requests a URL, IIS calls the module's `OnBeginRequest`, `OnMapRequestHandler`, and `OnSendResponse` methods. Each of these methods calls a private method named `RetrieveExecutionStats` that performs the following tasks:  
  
    1.  Retrieves the execution statistics by using the `GetCurrentExecutionStats` method and tests for an error.  
  
    2.  Creates a string that contains the tick count for the start of the current notification.  
  
    3.  Pauses for one second.  
  
    4.  Creates a string that contains the elapsed tick count from the start of the current notification.  
  
    5.  Writes the execution statistics as an event to the application log of the Event Viewer.  
  
4.  The module removes the `CHttpModule` class from memory and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetCurrentExecutionStats#1](IHttpContextGetCurrentExecutionStats#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md)