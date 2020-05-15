---
title: "IAppHostAdminManager::SetMetadata Method"
ms.date: "10/07/2016"
ms.assetid: 1fb582bf-d87e-7f90-6846-f1e00bce9b70
---
# IAppHostAdminManager::SetMetadata Method

Sets metadata values in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
HRESULT SetMetadata(  
   [in,  
   string] BSTR bstrMetadataType,  
   [in] VARIANT value  
);  
```  
  
### Parameters  

 `bstrMetadataType`  
 A `BSTR` that contains the name of the metadata being set.  
  
 `value`  
 A `VARIANT` that contains the new metadata.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_NOT_SUPPORTED|Indicates that the metadata being set is not supported.|  
  
## Example  

 The following code example sets a `configSource` attribute for the `system.applicationHost/sites` section by using the `IAppHostAdminManager::SetMetadata` method.  
  
 [!code-cpp[IAppHostAdminLibrary#4](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostElementSetMetadata.cpp#4)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  

 [IAppHostAdminManager Interface](../../web-development-reference/native-code-api-reference/iapphostadminmanager-interface.md)
