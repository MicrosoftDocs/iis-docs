---
title: "IWpfSettings Interface"
ms.date: "10/07/2016"
ms.assetid: 424ab0ee-d35c-11d4-4300-85e7e2f3d259
---
# IWpfSettings Interface

Retrieves configuration settings that apply to application pools and worker processes.  
  
## Syntax  
  
```cpp  
class IWpfSettings : public IWpfReferencedObject  
```  
  
## Methods  

 The following table lists the methods exposed by the `IWpfSettings` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[AddRef](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-addref-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md).)|  
|[GetBoolProperty](../../web-development-reference/native-code-api-reference/iwpfsettings-getboolproperty-method.md)|Retrieves a `BOOL` value from the worker process or application pool settings.|  
|[GetDwordProperty](../../web-development-reference/native-code-api-reference/iwpfsettings-getdwordproperty-method.md)|Retrieves a `DWORD` value from the worker process or application pool settings.|  
|[GetHandleProperty](../../web-development-reference/native-code-api-reference/iwpfsettings-gethandleproperty-method.md)|Retrieves a `HANDLE` property from the worker process or application pool settings.|  
|[GetStringProperty](../../web-development-reference/native-code-api-reference/iwpfsettings-getstringproperty-method.md)|Retrieves a string value from the worker process or application pool settings.|  
|[GetUlonglongProperty](../../web-development-reference/native-code-api-reference/iwpfsettings-getulonglongproperty-method.md)|Retrieves a `ULONGLONG` value from the worker process or application pool settings.|  
|[Release](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-release-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md).)|  
  
## Remarks  

 Configuration settings retrieved by the `IWpfSettings` interface might be system defaults or could appear in the ApplicationHost.config file.  
  
## Inheritance Hierarchy  

 [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md)  
  
 `IWpfSettings`  
  
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
 [IWpfListenerChannelCallback Interface](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-interface.md)   
 [IWpfReferencedObject Interface](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md)   
 [Worker Process and Protocol Manager Interfaces](../../web-development-reference/native-code-api-reference/worker-process-and-protocol-manager-interfaces.md)   
 [Worker Process Framework API Reference](../../web-development-reference/native-code-api-reference/worker-process-framework-api-reference.md)
