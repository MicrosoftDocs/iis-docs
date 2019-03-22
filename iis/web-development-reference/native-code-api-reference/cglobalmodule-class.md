---
title: "CGlobalModule Class"
ms.date: "10/07/2016"
ms.assetid: fbe43040-c8ab-f991-c09c-49362d321c67
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
|[OnGlobalApplicationPreload](../../web-development-reference/native-code-api-reference/iglobalapplicationpreloadprovider-interface.md)|deddc775-1ab0-492c-bda0-b32be5d4f4cc|  
|[OnGlobalApplicationResolveModules](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalapplicationresolvemodules-method.md)|Represents the method that will handle a `GlobalApplicationResolveModules` event, which occurs when IIS resolves the registered modules.|  
|[OnGlobalApplicationStart](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalapplicationstart-method.md)|Represents the method that will handle a `GlobalApplicationStart` event, which occurs when IIS starts an application.|  
|[OnGlobalApplicationStop](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalapplicationstop-method.md)|Represents the method that will handle a `GlobalApplicationStop` event, which occurs when IIS shuts down an application.|  
|[OnGlobalCacheCleanup](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcachecleanup-method.md)|Represents the method that will handle a `GlobalCacheCleanup` event.|  
|[OnGlobalCacheOperation](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)|Represents the method that will handle a `GlobalCacheOperation` event, which occurs when IIS performs a cache-related operation.|  
|[OnGlobalConfigurationChange](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalconfigurationchange-method.md)|Represents the method that will handle a `GlobalConfigurationChange` event, which occurs when a change is made to a configuration file.|  
|[OnGlobalCustomNotification](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcustomnotification-method.md)|Represents the method that will handle a `GlobalCustomNotification` event, which occurs when a module raises a user-defined notification.|  
|[OnGlobalFileChange](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalfilechange-method.md)|Represents the method that will handle a `GlobalFileChange` event, which occurs when a file within a Web site is changed.|  
|[OnGlobalHealthCheck](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalhealthcheck-method.md)|Represents the method that will handle a `GlobalHealthCheck` event, which occurs when a health-related operation is executed.|  
|[OnGlobalPreBeginRequest](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalprebeginrequest-method.md)|Represents the method that will handle a `GlobalPreBeginRequest` event, which occurs before a request enters the pipeline.|  
|[OnGlobalRSCAQuery](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalrscaquery-method.md)|Represents the method that will handle a `GlobalRSCAQuery` event, which occurs when a Run-Time Status and Control query is executed.|  
|[OnGlobalStopListening](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalstoplistening-method.md)|Represents the method that will handle a `GlobalStopListening` event, which occurs when IIS stops accepting new requests.|  
|[OnGlobalThreadCleanup](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalthreadcleanup-method.md)|Represents the method that will handle a `GlobalThreadCleanup` event, which occurs when IIS returns a thread to the thread pool.|  
|[OnGlobalTraceEvent](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobaltraceevent-method.md)|Represents the method that will handle a `GlobalTraceEvent` event, which occurs when a trace event is raised.|  
|[Terminate](../../web-development-reference/native-code-api-reference/cglobalmodule-terminate-method.md)|Represents the method that IIS calls when a global module has completed processing.|  
  
## Derived Classes  
 This class contains no derived classes.  
  
## Remarks  
 The `CGlobalModule` class is the base class for global-level HTTP modules. Global-level HTTP modules must contain a class that inherits from `CGlobalModule`. `CGlobalModule` defines the methods that [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] calls to handle global-level notifications when global-level events occur. An HTTP module can register for specific events by defining a list of notifications in a module's exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. When a global-level module has finished processing, the module should use the [CGlobalModule::Terminate](../../web-development-reference/native-code-api-reference/cglobalmodule-terminate-method.md) method to remove `CGlobalModule` instances from memory.  
  
## Example  
 The following code example demonstrates how to create a simple "Hello World" global-level HTTP module. The module defines an exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function that creates an instance of a class that is derived from `CGlobalModule`. If the class cannot be created, the function exits with an error code; otherwise, the function calls the [IHttpModuleRegistrationInfo::SetRequestNotifications](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method to register for the [GL_PRE_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification.  
  
 When a `GL_PRE_BEGIN_REQUEST` notification occurs, IIS calls the module's [CGlobalModule::OnGlobalPreBeginRequest](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) method to process the notification. The method calls a private method to write an event to the application log of the Event Viewer, and then it returns [GL_NOTIFICATION_CONTINUE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) to notify IIS to continue processing other notifications. When processing is complete, IIS calls the module's [CGlobalModule::Terminate](../../web-development-reference/native-code-api-reference/cglobalmodule-terminate-method.md) method to remove the class from memory.  
  
<!-- TODO: review snippet reference  [!CODE [CGlobalModuleHelloWorld#1](CGlobalModuleHelloWorld#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Global-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-global-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Classes](../../web-development-reference/native-code-api-reference/web-server-core-classes.md)   
 [Creating Native-Code HTTP Modules](../../web-development-reference/native-code-development-overview/creating-native-code-http-modules.md)   
 [CHttpModule Class](../../web-development-reference/native-code-api-reference/chttpmodule-class.md)