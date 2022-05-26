---
title: "IPmListenerChannelManager::StartListenerChannel Method"
description: Learn how the StartListenerChannel method enables the worker process framework to request that a protocol manager start a listener channel for a protocol.
ms.date: "10/07/2016"
ms.assetid: 87b8c556-3894-a8f9-2968-7750b1ba6cb2
---
# IPmListenerChannelManager::StartListenerChannel Method
Enables the worker process framework to request that a protocol manager start a listener channel for a protocol.  
  
## Syntax  
  
```cpp  
virtual HRESULT StartListenerChannel(  
   IN PCWSTR protocolId,  
   IN IWpfListenerChannelCallback* pListenerChannelCallback  
) = 0;  
```  
  
### Parameters  
 `protocolId`  
 A pointer to a string that contains the protocol (for example, HTTP) to start.  
  
 `pListenerChannelCallback`  
 A pointer to a callback function that is used to communicate to the worker process framework that a listener channel has been started.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|The operation was successful.|  
|ERROR_FILE_NOT_FOUND|Indicates that the protocol specified by `protocolId` is not valid.|  
|ERROR_INVALID_PARAMETER|Indicates that the callback function specified by `pListenerChannelCallback` is not valid.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IPmListenerChannelManager Interface](../../web-development-reference/native-code-api-reference/ipmlistenerchannelmanager-interface.md)   
 [IPmListenerChannelManager::StopListenerChannel Method](../../web-development-reference/native-code-api-reference/ipmlistenerchannelmanager-stoplistenerchannel-method.md)
