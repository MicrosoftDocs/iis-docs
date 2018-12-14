---
title: "CGlobalModule Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: fbe43040-c8ab-f991-c09c-49362d321c67
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# CGlobalModule Class
Defines the base class for global-level HTTP modules.  
  
## Syntax  
  
```cpp  
class CGlobalModule  
```  
  
## Methods  
 The following table lists the methods exposed by the `CGlobalModule` class.  
  
|Name|Description|  
|----------|-----------------|  
|[OnGlobalApplicationPreload](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalapplicationpreloadprovider-interface.md)|deddc775-1ab0-492c-bda0-b32be5d4f4cc|  
|[OnGlobalApplicationResolveModules](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalapplicationresolvemodules-method.md)|Represents the method that will handle a `GlobalApplicationResolveModules` event, which occurs when IIS resolves the registered modules.|  
|[OnGlobalApplicationStart](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalapplicationstart-method.md)|Represents the method that will handle a `GlobalApplicationStart` event, which occurs when IIS starts an application.|  
|[OnGlobalApplicationStop](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalapplicationstop-method.md)|Represents the method that will handle a `GlobalApplicationStop` event, which occurs when IIS shuts down an application.|  
|[OnGlobalCacheCleanup](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcachecleanup-method.md)|Represents the method that will handle a `GlobalCacheCleanup` event.|  
|[OnGlobalCacheOperation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcacheoperation-method.md)|Represents the method that will handle a `GlobalCacheOperation` event, which occurs when IIS performs a cache-related operation.|  
|[OnGlobalConfigurationChange](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalconfigurationchange-method.md)|Represents the method that will handle a `GlobalConfigurationChange` event, which occurs when a change is made to a configuration file.|  
|[OnGlobalCustomNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcustomnotification-method.md)|Represents the method that will handle a `GlobalCustomNotification` event, which occurs when a module raises a user-defined notification.|  
|[OnGlobalFileChange](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalfilechange-method.md)|Represents the method that will handle a `GlobalFileChange` event, which occurs when a file within a Web site is changed.|  
|[OnGlobalHealthCheck](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalhealthcheck-method.md)|Represents the method that will handle a `GlobalHealthCheck` event, which occurs when a health-related operation is executed.|  
|[OnGlobalPreBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalprebeginrequest-method.md)|Represents the method that will handle a `GlobalPreBeginRequest` event, which occurs before a request enters the pipeline.|  
|[OnGlobalRSCAQuery](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalrscaquery-method.md)|Represents the method that will handle a `GlobalRSCAQuery` event, which occurs when a Run-Time Status and Control query is executed.|  
|[OnGlobalStopListening](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalstoplistening-method.md)|Represents the method that will handle a `GlobalStopListening` event, which occurs when IIS stops accepting new requests.|  
|[OnGlobalThreadCleanup](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalthreadcleanup-method.md)|Represents the method that will handle a `GlobalThreadCleanup` event, which occurs when IIS returns a thread to the thread pool.|  
|[OnGlobalTraceEvent](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobaltraceevent-method.md)|Represents the method that will handle a `GlobalTraceEvent` event, which occurs when a trace event is raised.|  
|[Terminate](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-terminate-method.md)|Represents the method that IIS calls when a global module has completed processing.|  
  
## Derived Classes  
 This class contains no derived classes.  
  
## Remarks  
 The `CGlobalModule` class is the base class for global-level HTTP modules. Global-level HTTP modules must contain a class that inherits from `CGlobalModule`. `CGlobalModule` defines the methods that [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] calls to handle global-level notifications when global-level events occur. An HTTP module can register for specific events by defining a list of notifications in a module's exported [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. When a global-level module has finished processing, the module should use the [CGlobalModule::Terminate](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-terminate-method.md) method to remove `CGlobalModule` instances from memory.  
  
## Example  
 The following code example demonstrates how to create a simple "Hello World" global-level HTTP module. The module defines an exported [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function that creates an instance of a class that is derived from `CGlobalModule`. If the class cannot be created, the function exits with an error code; otherwise, the function calls the [IHttpModuleRegistrationInfo::SetRequestNotifications](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method to register for the [GL_PRE_BEGIN_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification.  
  
 When a `GL_PRE_BEGIN_REQUEST` notification occurs, IIS calls the module's [CGlobalModule::OnGlobalPreBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) method to process the notification. The method calls a private method to write an event to the application log of the Event Viewer, and then it returns [GL_NOTIFICATION_CONTINUE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) to notify IIS to continue processing other notifications. When processing is complete, IIS calls the module's [CGlobalModule::Terminate](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-terminate-method.md) method to remove the class from memory.  
  
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
 [Web Server Core Classes](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-classes.md)   
 [Creating Native-Code HTTP Modules](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/creating-native-code-http-modules.md)   
 [CHttpModule Class](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md)