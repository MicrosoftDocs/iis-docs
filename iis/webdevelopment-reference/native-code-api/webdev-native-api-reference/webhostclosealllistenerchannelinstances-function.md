---
title: "WebhostCloseAllListenerChannelInstances Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f8fbf5d5-83ce-0e07-15fd-cf40174ea7bd
caps.latest.revision: 15
author: "shirhatti"
manager: "wpickett"
---
# WebhostCloseAllListenerChannelInstances Function
Requests all instances of this listener channel to stop.  
  
## Syntax  
  
```cpp  
HRESULT WebhostCloseAllListenerChannelInstances(  
   IN DWORD ProtocolHandle,  
   IN LPCWSTR AppPoolId,  
   IN DWORD ListenerChannelId  
);  
```  
  
#### Parameters  
 `ProtocolHandle`  
 [IN] A `DWORD` that contains the protocol handle that represents the protocol for this listener channel.  
  
 `AppPoolId`  
 [IN] A string that contains the application pool ID for this listener channel.  
  
 `ListenerChannelId`  
 [IN] A `DWORD` that contains the listener channel ID that the listener adapter has requested to stop.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_INVALIDARG|Indicates that one of the parameters is not valid.|  
|HRESULT_FROM_WIN32( ERROR_NOT_FOUND)|Indicates that the protocol has not been registered.|  
|HRESULT_FROM_WIN32(ERROR_PIPE_NOT_CONNECTED)|Indicates that the listener adapter is not connected to the Windows Process Activation Service.|  
  
## Remarks  
 Calling this function with no listener channels running does not return an error code.  
  
 This function is called under the following conditions:  
  
-   The listener adapter service is stopping.  
  
-   The listener adapter is routing by application, and the application is being deleted.  
  
-   The application pool is being deleted.  
  
-   The listener adapter is routing by application, and the application is moving to another application pool.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  
 [Listener Adapter Exported Functions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/listener-adapter-exported-functions.md)   
 [PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED Function](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/a86ad76a-d123-3b43-c3a1-c43698b68b38.md)