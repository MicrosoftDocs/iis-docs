---
title: "IWpfActions::FailWorkerProcess Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c1522380-9788-c51a-a614-3ba64de563f0
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# IWpfActions::FailWorkerProcess Method
Enables a protocol manager to request a shutdown of the worker process and to log an event to the Event Viewer.  
  
## Syntax  
  
```cpp  
virtual VOID FailWorkerProcess(  
   IN PCWSTR pszReason,  
   IN HRESULT hrFailureToReport,  
   IN BOOL fFailOnNextPing = FALSE  
) = 0;  
```  
  
#### Parameters  
 `pszReason`  
 A pointer to a string that contains the cause of the failure to be logged to the Event Viewer.  
  
 `hrFailureToReport`  
 An `HRESULT` that contains the failure code to report.  
  
 `fFailOnNextPing`  
 `true` to indicate that the worker process should shut down immediately; `false` to indicate that the worker process should shut down on the next health check.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `FailWorkerProcess` method enables protocol managers to request that the worker process framework report an unhealthy status to the Windows Process Activation Service.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWpfActions Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfactions-interface.md)   
 [IWpfActions::RecycleWorkerProcess Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfactions-recycleworkerprocess-method.md)