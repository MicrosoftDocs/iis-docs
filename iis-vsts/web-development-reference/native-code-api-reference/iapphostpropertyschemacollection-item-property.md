---
title: "IAppHostPropertySchemaCollection::Item Property"
ms.date: "10/07/2016"
ms.assetid: 130fb6ce-5315-4ed8-959b-3b1346efb19d
---
# IAppHostPropertySchemaCollection::Item Property
Gets the [IAppHostPropertySchema Interface](../../web-development-reference\native-code-api-reference/iapphostpropertyschema-interface.md) with the requested index or property schema name in the collection.  
  
## Syntax  
  
```cpp  
[propget, id(DISPID_VALUE)] HRESULT Item(  
   [in] VARIANT cIndex,  
   [out,  
   retval] IAppHostPropertySchema** ppPropertySchema  
);  
```  
  
### Parameters  
 `cIndex`  
 A `VARIANT` that specifies the[IAppHostPropertySchema Interface](../../web-development-reference\native-code-api-reference/iapphostpropertyschema-interface.md) to retreive from the collection. If the `VARIANT` is of type integer, this is a zero-based index to the collection. If the `VARIANT` is of type string, this is a string index that represents the name of the[IAppHostPropertySchema Interface](../../web-development-reference\native-code-api-reference/iapphostpropertyschema-interface.md) to retrieve.  
  
 `ppProperty`  
 Contains the[IAppHostPropertySchema Interface](../../web-development-reference\native-code-api-reference/iapphostpropertyschema-interface.md) at the requested `cIndex`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_INDEX|Indicates that the requested property schema was not found.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostPropertySchemaCollection Interface](../../web-development-reference\native-code-api-reference/iapphostpropertyschemacollection-interface.md)   
 [IAppHostPropertySchema Interface](../../web-development-reference\native-code-api-reference/iapphostpropertyschema-interface.md)