---
title: "IHealthStatusCallback Interface"
description: Learn how the IHealthStatusCallback interface allows a protocol manager, to which this interface is passed by the worker process framework, to report its current health status.  
ms.date: "10/07/2016"
ms.assetid: 88486f72-a4f1-90cd-5f66-3c60f8ab8fe3
---
# IHealthStatusCallback Interface
Allows a protocol manager, to which this interface is passed by the worker process framework, to report its current health status.  
  
## Syntax  
  
```cpp  
class IHealthStatusCallback : public IWpfReferencedObject  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHealthStatusCallback` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[AddRef](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-addref-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md).)|  
|[Release](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-release-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md).)|  
|[ReportHealth](../../web-development-reference/native-code-api-reference/ihealthstatuscallback-reporthealth-method.md)|Allows a protocol manager to report its current health status in response to a query from the [IPmHealthAndIdleMonitor::CheckHealth](../../web-development-reference/native-code-api-reference/ipmhealthandidlemonitor-checkhealth-method.md) method.|  
  
## Inheritance Hierarchy  
 [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md)  
  
 `IHealthStatusCallback`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [ICustomActionResultCallback Interface](../../web-development-reference/native-code-api-reference/icustomactionresultcallback-interface.md)   
 [IPmCustomActions Interface](../../web-development-reference/native-code-api-reference/ipmcustomactions-interface.md)   
 [IPmHealthAndIdleMonitor Interface](../../web-development-reference/native-code-api-reference/ipmhealthandidlemonitor-interface.md)   
 [IPmListenerChannelManager Interface](../../web-development-reference/native-code-api-reference/ipmlistenerchannelmanager-interface.md)   
 [IProtocolManager Interface](../../web-development-reference/native-code-api-reference/iprotocolmanager-interface.md)   
 [IWorkerProcessFramework Interface](../../web-development-reference/native-code-api-reference/iworkerprocessframework-interface.md)   
 [IWpfActions Interface](../../web-development-reference/native-code-api-reference/iwpfactions-interface.md)   
 [IWpfApplicationInfoUtil Interface](../../web-development-reference/native-code-api-reference/iwpfapplicationinfoutil-interface.md)   
 [IWpfExposeProtocolManagerCustomInterface Interface](../../web-development-reference/native-code-api-reference/iwpfexposeprotocolmanagercustominterface-interface.md)   
 [IWpfListenerChannelCallback Interface](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-interface.md)   
 [IWpfReferencedObject Interface](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md)   
 [IWpfSettings Interface](../../web-development-reference/native-code-api-reference/iwpfsettings-interface.md)   
 [Worker Process and Protocol Manager Interfaces](../../web-development-reference/native-code-api-reference/worker-process-and-protocol-manager-interfaces.md)   
 [Worker Process Framework API Reference](../../web-development-reference/native-code-api-reference/worker-process-framework-api-reference.md)
