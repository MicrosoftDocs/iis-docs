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
  
1.  Request all listener channels to stop (by calling the [WebhostCloseAllListenerChannelInstances](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/webhostclosealllistenerchannelinstances-function.md) function).  
  
2.  Wait for the Windows Process Activation Service notification from the [PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/a86ad76a-d123-3b43-c3a1-c43698b68b38.md) callback function. This callback confirms that all the listener channel instances have stopped.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  
 [Listener Adapter Exported Functions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/listener-adapter-exported-functions.md)