---
title: "IWpfListenerChannelCallback Interface"
ms.date: "10/07/2016"
ms.assetid: 21c0150e-9250-3276-9220-7adca4453bc0
---
# IWpfListenerChannelCallback Interface
Provides notifications from protocol managers to the worker process framework regarding listener channel status changes.  
  
## Syntax  
  
```cpp  
class IWpfListenerChannelCallback : public IWpfReferencedObject  
```  
  
## Methods  
 The following table lists the methods exposed by the `IWpfListenerChannelCallback` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[AddRef](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-addref-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md).)|  
|[GetBlob](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-getblob-method.md)|Retrieves data that the protocol manager will pass to a listener channel when the protocol manager is starting a listener channel.|  
|[GetId](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-getid-method.md)|Retrieves the ID of a listener channel that needs to be started.|  
|[Release](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-release-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md).)|  
|[ReportMessageReceived](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportmessagereceived-method.md)|Notifies the worker process framework that a listener channel has received a message.|  
|[ReportStarted](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportstarted-method.md)|Notifies the worker process framework that a listener channel has started.|  
|[ReportStopped](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportstopped-method.md)|Notifies the worker process framework that a listener channel has shut down.|  
  
## Remarks  
 The `IWpfListenerChannelCallback` interface provides notifications to the worker process framework regarding listener channel status changes. For example, when a protocol manager starts a listener channel, one of the parameters passed to the [IPmListenerChannelManager::StartListenerChannel](../../web-development-reference/native-code-api-reference/ipmlistenerchannelmanager-startlistenerchannel-method.md) method is a pointer to an `IWpfListenerChannelCallback` interface. The protocol manager will use the [IWpfListenerChannelCallback::ReportStarted](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportstarted-method.md) method to report when the listener channel has started.  
  
## Inheritance Hierarchy  
 [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md)  
  
 `IWpfListenerChannelCallback`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [ICustomActionResultCallback Interface](../../web-development-reference/native-code-api-reference/icustomactionresultcallback-interface.md)   
 [IHealthStatusCallback Interface](../../web-development-reference/native-code-api-reference/ihealthstatuscallback-interface.md)   
 [IPmCustomActions Interface](../../web-development-reference/native-code-api-reference/ipmcustomactions-interface.md)   
 [IPmHealthAndIdleMonitor Interface](../../web-development-reference/native-code-api-reference/ipmhealthandidlemonitor-interface.md)   
 [IPmListenerChannelManager Interface](../../web-development-reference/native-code-api-reference/ipmlistenerchannelmanager-interface.md)   
 [IProtocolManager Interface](../../web-development-reference/native-code-api-reference/iprotocolmanager-interface.md)   
 [IWorkerProcessFramework Interface](../../web-development-reference/native-code-api-reference/iworkerprocessframework-interface.md)   
 [IWpfActions Interface](../../web-development-reference/native-code-api-reference/iwpfactions-interface.md)   
 [IWpfApplicationInfoUtil Interface](../../web-development-reference/native-code-api-reference/iwpfapplicationinfoutil-interface.md)   
 [IWpfExposeProtocolManagerCustomInterface Interface](../../web-development-reference/native-code-api-reference/iwpfexposeprotocolmanagercustominterface-interface.md)   
 [IWpfReferencedObject Interface](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md)   
 [IWpfSettings Interface](../../web-development-reference/native-code-api-reference/iwpfsettings-interface.md)   
 [Worker Process and Protocol Manager Interfaces](../../web-development-reference/native-code-api-reference/worker-process-and-protocol-manager-interfaces.md)   
 [Worker Process Framework API Reference](../../web-development-reference/native-code-api-reference/worker-process-framework-api-reference.md)
