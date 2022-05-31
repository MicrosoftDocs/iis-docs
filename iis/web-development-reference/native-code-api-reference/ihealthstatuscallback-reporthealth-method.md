---
title: "IHealthStatusCallback::ReportHealth Method"
description: "Describes the IHealthStatusCallback::ReportHealth method and details the syntax, parameters, return value, remarks, and requirements."
ms.date: 10/07/2016
ms.assetid: 97b88f52-6240-6a7c-252d-1e5fc6ba9b29
---
# IHealthStatusCallback::ReportHealth Method
Allows a protocol manager to report its current health status in response to a query from the [IPmHealthAndIdleMonitor::CheckHealth](../../web-development-reference/native-code-api-reference/ipmhealthandidlemonitor-checkhealth-method.md) method.  
  
## Syntax  
  
```cpp  
virtual HRESULT ReportHealth(  
   BOOL fHealthy  
) = 0;  
```  
  
### Parameters  
 `fHealthy`  
 `true` to indicate that the protocol manager is healthy; otherwise, `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 Protocol managers are responsible for monitoring and reporting their own health status.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IHealthStatusCallback Interface](../../web-development-reference/native-code-api-reference/ihealthstatuscallback-interface.md)   
 [IPmHealthAndIdleMonitor::CheckHealth Method](../../web-development-reference/native-code-api-reference/ipmhealthandidlemonitor-checkhealth-method.md)
