---
title: "IAppHostProperty::SetMetadata Method"
ms.date: "10/07/2016"
ms.assetid: 62af8bec-6065-28a8-9186-692602d536f3
---
# IAppHostProperty::SetMetadata Method
Sets metadata for the current property.  
  
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
 A `BSTR` that contains the name of the metadata being requested.  
  
 `value`  
 A `VARIANT` that contains the new metadata.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_NOT_SUPPORTED|Indicates that the metadata is not recognized.|  
  
## Example  
 The following code example sets the `configSource` attribute for the `system.applicationHost/sites` configuration section by using the `SetMetadata` method.  
  
 [!code-cpp[IAppHostAdminLibrary#4](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostElementSetMetadata.cpp#4)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostProperty Interface](../../web-development-reference/native-code-api-reference/iapphostproperty-interface.md)