---
title: "IAppHostConfigFile::GetMetadata Method"
ms.date: "10/07/2016"
ms.assetid: 7bc68fac-0728-3141-904e-f0c5f833bf3c
---
# IAppHostConfigFile::GetMetadata Method
Gets metadata from the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
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
 A `BSTR` that contains the name of the metadata to return.  
  
 `pValue`  
 A pointer to a `VARIANT` that contains the metadata.  
  
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
 [IAppHostConfigFile Interface](../../web-development-reference\native-code-api-reference/iapphostconfigfile-interface.md)