---
title: "IAppHostMappingExtension::GetSiteElementFromSiteId Method"
ms.date: "10/07/2016"
ms.assetid: fa1c2d4d-87a7-7527-6450-3ecda7ba560d
---
# IAppHostMappingExtension::GetSiteElementFromSiteId Method
Gets a configuration element that represents a site by using the unique identifier for the site.  
  
## Syntax  
  
```cpp  
HRESULT GetSiteElementFromSiteId(  
   [in] DWORD dwSiteId,  
   [out,  
   retval] IAppHostElement** ppSiteElement  
);  
```  
  
### Parameters  
 `dwSiteId`  
 A `DWORD` that contains the site ID.  
  
 `ppSiteElement`  
 A pointer to a pointer for an [IAppHostElement](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) interface.  
  
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