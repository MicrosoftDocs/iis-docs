---
title: "ICustomActionResultCallback::ReportResult Method"
ms.date: "10/07/2016"
ms.assetid: 898904c0-ee7c-81fd-8ac7-8a59b8835971
---
# ICustomActionResultCallback::ReportResult Method

Returns the results of a Run-Time Status and Control operation that was requested by the [IPmCustomActions::RunCustomAction](../../web-development-reference/native-code-api-reference/ipmcustomactions-runcustomaction-method.md) method.  
  
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

 [ICustomActionResultCallback Interface](../../web-development-reference/native-code-api-reference/icustomactionresultcallback-interface.md)   
 [IPmCustomActions::RunCustomAction Method](../../web-development-reference/native-code-api-reference/ipmcustomactions-runcustomaction-method.md)
