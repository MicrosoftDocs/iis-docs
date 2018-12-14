---
title: "Worker Process and Protocol Manager Interfaces | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 84cdeec4-70f9-44f3-84f9-3b690af1d340
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# Worker Process and Protocol Manager Interfaces
This section describes the interfaces and methods available in the worker process framework that allow protocol managers to retrieve configuration information about a worker process. These interfaces also allow worker processes to retrieve listener-related health and Run-Time Status and Control information from a protocol manager. The interfaces and their respective methods are defined in the Wpframework.h header file.  
  
## In This Section  
 The IIS worker process framework exposes the following interfaces.  
  
|Interface|Description|  
|---------------|-----------------|  
|[ICustomActionResultCallback](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icustomactionresultcallback-interface.md)|Reports the results of a Run-Time Status and Control operation that was requested by the [IPmCustomActions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmcustomactions-interface.md) interface.|  
|[ICustomAction2ResultCallback](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icustomaction2resultcallback-interface.md)|Reports the results of a `RegisterCustomAction` or `UnregisterCustomAction` operation that was requested by the [IPmCustomActions2](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmcustomactions2-interface.md) interface.|  
|[IHealthStatusCallback](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihealthstatuscallback-interface.md)|Allows a protocol manager, to which this interface is passed by the worker process framework, to report its current health status.|  
|[IPmApplicationPreload](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmapplicationpreload-interface.md)|Enables the worker process to preload applications into server memory.|  
|[IPmCustomActions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmcustomactions-interface.md)|Allows the worker process framework to request custom Run-Time Status and Control operations from a protocol manager.|  
|[IPmCustomActions2](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmcustomactions2-interface.md)|Enables the worker process to register and unregister custom actions that will result in multiple responses.|  
|[IPmHealthAndIdleMonitor](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmhealthandidlemonitor-interface.md)|Enables the worker process framework to check whether a protocol manager is healthy, or whether the listener channels for the protocol manager are idle.|  
|[IPmListenerChannelManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmlistenerchannelmanager-interface.md)|Enables the worker process framework to request that a protocol manager start or stop a listener channel.|  
|[IProtocolManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprotocolmanager-interface.md)|Defines the base interface for protocol managers, and exposes methods for the worker process framework to interact with protocol managers.|  
|[IWorkerProcessFramework](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iworkerprocessframework-interface.md)|Defines the base interface for the worker process framework, and exposes methods for a protocol manager to interact with the worker process framework and other protocol managers.|  
|[IWpfActions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfactions-interface.md)|Allows a protocol manager to request that the worker process framework request a recycle or an immediate shutdown of the host process from the process manager.|  
|[IWpfApplicationInfoUtil](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfapplicationinfoutil-interface.md)|Exposes a method that retrieves the virtual path and site ID for an application.|  
|[IWpfApplicationProloadUtil](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfapplicationpreloadutil-interface.md)|Exposes helper functions that return preload information (such as site ID) for an application and report preload failures.|  
|[IWpfExposeProtocolManagerCustomInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfexposeprotocolmanagercustominterface-interface.md)|Enables a protocol manager to share information with another protocol manager.|  
|[IWpfListenerChannelCallback](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpflistenerchannelcallback-interface.md)|Provides notifications from protocol managers to the worker process framework regarding listener channel status changes.|  
|[IWpfReferencedObject](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfreferencedobject-interface.md)|Defines the base class for the worker process framework.|  
|[IWpfSettings](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-interface.md)|Retrieves configuration settings that apply to application pools and worker processes.|  
  
## See Also  
 [Worker Process Framework API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/worker-process-framework-api-reference.md)