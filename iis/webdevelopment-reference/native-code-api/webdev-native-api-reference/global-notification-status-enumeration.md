---
title: "GLOBAL_NOTIFICATION_STATUS Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8b0333b8-b0cd-4846-776d-29e52fbbb214
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# GLOBAL_NOTIFICATION_STATUS Enumeration
Defines the return values for global-level notifications.  
  
## Syntax  
  
```cpp  
typedef enum GLOBAL_NOTIFICATION_STATUS{  
   GL_NOTIFICATION_CONTINUE,  
   GL_NOTIFICATION_HANDLED  
};  
```  
  
## Members  
  
|Member name|Description|  
|-----------------|-----------------|  
|`GL_NOTIFICATION_CONTINUE`|Indicates that IIS should continue processing additional global-level notifications.|  
|`GL_NOTIFICATION_HANDLED`|Indicates that IIS has finished processing global-level notifications and should not process any additional global-level notifications.|  
  
## Remarks  
 The members of the `GLOBAL_NOTIFICATION_STATUS` enumeration are used as return values from global-level notifications, and the members help to control process flow within the global-level notification processing pipeline. For example, returning `GL_NOTIFICATION_CONTINUE` from a global-level notification handler instructs IIS to continue processing additional global-level notifications, whereas returning `GL_NOTIFICATION_HANDLED` from a global-level notification handler informs IIS that global-level processing is complete and IIS should not process additional global-level notifications.  
  
## Example  
 The following code example demonstrates how to create a simple "Hello World" global-level HTTP module. The module defines an exported [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function that creates an instance of a class that is derived from [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md). If the class cannot be created, the function exits with an error code; otherwise, the function calls the [IHttpModuleRegistrationInfo::SetRequestNotifications](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method to register for the [GL_PRE_BEGIN_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification.  
  
 When a `GL_PRE_BEGIN_REQUEST` notification occurs, IIS calls the module's [CGlobalModule::OnGlobalPreBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) method to process the notification. The method calls a private method to write an event to the application log of the Event Viewer, and then it returns `GL_NOTIFICATION_CONTINUE` to notify IIS to continue processing other notifications. When processing is complete, IIS calls the module's [CGlobalModule::Terminate](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-terminate-method.md) method to remove the class from memory.  
  
<!-- TODO: review snippet reference  [!CODE [CGlobalModuleHelloWorld#1](CGlobalModuleHelloWorld#1)]  -->  
  
 Your module must export the `RegisterModule` function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Global-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-global-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Enumerations](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-enumerations.md)   
 [REQUEST_NOTIFICATION_STATUS Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-notification-status-enumeration.md)