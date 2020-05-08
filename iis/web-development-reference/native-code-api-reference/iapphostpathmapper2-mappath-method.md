---
title: "IAppHostPathMapper2::MapPath Method"
ms.date: "10/07/2016"
ms.assetid: cb41794c-9656-47ba-92e3-b8d9af952243
---
# IAppHostPathMapper2::MapPath Method
Gets the details of the specific mapping decision and, optionally, can change the results in the return value.  
  
## Syntax  
  
```cpp  
HRESULT MapPath(  
   [in, string] BSTR bstrConfigPath,  
   [in, string] BSTR bstrMappedPhysicalPath,  
   [out, string, retval] BSTR * pbstrNewPhysicalPath,  
   [out] HANDLE * phImpersonationToken  
);  
```  
  
### Parameters  
 `bstrConfigPath`  
 The hierarchy path being mapped.  
  
 `bstrMappedPhysicalPath`  
 The server-side physical path that the administration system has determined maps to the specified hierarchy path.  
  
 `pbstrNewPhysicalPath`  
 Set to the new or updated physical path to use for the mapping. If the mapping stays the same, the client implementer should return the identical physical path that was passed in as `bstrMappedPhysicalPath`.  
  
 `phImpersonationToken`  
 Set to the impersonation token that was used to access the physical path.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 To receive incoming remote calls for the [IAppHostPathMapper2 Interface](../../web-development-reference/native-code-api-reference/iapphostpathmapper2-interface.md) interface, the client must implement a UUID(0f80e901-8f4c-449a-bf90-13d5d082f187). It must then specify an object that implements the interface to the [IAppHostAdminManager::SetMetadata Method](../../web-development-reference/native-code-api-reference/iapphostadminmanager-setmetadata-method.md) method with the value of `bstrMetadataName` set to "pathMapper2".  
  
 As an administration system maps hierarchy paths to physical paths on the server, it optionally calls the client-supplied object that implements the `IAppHostPathMapper2` interface. The implementer of this interface receives details of all mappings and can change the results of each mapping if required.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostPathMapper2 Interface](../../web-development-reference/native-code-api-reference/iapphostpathmapper2-interface.md)   
 [IAppHostPathMapper Interface](../../web-development-reference/native-code-api-reference/iapphostpathmapper-interface.md)
