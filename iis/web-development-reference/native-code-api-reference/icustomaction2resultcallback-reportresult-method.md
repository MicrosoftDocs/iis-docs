---
title: "ICustomAction2ResultCallback::ReportResult Method"
ms.date: "10/07/2016"
ms.assetid: 7d619d90-fa22-4203-b4b5-cd91e8a4c879
---
# ICustomAction2ResultCallback::ReportResult Method
Returns the results of a `RegisterCustomAction` or `UnregisterCustomAction` operation that was requested by the [IPmCustomActions2](../../web-development-reference\native-code-api-reference/ipmcustomactions2-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual HRESULT ReportResult(  
   IN HRESULT hrStatus,  
   IN PBYTE pbResponse,  
   IN DWORD cbResponse  
) = 0;  
```  
  
### Parameters  
 `hrStatus`  
 An `HRESULT` that contains the status of the Run-Time Status and Control operation.  
  
 `pbResponse`  
 A pointer to a `BYTE` buffer that receives the results of the Run-Time Status and Control operation.  
  
 `cbResponse`  
 A pointer to a `DWORD` buffer that receives the size of the data pointed to by `pbResponse`.  
  
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
 [ICustomAction2ResultCallback Interface](../../web-development-reference\native-code-api-reference/icustomaction2resultcallback-interface.md)