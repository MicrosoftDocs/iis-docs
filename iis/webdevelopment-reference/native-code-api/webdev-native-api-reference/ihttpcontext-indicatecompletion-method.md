---
title: "IHttpContext::IndicateCompletion Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 02555911-f488-b3e9-74d9-97a0b3bd5b89
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::IndicateCompletion Method
Indicates the completion of asynchronous work and requests that IIS resume execution on the calling thread.  
  
## Syntax  
  
```cpp  
virtual VOID IndicateCompletion(  
   IN REQUEST_NOTIFICATION_STATUS notificationStatus  
) = 0;  
```  
  
#### Parameters  
 `notificationStatus`  
 [IN] The notification status of the asyncronous operation.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 An HTTP module can use the `IndicateCompletion` method to indicate that an asynchronous operation has completed and request that IIS resume processing on the calling thread. This behavior is unlike the behavior of the [PostCompletion](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-postcompletion-method.md) method, which queues the execution to the thread pool.  
  
 If the status that is specified by the `notificationStatus` parameter is not [REQUEST_NOTIFICATION_PENDING](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-notification-status-enumeration.md), the request state computer will continue without reentering the original notification entry point.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `IndicateCompletion` method to indicate that an asynchronous operation has completed.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextIndicateCompletion#1](IHttpContextIndicateCompletion#1)]  -->  
  
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
 [IHttpContext::PostCompletion Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-postcompletion-method.md)