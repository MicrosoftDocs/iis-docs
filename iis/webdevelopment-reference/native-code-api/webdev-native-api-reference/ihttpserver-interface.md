---
title: "IHttpServer Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6a25d9f5-f358-932f-8cc9-8edd6928761b
caps.latest.revision: 28
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer Interface
Represents the processing context for global-level operations.  
  
## Syntax  
  
```cpp  
class IHttpServer  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpServer` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[AddFragmentToCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-addfragmenttocache-method.md)|Adds an [HTTP_DATA_CHUNK](http://go.microsoft.com/fwlink/?LinkId=56011) structure to the cache.|  
|[AssociateWithThreadPool](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-associatewiththreadpool-method.md)|Associates an asynchronous completion operation with the thread pool.|  
|[DecrementThreadCount](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-decrementthreadcount-method.md)|Decrements the thread count for the thread pool.|  
|[DispenseContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-dispensecontainer-method.md)|Returns a context container that may be dispensed.|  
|[DoCacheOperation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-docacheoperation-method.md)|Performs a specific cache operation.|  
|[FlushKernelCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-flushkernelcache-method.md)|Flushes the kernel cache for a specific Uniform Resource Identifier (URI).|  
|[GetAppPoolName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-getapppoolname-method.md)|Retrieves the name of the application pool for the current request.|  
|[GetConfigObject](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-getconfigobject-method.md)|Retrieves the configuration object for the current context.|  
|[GetFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-getfileinfo-method.md)|Returns an [IHttpFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md) interface for a specific file path.|  
|[GetManagedType](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-getmanagedtype-method.md)|Retrieves the managed type for a specific site and Uniform Resource Identifier (URI).|  
|[GetPerfCounterInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-getperfcounterinfo-method.md)|Retrieves an [IHttpPerfCounterInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpperfcounterinfo-interface.md) interface.|  
|[GetProtocolManagerCustomInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-getprotocolmanagercustominterface-method.md)|Retrieves a custom interface for a protocol manager.|  
|[GetTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-gettracecontext-method.md)|Retrieves an [IHttpTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-interface.md) interface.|  
|[GetWorkerProcessSettings](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-getworkerprocesssettings-method.md)|Retrieves an [IWpfSettings](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-interface.md) interface.|  
|[IncrementThreadCount](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-incrementthreadcount-method.md)|Increments the thread count for the thread pool.|  
|[IsCommandLineLaunch](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-iscommandlinelaunch-method.md)|Tests whether the worker process was launched from the command line.|  
|[NotifyConfigurationChange](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-notifyconfigurationchange-method.md)|Triggers a notification that a configuration path has changed.|  
|[NotifyCustomNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-notifycustomnotification-method.md)|Raises a custom global-level notification.|  
|[NotifyFileChange](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-notifyfilechange-method.md)|Triggers a notification that a file has changed.|  
|[ReadFragmentFromCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-readfragmentfromcache-method.md)|Retrieves a specific fragment from the cache.|  
|[RecycleApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-recycleapplication-method.md)|Recycles an application.|  
|[RecycleProcess](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-recycleprocess-method.md)|Recycles the worker process that is handling the current request.|  
|[RegisterFileChangeMonitor](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-registerfilechangemonitor-method.md)|Registers file-change notification for a particular directory.|  
|[RemoveFragmentFromCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-removefragmentfromcache-method.md)|Removes a specific fragment from the cache.|  
|[ReportUnhealthy](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-reportunhealthy-method.md)|Reports the worker process as unhealthy.|  
|[SatisfiesPrecondition](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-satisfiesprecondition-method.md)|Determines whether a specific precondition has been met for the current request.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpServer2](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver2-interface.md)|Represents the processing context for global-level operations, and enables retrieving configuration files, extended interfaces, metadata, tokens, and the worker process framework.|  
  
## Remarks  
 The `IHttpServer` interface represents the main programmatic interface for HTTP modules to access information about the current global-level context. This interface retrieves several additional interfaces that you can use when you write HTTP modules. For example, the `GetFileInfo` and `GetPerfCounterInfo` methods retrieve, respectively, the `IHttpFileInfo` and `IHttpPerfCounterInfo` interfaces for the global context. These interfaces allow developers to retrieve a file interface for a specific file, or an interface for the performance counters.  
  
 [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] allows developers to restart an application, restart a worker process, or report the current context as unhealthy. This functionality is exposed, respectively, through the `RecycleApplication`, `RecycleProcess`, and `ReportUnhealthy` methods.  
  
 The `IHttpServer` interface provides several methods that allow developers to manipulate the IIS cache. These methods are the `AddFragmentToCache`, `DoCacheOperation`, `FlushKernelCache`, `ReadFragmentFromCache`, and `RemoveFragmentFromCache` methods.  
  
> [!NOTE]
>  Http.sys manages and owns the fragment cache. At any time, Http.sys may override or delete information that you directed to be stored. There is currently no way to lock information in the fragment cache as nonvolatile information.  
  
 Developers can use the `GetAppPoolName`, `GetManagedType`, `GetWorkerProcessSettings`, and `SatisfiesPrecondition` methods to retrieve information from the configuration settings for the current context.  
  
 The `IHttpServer` interface also provides the `NotifyConfigurationChange`, `NotifyFileChange`, `NotifyCustomNotification` methods, which allow developers to raise notifications for configuration changes, file changes, or a custom notification condition, respectively.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)