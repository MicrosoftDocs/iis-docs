---
title: "IWpfActions::FailWorkerProcess Method"
ms.date: "10/07/2016"
ms.assetid: c1522380-9788-c51a-a614-3ba64de563f0
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
  
### Parameters  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWpfActions Interface](../../web-development-reference/native-code-api-reference/iwpfactions-interface.md)   
 [IWpfActions::RecycleWorkerProcess Method](../../web-development-reference/native-code-api-reference/iwpfactions-recycleworkerprocess-method.md)
