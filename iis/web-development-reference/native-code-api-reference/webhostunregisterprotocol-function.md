---
title: "WebhostUnregisterProtocol Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: cbc9a189-8d5a-7611-71e3-083e7e5b08b2
caps.latest.revision: 15
author: "shirhatti"
manager: "wpickett"
---
# WebhostUnregisterProtocol Function
Requests that a protocol be unregistered when a listener adapter is shutting down.  
  
## Syntax  
  
```cpp  
HRESULT WebhostUnregisterProtocol(  
   IN DWORD ProtocolHandle  
);  
```  
  
#### Parameters  
 `ProtocolHandle`  
 [IN] A `DWORD` that represents the protocol to be unregistered.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
|HRESULT_FROM_WIN32( ERROR_ALREADY_EXISTS )|Indicates that there is already a listener adapter registered in this process for this protocol.|  
|HRESULT_FROM_WIN32( ERROR_NOT_FOUND )|Indicates that the protocol was not found.|  
  
## Remarks  
 Before calling this function, the listener adaptor should perform the following tasks:  
  
1.  Request all listener channels to stop (by calling the [WebhostCloseAllListenerChannelInstances](../../web-development-reference\webdev-native-api-reference/webhostclosealllistenerchannelinstances-function.md) function).  
  
2.  Wait for the Windows Process Activation Service notification from the [PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED](../../web-development-reference\webdev-native-api-reference/pfn-webhost-listener-application-pool-all-listener-channel-instances-stopped-function.md) callback function. This callback confirms that all the listener channel instances have stopped.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  
 [Listener Adapter Exported Functions](../../web-development-reference\webdev-native-api-reference/listener-adapter-exported-functions.md)