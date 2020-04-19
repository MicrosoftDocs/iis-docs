---
title: "IAppHostMappingExtension::GetSiteNameFromSiteId Method"
ms.date: "10/07/2016"
ms.assetid: 4d881261-f89d-894c-4bc7-51623a7228ab
---
# IAppHostMappingExtension::GetSiteNameFromSiteId Method
Gets the name of a site by using the unique identifier for the site.  
  
## Syntax  
  
```cpp  
HRESULT GetSiteNameFromSiteId(  
   [in] DWORD dwSiteId,  
   [out,  
   retval,  
   string] BSTR* pbstrSiteName  
);  
```  
  
### Parameters  
 `dwSiteId`  
 A `DWORD` that contains the site ID.  
  
 `pbstrSiteName`  
 A pointer to a `BSTR` that contains the site name.  
  
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
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostMappingExtension Interface](../../web-development-reference/native-code-api-reference/iapphostmappingextension-interface.md)