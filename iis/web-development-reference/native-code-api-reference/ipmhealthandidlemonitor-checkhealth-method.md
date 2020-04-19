---
title: "IPmHealthAndIdleMonitor::CheckHealth Method"
ms.date: "10/07/2016"
ms.assetid: e9c579f1-b2ae-c57a-8ee3-edf3949beef5
---
# IPmHealthAndIdleMonitor::CheckHealth Method
Enables the worker process framework to request the health status of a protocol manager.  
  
## Syntax  
  
```cpp  
virtual HRESULT CheckHealth(  
   IHealthStatusCallback* pIHealthStatusCallback  
) = 0;  
```  
  
### Parameters  
 `pIHealthStatusCallback`  
 A pointer to an [IHealthStatusCallback](../../web-development-reference/native-code-api-reference/ihealthstatuscallback-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 When this method is called, a pointer to an `IHealthStatusCallback` interface is passed, which allows the protocol manager to report its current health.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IPmHealthAndIdleMonitor Interface](../../web-development-reference/native-code-api-reference/ipmhealthandidlemonitor-interface.md)   
 [IHealthStatusCallback Interface](../../web-development-reference/native-code-api-reference/ihealthstatuscallback-interface.md)   
 [IPmHealthAndIdleMonitor::CheckIdle Method](../../web-development-reference/native-code-api-reference/ipmhealthandidlemonitor-checkidle-method.md)