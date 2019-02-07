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
 [IN] The [REQUEST_NOTIFICATION_STATUS](../../web-development-reference\native-code-api-reference/request-notification-status-enumeration.md) enumeration value to return from the current notification.  
  
 `pdwNotification`  
 [OUT] A pointer to a `DWORD` that contains the bitmask value for the next notification.  
  
 `pfIsPostNotification`  
 [OUT] A pointer to a Boolean value. `true` to indicate that the notification is a post-notification; otherwise, `false`.  
  
 `ppModuleInfo`  
 [OUT] A pointer to the address of the [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) class that is responsible for processing the returned notification.  
  
 `ppRequestOutput`  
 [OUT] A pointer to the address of the [IHttpEventProvider](../../web-development-reference\native-code-api-reference/ihttpeventprovider-interface.md) interface for the returned notification.  
  
## Return Value  
 `true` if the call to `GetNextNotification` was successful; otherwise, `false`.  
  
## Remarks  
 HTTP modules can use the `GetNextNotification` method to merge notifications within the same module host. Returning processing to the integrated request-processing pipeline requires a small amount of overhead. To bypass that overhead, an HTTP module can call the `GetNextNotification` method to skip to the next notification and continue processing, provided that the two notifications are within the same module host and no additional notification handlers are registered to process a request between notifications.  
  
 For example, an HTTP module might contain an [OnResolveRequestCache](../../web-development-reference\native-code-api-reference/chttpmodule-onresolverequestcache-method.md) method, and another HTTP module within the same module host might contain an [OnPostResolveRequestCache](../../web-development-reference\native-code-api-reference/chttpmodule-onpostresolverequestcache-method.md) method. The first module can call the `GetNextNotification` method to continue processing, rather than returning processing to the pipeline, as though the module had already registered for the `OnPostResolveRequestCache` post-event notification method.  
  
> [!NOTE]
>  If the call to `GetNextNotification` returns `false`, you can enable a failed-request-tracing rule that will allow you to examine which notifications IIS is processing.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  Registers for several notifications.  
  
2.  Creates a helper method that calls the `GetNextNotification` method, which attempts to skip to the next notification.  
  
3.  For each registered notification, defines notification handlers that call the helper method, and then displays the return status to the client.  
  
<!-- TODO: review snippet reference  [!CODE [IhttpContextGetNextNotification#1](IhttpContextGetNextNotification#1)]  -->  
  
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