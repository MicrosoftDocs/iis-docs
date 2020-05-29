---
title: "IWpfActions::RecycleWorkerProcess Method"
ms.date: "10/07/2016"
ms.assetid: 37d0d934-27e2-28e7-3220-ffa3103ee865
---
# IWpfActions::RecycleWorkerProcess Method
Enables a protocol manager to request a recycle of the worker process and to log an event to the Event Viewer.  
  
## Syntax  
  
```cpp  
virtual VOID RecycleWorkerProcess(  
   IN PCWSTR pszReason  
) = 0;  
```  
  
### Parameters  
 `pszReason`  
 A pointer to a string that contains the reason for the requested recycle that will be logged to the Event Viewer.  
  
## Return Value  
 `VOID`.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWpfActions Interface](../../web-development-reference/native-code-api-reference/iwpfactions-interface.md)   
 [IWpfActions::FailWorkerProcess Method](../../web-development-reference/native-code-api-reference/iwpfactions-failworkerprocess-method.md)
