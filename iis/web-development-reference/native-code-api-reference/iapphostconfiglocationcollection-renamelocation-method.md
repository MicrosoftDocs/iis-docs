---
title: "IAppHostConfigLocationCollection::RenameLocation method"
ms.date: "10/07/2016"
ms.assetid: 2d2cf153-c806-40e3-9c18-c681f7146796
---
# IAppHostConfigLocationCollection::RenameLocation method
Changes the location at the specified index in the collection.  
  
## Syntax  
  
```cpp  
HRESULT RenameLocation(  
   [in] VARIANT varIndex,  
   [in] BSTR bstrLocationPath  
);  
```  
  
### Parameters  
 `varIndex`  
 A `VARIANT` that contains the index of the configuration location to rename. The index can contain a `BSTR` that specifies the location path.  
  
 `bstrLocationPath`  
 The new path for the location.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_INDEX|Indicates that the provided index is invalid.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostConfigLocationCollection Interface](../../web-development-reference\native-code-api-reference/iapphostconfiglocationcollection-interface.md)