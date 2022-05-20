---
title: IPmHealthAndIdleMonitor::CheckIdle Method
ms.date: 10/07/2016
description: Enables the worker process framework to request whether all the listener channels for a protocol manager are idle.
ms.assetid: cc25da61-1020-c6bb-c52d-97257629495b
---
# IPmHealthAndIdleMonitor::CheckIdle Method
Enables the worker process framework to request whether all the listener channels for a protocol manager are idle.  
  
## Syntax  
  
```cpp  
virtual HRESULT CheckIdle(  
   OUT BOOL* pfIdle  
) = 0;  
```  
  
### Parameters  
 `pfIdle`  
 `true` to indicate that all the protocol manger's listener channels are idle; otherwise, `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IPmHealthAndIdleMonitor Interface](../../web-development-reference/native-code-api-reference/ipmhealthandidlemonitor-interface.md)   
 [IPmHealthAndIdleMonitor::CheckHealth Method](../../web-development-reference/native-code-api-reference/ipmhealthandidlemonitor-checkhealth-method.md)
