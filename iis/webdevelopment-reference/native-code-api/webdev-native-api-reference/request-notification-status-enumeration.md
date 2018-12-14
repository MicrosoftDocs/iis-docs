---
title: "REQUEST_NOTIFICATION_STATUS Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 318f6aef-c052-9021-b89f-fbcfe9caf014
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# REQUEST_NOTIFICATION_STATUS Enumeration
Defines the return values for request-level notifications.  
  
## Syntax  
  
```cpp  
typedef enum REQUEST_NOTIFICATION_STATUS{  
   RQ_NOTIFICATION_CONTINUE,  
   RQ_NOTIFICATION_PENDING,  
   RQ_NOTIFICATION_FINISH_REQUEST  
};  
```  
  
## Members  
  
|Member name|Description|  
|-----------------|-----------------|  
|`RQ_NOTIFICATION_CONTINUE`|Indicates that IIS should continue processing additional request-level notifications.|  
|`RQ_NOTIFICATION_PENDING`|Indicates that an asynchronous notification is pending and returns request-level processing to IIS.|  
|`RQ_NOTIFICATION_FINISH_REQUEST`|Indicates that IIS has finished processing request-level notifications and should not process any additional request-level notifications.|  
  
## Remarks  
 The members of the `REQUEST_NOTIFICATION_STATUS` enumeration are used as return values from request-level notifications, and the members help to control process flow within the integrated request-processing pipeline. For example, returning `RQ_NOTIFICATION_CONTINUE` from a request-level notification handler instructs IIS to continue processing additional request-level notifications, whereas returning `RQ_NOTIFICATION_FINISH_REQUEST` from a request-level notification handler informs IIS that request-level processing is complete and IIS should not process additional request-level notifications. Modules that implement request handling should return `RQ_NOTIFICATION_FINISH_REQUEST` when an error occurs.  
  
## Example  
 The following example implements a `RQ_BEGIN_REQUEST` handler. If the request is not an HTML file, the example returns `RQ_NOTIFICATION_CONTINUE` and normal processing occurs. When the counter value has a zero remainder, the requested file is replaced by a string returned by the [IHttpResponse::WriteEntityChunkByReference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-writeentitychunkbyreference-method.md) method and the example returns `RQ_NOTIFICATION_FINISH_REQUEST`. If an error occurs, the example logs the error and returns `RQ_NOTIFICATION_FINISH_REQUEST`.  
  
<!-- TODO: review snippet reference  [!CODE [_RaiseEvnt#2](_RaiseEvnt#2)]  -->  
<!-- TODO: review snippet reference [!CODE [_RaiseEvnt#1](_RaiseEvnt#1)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Enumerations](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-enumerations.md)   
 [GLOBAL_NOTIFICATION_STATUS Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/global-notification-status-enumeration.md)