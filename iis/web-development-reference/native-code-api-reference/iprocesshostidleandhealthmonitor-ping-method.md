---
title: "IProcessHostIdleAndHealthMonitor::Ping Method"
description: "Describes the IProcessHostIdleAndHealthMonitor::Ping method and details its syntax, parameters, return value, and requirements."
ms.date: 10/07/2016
ms.assetid: a5a02b12-f6e8-f8bf-40ac-153d9dea93be
---
# IProcessHostIdleAndHealthMonitor::Ping Method
Performs an asynchronous ping operation.  
  
## Syntax  
  
```cpp  
virtual HRESULT __stdcall Ping(  
   IProcessPingCallback* pCallback  
) = 0;  
```  
  
### Parameters  
 `pCallback`  
 An [IProcessPingCallback](../../web-development-reference/native-code-api-reference/iprocesspingcallback-interface.md) interface through which the process host can respond to an asynchronous ping operation. `pCallback` is the object on which to perform the callback function.  
  
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
|Header|Webhost.h|  
  
## See Also  
 [IProcessHostIdleAndHealthMonitor Interface](../../web-development-reference/native-code-api-reference/iprocesshostidleandhealthmonitor-interface.md)
