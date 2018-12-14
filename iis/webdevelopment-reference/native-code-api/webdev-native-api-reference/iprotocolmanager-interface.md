---
title: "IProtocolManager Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ef6cac9a-055e-0b8b-7f7a-6548a6e6543b
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IProtocolManager Interface
Defines the base interface for protocol managers, and exposes methods for the worker process framework to interact with protocol managers.  
  
## Syntax  
  
```cpp  
class IProtocolManager : public IWpfReferencedObject  
```  
  
## Methods  
 The following table lists the methods exposed by the `IProtocolManager` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[AddRef](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfreferencedobject-addref-method.md)|(Inherited from [IWpfReferencedObject](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfreferencedobject-interface.md).)|  
|[GetCustomInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprotocolmanager-getcustominterface-method.md)|Retrieves a custom interface from a protocol manager.|  
|[GetPmInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprotocolmanager-getpminterface-method.md)|Retrieves a defined interface from a protocol manager.|  
|[Release](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfreferencedobject-release-method.md)|(Inherited from [IWpfReferencedObject](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfreferencedobject-interface.md).)|  
|[Shutdown](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprotocolmanager-shutdown-method.md)|Shuts down a protocol manager.|  
  
## Inheritance Hierarchy  
 [IWpfReferencedObject](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfreferencedobject-interface.md)  
  
 `IProtocolManager`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [ICustomActionResultCallback Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icustomactionresultcallback-interface.md)   
 [IHealthStatusCallback Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihealthstatuscallback-interface.md)   
 [IPmCustomActions Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmcustomactions-interface.md)   
 [IPmHealthAndIdleMonitor Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmhealthandidlemonitor-interface.md)   
 [IPmListenerChannelManager Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmlistenerchannelmanager-interface.md)   
 [IWorkerProcessFramework Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iworkerprocessframework-interface.md)   
 [IWpfActions Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfactions-interface.md)   
 [IWpfApplicationInfoUtil Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfapplicationinfoutil-interface.md)   
 [IWpfExposeProtocolManagerCustomInterface Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfexposeprotocolmanagercustominterface-interface.md)   
 [IWpfListenerChannelCallback Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpflistenerchannelcallback-interface.md)   
 [IWpfReferencedObject Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfreferencedobject-interface.md)   
 [IWpfSettings Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-interface.md)   
 [Worker Process and Protocol Manager Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/worker-process-and-protocol-manager-interfaces.md)   
 [Worker Process Framework API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/worker-process-framework-api-reference.md)