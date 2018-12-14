---
title: "CGlobalModule::Terminate Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d9da74a3-e716-1785-e600-08337d75bfc5
caps.latest.revision: 14
author: "shirhatti"
manager: "wpickett"
---
# CGlobalModule::Terminate Method
Represents the method that IIS calls when a global module has completed processing.  
  
## Syntax  
  
```cpp  
virtual VOID Terminate(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 IIS calls the `Terminate` method for a [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) before a module is unloaded.  
  
> [!IMPORTANT]
>  Developers should use the `Terminate` method to remove implementations of `CGlobalModule` classes from memory.  
  
## Example  
 The following code example demonstrates how to create a simple "Hello World" global-level HTTP module. The module defines an exported [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function that creates an instance of a class that is derived from `CGlobalModule`. If the class cannot be created, the function exits with an error code; otherwise, the function calls the [IHttpModuleRegistrationInfo::SetRequestNotifications](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method to register for the [GL_PRE_BEGIN_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification.  
  
 When a `GL_PRE_BEGIN_REQUEST` notification occurs, IIS calls the module's [CGlobalModule::OnGlobalPreBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) method to process the notification. The method calls a private method to write an event to the application log of the Event Viewer, and then it returns [GL_NOTIFICATION_CONTINUE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/global-notification-status-enumeration.md) to notify IIS to continue processing other notifications. When processing is complete, IIS calls the module's `Terminate` method to remove the class from memory.  
  
<!-- TODO: review snippet reference  [!CODE [CGlobalModuleHelloWorld#1](CGlobalModuleHelloWorld#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Global-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-global-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CGlobalModule Class](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md)