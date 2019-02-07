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
|[AddFragmentToCache](../../web-development-reference\native-code-api-reference/ihttpserver-addfragmenttocache-method.md)|Adds an [HTTP_DATA_CHUNK](http://go.microsoft.com/fwlink/?LinkId=56011) structure to the cache.|  
|[AssociateWithThreadPool](../../web-development-reference\native-code-api-reference/ihttpserver-associatewiththreadpool-method.md)|Associates an asynchronous completion operation with the thread pool.|  
|[DecrementThreadCount](../../web-development-reference\native-code-api-reference/ihttpserver-decrementthreadcount-method.md)|Decrements the thread count for the thread pool.|  
|[DispenseContainer](../../web-development-reference\native-code-api-reference/ihttpserver-dispensecontainer-method.md)|Returns a context container that may be dispensed.|  
|[DoCacheOperation](../../web-development-reference\native-code-api-reference/ihttpserver-docacheoperation-method.md)|Performs a specific cache operation.|  
|[FlushKernelCache](../../web-development-reference\native-code-api-reference/ihttpserver-flushkernelcache-method.md)|Flushes the kernel cache for a specific Uniform Resource Identifier (URI).|  
|[GetAppPoolName](../../web-development-reference\native-code-api-reference/ihttpserver-getapppoolname-method.md)|Retrieves the name of the application pool for the current request.|  
|[GetConfigObject](../../web-development-reference\native-code-api-reference/ihttpserver-getconfigobject-method.md)|Retrieves the configuration object for the current context.|  
|[GetFileInfo](../../web-development-reference\native-code-api-reference/ihttpserver-getfileinfo-method.md)|Returns an [IHttpFileInfo](../../web-development-reference\native-code-api-reference/ihttpfileinfo-interface.md) interface for a specific file path.|  
|[GetManagedType](../../web-development-reference\native-code-api-reference/ihttpserver-getmanagedtype-method.md)|Retrieves the managed type for a specific site and Uniform Resource Identifier (URI).|  
|[GetPerfCounterInfo](../../web-development-reference\native-code-api-reference/ihttpserver-getperfcounterinfo-method.md)|Retrieves an [IHttpPerfCounterInfo](../../web-development-reference\native-code-api-reference/ihttpperfcounterinfo-interface.md) interface.|  
|[GetProtocolManagerCustomInterface](../../web-development-reference\native-code-api-reference/ihttpserver-getprotocolmanagercustominterface-method.md)|Retrieves a custom interface for a protocol manager.|  
|[GetTraceContext](../../web-development-reference\native-code-api-reference/ihttpserver-gettracecontext-method.md)|Retrieves an [IHttpTraceContext](../../web-development-reference\native-code-api-reference/ihttptracecontext-interface.md) interface.|  
|[GetWorkerProcessSettings](../../web-development-reference\native-code-api-reference/ihttpserver-getworkerprocesssettings-method.md)|Retrieves an [IWpfSettings](../../web-development-reference\native-code-api-reference/iwpfsettings-interface.md) interface.|  
|[IncrementThreadCount](../../web-development-reference\native-code-api-reference/ihttpserver-incrementthreadcount-method.md)|Increments the thread count for the thread pool.|  
|[IsCommandLineLaunch](../../web-development-reference\native-code-api-reference/ihttpserver-iscommandlinelaunch-method.md)|Tests whether the worker process was launched from the command line.|  
|[NotifyConfigurationChange](../../web-development-reference\native-code-api-reference/ihttpserver-notifyconfigurationchange-method.md)|Triggers a notification that a configuration path has changed.|  
|[NotifyCustomNotification](../../web-development-reference\native-code-api-reference/ihttpserver-notifycustomnotification-method.md)|Raises a custom global-level notification.|  
|[NotifyFileChange](../../web-development-reference\native-code-api-reference/ihttpserver-notifyfilechange-method.md)|Triggers a notification that a file has changed.|  
|[ReadFragmentFromCache](../../web-development-reference\native-code-api-reference/ihttpserver-readfragmentfromcache-method.md)|Retrieves a specific fragment from the cache.|  
|[RecycleApplication](../../web-development-reference\native-code-api-reference/ihttpserver-recycleapplication-method.md)|Recycles an application.|  
|[RecycleProcess](../../web-development-reference\native-code-api-reference/ihttpserver-recycleprocess-method.md)|Recycles the worker process that is handling the current request.|  
|[RegisterFileChangeMonitor](../../web-development-reference\native-code-api-reference/ihttpserver-registerfilechangemonitor-method.md)|Registers file-change notification for a particular directory.|  
|[RemoveFragmentFromCache](../../web-development-reference\native-code-api-reference/ihttpserver-removefragmentfromcache-method.md)|Removes a specific fragment from the cache.|  
|[ReportUnhealthy](../../web-development-reference\native-code-api-reference/ihttpserver-reportunhealthy-method.md)|Reports the worker process as unhealthy.|  
|[SatisfiesPrecondition](../../web-development-reference\native-code-api-reference/ihttpserver-satisfiesprecondition-method.md)|Determines whether a specific precondition has been met for the current request.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpServer2](../../web-development-reference\native-code-api-reference/ihttpserver2-interface.md)|Represents the processing context for global-level operations, and enables retrieving configuration files, extended interfaces, metadata, tokens, and the worker process framework.|  
  
## Remarks  
 The `IHttpServer` interface represents the main programmatic interface for HTTP modules to access information about the current global-level context. This interface retrieves several additional interfaces that you can use when you write HTTP modules. For example, the `GetFileInfo` and `GetPerfCounterInfo` methods retrieve, respectively, the `IHttpFileInfo` and `IHttpPerfCounterInfo` interfaces for the global context. These interfaces allow developers to retrieve a file interface for a specific file, or an interface for the performance counters.  
  
 [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] allows developers to restart an application, restart a worker process, or report the current context as unhealthy. This functionality is exposed, respectively, through the `RecycleApplication`, `RecycleProcess`, and `ReportUnhealthy` methods.  
  
 The `IHttpServer` interface provides several methods that allow developers to manipulate the IIS cache. These methods are the `AddFragmentToCache`, `DoCacheOperation`, `FlushKernelCache`, `ReadFragmentFromCache`, and `RemoveFragmentFromCache` methods.  
  
> [!NOTE]
>  Http.sys manages and owns the fragment cache. At any time, Http.sys may override or delete information that you directed to be stored. There is currently no way to lock information in the fragment cache as nonvolatile information.  
  
 Developers can use the `GetAppPoolName`, `GetManagedType`, `GetWorkerProcessSettings`, and `SatisfiesPrecondition` methods to retrieve information from the configuration settings for the current context.  
  
 The `IHttpServer` interface also provides the `NotifyConfigurationChange`, `NotifyFileChange`, `NotifyCustomNotification` methods, which allow developers to raise notifications for configuration changes, file changes, or a custom notification condition, respectively.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)