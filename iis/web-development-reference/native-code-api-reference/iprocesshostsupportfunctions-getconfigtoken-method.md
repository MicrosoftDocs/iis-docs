---
title: "IProcessHostSupportFunctions::GetConfigToken Method"
description: This article contains syntax, parameters, return value, and requirements for the IProcessHostSupportFunctions::GetConfigToken Method.
ms.date: "10/07/2016"
ms.assetid: 43754858-3e25-31c4-136b-686d91d75575
---
# IProcessHostSupportFunctions::GetConfigToken Method
Retrieves a Windows security token for the specified application’s root directory.  
  
## Syntax  
  
```cpp  
virtual HRESULT __stdcall GetConfigToken(  
   LPCWSTR appId,  
   HANDLE* pToken  
) = 0;  
```  
  
### Parameters  
 `appId`  
 A string that contains the unique identifier of the application.  
  
 `pToken`  
 A pointer to a `HANDLE` that contains a Windows security token for the specified application’s root directory.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 You can use the `pToken` parameter to open and read application configuration settings.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [IProcessHostSupportFunctions Interface](../../web-development-reference/native-code-api-reference/iprocesshostsupportfunctions-interface.md)
