---
title: "IAppHostElementSchemaCollection::Item Property"
ms.date: "10/07/2016"
ms.assetid: 49cd2a06-8bb9-4bab-9d0d-b49b5045bb35
---
# IAppHostElementSchemaCollection::Item Property
Gets the [IAppHostElementSchema Interface](../../web-development-reference/native-code-api-reference/iapphostelementschema-interface.md) with the requested index or property name in the collection.  
  
## Syntax  
  
```cpp  
[propget, id(DISPID_VALUE)] HRESULT Item(  
   [in] VARIANT cIndex,  
   [out,  
   retval] IAppHostElementSchema** ppElementSchema  
);  
```  
  
### Parameters  
 `cIndex`  
 A `VARIANT` that specifies the [IAppHostElementSchema Interface](../../web-development-reference/native-code-api-reference/iapphostelementschema-interface.md) to retreive from the collection. If the `VARIANT` is of type integer, this is a zero-based index to the collection. If the `VARIANT` is of type string, this is a string index that represents the name of the [IAppHostElementSchema Interface](../../web-development-reference/native-code-api-reference/iapphostelementschema-interface.md) to retrieve.  
  
 `ppElementSchema`  
 Contains the [IAppHostElementSchema Interface](../../web-development-reference/native-code-api-reference/iapphostelementschema-interface.md) at the requested `cIndex`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_INDEX|Indicates that the requested element schema was not found.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostElementSchemaCollection Interface](../../web-development-reference/native-code-api-reference/iapphostelementschemacollection-interface.md)   
 [IAppHostElementSchema Interface](../../web-development-reference/native-code-api-reference/iapphostelementschema-interface.md)