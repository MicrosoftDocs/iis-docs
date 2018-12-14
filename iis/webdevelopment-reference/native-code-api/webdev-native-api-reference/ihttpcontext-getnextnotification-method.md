---
title: "IHttpContext::GetNextNotification Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c80eea1c-5c85-a1be-c990-ed8e89de7d78
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::GetNextNotification Method
Retrieves the next notification for the current module host.  
  
## Syntax  
  
```cpp  
virtual BOOL GetNextNotification(  
   IN REQUEST_NOTIFICATION_STATUS status,  
   OUT DWORD* pdwNotification,  
   OUT BOOL* pfIsPostNotification,  
   OUT CHttpModule** ppModuleInfo,  
   OUT IHttpEventProvider** ppRequestOutput  
) = 0;  
```  
  
#### Parameters  
 `status`  
 [IN] The [REQUEST_NOTIFICATION_STATUS](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-notification-status-enumeration.md) enumeration value to return from the current notification.  
  
 `pdwNotification`  
 [OUT] A pointer to a `DWORD` that contains the bitmask value for the next notification.  
  
 `pfIsPostNotification`  
 [OUT] A pointer to a Boolean value. `true` to indicate that the notification is a post-notification; otherwise, `false`.  
  
 `ppModuleInfo`  
 [OUT] A pointer to the address of the [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) class that is responsible for processing the returned notification.  
  
 `ppRequestOutput`  
 [OUT] A pointer to the address of the [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md) interface for the returned notification.  
  
## Return Value  
 `true` if the call to `GetNextNotification` was successful; otherwise, `false`.  
  
## Remarks  
 HTTP modules can use the `GetNextNotification` method to merge notifications within the same module host. Returning processing to the integrated request-processing pipeline requires a small amount of overhead. To bypass that overhead, an HTTP module can call the `GetNextNotification` method to skip to the next notification and continue processing, provided that the two notifications are within the same module host and no additional notification handlers are registered to process a request between notifications.  
  
 For example, an HTTP module might contain an [OnResolveRequestCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onresolverequestcache-method.md) method, and another HTTP module within the same module host might contain an [OnPostResolveRequestCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onpostresolverequestcache-method.md) method. The first module can call the `GetNextNotification` method to continue processing, rather than returning processing to the pipeline, as though the module had already registered for the `OnPostResolveRequestCache` post-event notification method.  
  
> [!NOTE]
>  If the call to `GetNextNotification` returns `false`, you can enable a failed-request-tracing rule that will allow you to examine which notifications IIS is processing.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  Registers for several notifications.  
  
2.  Creates a helper method that calls the `GetNextNotification` method, which attempts to skip to the next notification.  
  
3.  For each registered notification, defines notification handlers that call the helper method, and then displays the return status to the client.  
  
<!-- TODO: review snippet reference  [!CODE [IhttpContextGetNextNotification#1](IhttpContextGetNextNotification#1)]  -->  
  
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