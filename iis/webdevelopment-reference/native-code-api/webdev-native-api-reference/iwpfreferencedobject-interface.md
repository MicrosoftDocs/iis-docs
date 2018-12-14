---
title: "IWpfReferencedObject Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4db5d58d-a83c-3f28-deb7-bb9b88b0baaa
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
---
# IWpfReferencedObject Interface
Defines the base class for the worker process framework.  
  
## Syntax  
  
```cpp  
class IWpfReferencedObject  
```  
  
## Methods  
 The following table lists the methods exposed by the `IWpfReferencedObject` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[AddRef](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfreferencedobject-addref-method.md)|Increments the reference count for the `IWpfReferencedObject` interface.|  
|[Release](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfreferencedobject-release-method.md)|Decrements the reference count for the `IWpfReferencedObject` interface.|  
  
## Remarks  
 All interfaces in the worker process framework are inherited from the `IWpfReferencedObject` interface. In addition, `IWpfReferencedObject` exposes the reference counting methods for the worker process framework.  
  
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
 [IProtocolManager Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprotocolmanager-interface.md)   
 [IWorkerProcessFramework Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iworkerprocessframework-interface.md)   
 [IWpfActions Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfactions-interface.md)   
 [IWpfApplicationInfoUtil Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfapplicationinfoutil-interface.md)   
 [IWpfExposeProtocolManagerCustomInterface Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfexposeprotocolmanagercustominterface-interface.md)   
 [IWpfListenerChannelCallback Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpflistenerchannelcallback-interface.md)   
 [IWpfSettings Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-interface.md)   
 [Worker Process and Protocol Manager Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/worker-process-and-protocol-manager-interfaces.md)   
 [Worker Process Framework API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/worker-process-framework-api-reference.md)