---
title: "IAppHostAdminManager::GetMetadata Method"
ms.date: "10/07/2016"
ms.assetid: 90d5e0f5-d4be-ac77-27f8-f7cceff48380
---
# IAppHostAdminManager::GetMetadata Method
Gets metadata values from the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
HRESULT GetMetadata(  
   [in,  
   string] BSTR bstrMetadataType,  
   [out,  
   retval] VARIANT* pValue  
);  
```  
  
### Parameters  
 `bstrMetadataType`  
 A `BSTR` that contains the name of the metadata being requested.  
  
 `pValue`  
 A pointer to a `VARIANT` that contains the value of the requested metadata.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_NOT_SUPPORTED|Indicates that the requested metadata is not supported.|  
  
## Example  
 The following code example retrieves the `availableSections` metadata from the configuration schema by using the `IAppHostAdminManager::GetMetadata` method.  
  
 [!code-cpp[IAppHostAdminLibrary#3](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostElementGetMetadata.cpp#3)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostAdminManager Interface](../../web-development-reference/native-code-api-reference/iapphostadminmanager-interface.md)