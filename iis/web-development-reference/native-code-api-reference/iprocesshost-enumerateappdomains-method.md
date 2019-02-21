---
title: "IProcessHost::EnumerateAppDomains Method"
ms.date: "10/07/2016"
ms.assetid: e59e42da-ba07-2d9f-84e3-38c4bb8dc165
---
# IProcessHost::EnumerateAppDomains Method
Retrieves a pointer to an [IAppDomainInfoEnum](../../web-development-reference\native-code-api-reference/iappdomaininfoenum-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual HRESULT __stdcall EnumerateAppDomains(  
   IAppDomainInfoEnum** pAppDomainsInfo  
) = 0;  
```  
  
### Parameters  
 `pAppDomainsInfo`  
 A pointer to the address of an `IAppDomainInfoEnum` interface.  
  
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
 [IProcessHost Interface](../../web-development-reference\native-code-api-reference/iprocesshost-interface.md)   
 [IAppDomainInfoEnum Interface](../../web-development-reference\native-code-api-reference/iappdomaininfoenum-interface.md)