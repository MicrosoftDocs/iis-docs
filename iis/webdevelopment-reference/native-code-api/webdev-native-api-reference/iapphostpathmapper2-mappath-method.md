---
title: "IAppHostPathMapper2::MapPath Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: cb41794c-9656-47ba-92e3-b8d9af952243
caps.latest.revision: 8
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
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
 To receive incoming remote calls for the [IAppHostPathMapper2 Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpathmapper2-interface.md) interface, the client must implement a UUID(0f80e901-8f4c-449a-bf90-13d5d082f187). It must then specify an object that implements the interface to the [IAppHostAdminManager::SetMetadata Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-setmetadata-method.md) method with the value of `bstrMetadataName` set to "pathMapper2".  
  
 As an administration system maps hierarchy paths to physical paths on the server, it optionally calls the client-supplied object that implements the `IAppHostPathMapper2` interface. The implementer of this interface receives details of all mappings and can change the results of each mapping if required.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostPathMapper2 Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpathmapper2-interface.md)   
 [IAppHostPathMapper Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpathmapper-interface.md)