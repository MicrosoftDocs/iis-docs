---
title: "ICustomActionResultCallback Interface"
ms.date: "10/07/2016"
description: ICustomActionResultCallback Interface reports the results of a Run-Time Status and Control operation that was requested by the IPmCustomActions interface.
ms.assetid: 66ef5a0c-0172-ae7f-5685-4cc987a8b917
---
# ICustomActionResultCallback Interface
Reports the results of a Run-Time Status and Control operation that was requested by the [IPmCustomActions](../../web-development-reference/native-code-api-reference/ipmcustomactions-interface.md) interface.  
  
## Syntax  
  
```cpp  
class ICustomActionResultCallback : public IWpfReferencedObject  
```  
  
## Methods  
 The following table lists the methods exposed by the `ICustomActionResultCallback` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[AddRef](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-addref-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md).)|  
|[Release](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-release-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md).)|  
|[ReportResult](../../web-development-reference/native-code-api-reference/icustomactionresultcallback-reportresult-method.md)|Returns the results of a Run-Time Status and Control operation that was requested by the [IPmCustomActions::RunCustomAction](../../web-development-reference/native-code-api-reference/ipmcustomactions-runcustomaction-method.md) method.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[ICustomAction2ResultCallback](../../web-development-reference/native-code-api-reference/icustomaction2resultcallback-interface.md)|Reports the results of a `RegisterCustomAction` or `UnregisterCustomAction` operation that was requested by the [IPmCustomActions2](../../web-development-reference/native-code-api-reference/ipmcustomactions2-interface.md) interface.|  
  
## Inheritance Hierarchy  
 [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md)  
  
 `ICustomActionResultCallback`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Interfaces](../../web-development-reference/native-code-api-reference/worker-process-and-protocol-manager-interfaces.md)   
 [IHealthStatusCallback Interface](../../web-development-reference/native-code-api-reference/ihealthstatuscallback-interface.md)   
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
 [Worker Process Framework API Reference](../../web-development-reference/native-code-api-reference/worker-process-framework-api-reference.md)
