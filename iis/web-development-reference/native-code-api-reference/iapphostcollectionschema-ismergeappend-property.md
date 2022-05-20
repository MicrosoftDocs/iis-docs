---
title: "IAppHostCollectionSchema::IsMergeAppend Property"
description: Learn how the IsMergeAppend property gets a value that determines whether local collection elements are merged after inherited elements are added.
ms.date: "10/07/2016"
ms.assetid: 22dabafd-081f-bebe-24de-c5ed61dbc6d9
---
# IAppHostCollectionSchema::IsMergeAppend Property
Gets a value that determines whether local collection elements are merged after inherited elements are added.  
  
## Syntax  
  
```cpp  
HRESULT get_IsMergeAppend(  
   [out,  
   retval] VARIANT_BOOL* pfIsMergeAppend  
);  
```  
  
### Parameters  
 `pfIsMergeAppend`  
 A pointer to a `VARIANT_BOOL`. `VARIANT_TRUE` if local collection elements are merged after inherited elements are added; `VARIANT_FALSE` if inherited elements are merged after local collection elements are added.  
  
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
  
## Remarks  
 If this property is `VARIANT_FALSE`, local elements are merged before inherited elements.  
  
## See Also  
 [IAppHostCollectionSchema Interface](../../web-development-reference/native-code-api-reference/iapphostcollectionschema-interface.md)
