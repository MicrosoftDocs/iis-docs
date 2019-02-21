---
title: "IHttpContext::IndicateCompletion Method"
ms.date: "10/07/2016"
ms.assetid: 02555911-f488-b3e9-74d9-97a0b3bd5b89
---
# IHttpContext::IndicateCompletion Method
Indicates the completion of asynchronous work and requests that IIS resume execution on the calling thread.  
  
## Syntax  
  
```cpp  
virtual VOID IndicateCompletion(  
   IN REQUEST_NOTIFICATION_STATUS notificationStatus  
) = 0;  
```  
  
### Parameters  
 `notificationStatus`  
 [IN] The notification status of the asyncronous operation.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 An HTTP module can use the `IndicateCompletion` method to indicate that an asynchronous operation has completed and request that IIS resume processing on the calling thread. This behavior is unlike the behavior of the [PostCompletion](../../web-development-reference\native-code-api-reference/ihttpcontext-postcompletion-method.md) method, which queues the execution to the thread pool.  
  
 If the status that is specified by the `notificationStatus` parameter is not [REQUEST_NOTIFICATION_PENDING](../../web-development-reference\native-code-api-reference/request-notification-status-enumeration.md), the request state computer will continue without reentering the original notification entry point.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `IndicateCompletion` method to indicate that an asynchronous operation has completed.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextIndicateCompletion#1](IHttpContextIndicateCompletion#1)]  -->  
  
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
 [IHttpContext::PostCompletion Method](../../web-development-reference\native-code-api-reference/ihttpcontext-postcompletion-method.md)