---
title: "PFN_WEB_CORE_SHUTDOWN Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: da54f34a-f01e-4242-9902-824e276e23d8
caps.latest.revision: 29
author: "shirhatti"
manager: "wpickett"
---
# PFN_WEB_CORE_SHUTDOWN Function
Shuts down an instance of the Hosted Web Core.  
  
## Syntax  
  
```cpp  
typedef HRESULT (*PFN_WEB_CORE_SHUTDOWN)(  
   IN DWORD fImmediate  
);  
```  
  
#### Parameters  
 `fImmediate`  
 A `DWORD` that specifies whether the shutdown should be immediate or graceful.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_SERVICE_NOT_ACTIVE|Indicates that the Hosted Web Core is not running.|  
|ERROR_INVALID_SERVICE_CONTROL|Indicates that a shutdown is already in progress.|  
|ERROR_SERVICE_REQUEST_TIMEOUT|Indicates that a graceful shutdown was requested but was not able to complete in the time period specified by the `ShutdownTimeLimit` setting in the configuration file.|  
  
## Remarks  
 The `PFN_WEB_CORE_SHUTDOWN` function is a prototype for the `WebCoreShutdown` DLL entry point in Hwebcore.dll that is used to shut down the Hosted Web Core. The hosting process may choose to shut down the Hosted Web Core either gracefully or immediately. If the hosting process chooses a graceful shutdown, the Hosted Web Core will stop receiving new requests and wait for any currently executing requests to finish based on the time period specified by the `ShutdownTimeLimit` setting in the configuration file for the application pool.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Hwebcore.h|  
  
## See Also  
 [Hosted Web Core API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/hosted-web-core-api-reference.md)   
 [PFN_WEB_CORE_ACTIVATE Function](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-web-core-activate-function.md)