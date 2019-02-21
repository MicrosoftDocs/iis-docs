---
title: "IAppHostPropertySchema::IsCombinedKey Property"
ms.date: "10/07/2016"
ms.assetid: 1a7b0abb-b457-4782-4c1c-eb0990cbe93a
---
# IAppHostPropertySchema::IsCombinedKey Property
Determines whether a property is part of a multiple-attribute key for a collection.  
  
## Syntax  
  
```cpp  
HRESULT get_IsCombinedKey(  
   [out,  
   retval] VARIANT_BOOL* pfIsCombinedKey  
);  
```  
  
### Parameters  
 `pfIsCombinedKey`  
 A pointer to a `VARIANT_BOOL`. `VARIANT_TRUE` if the property is part of a multiple-attribute key; otherwise, `VARIANT_FALSE`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The `binding` element is an example of a combined key. In the following example, the `binding` element contains `protocol` and `bindingInformation` attributes that are part of a combined key.  
  
 `<element name="bindings">`  
  
 `<collection addElement="binding" clearElement="clear">`  
  
 `<attribute name="protocol" type="string" required="true"                isCombinedKey="true" validationType="nonEmptyString" />`  
  
 `<attribute name="bindingInformation" type="string" required="true"                 isCombinedKey="true" validationType="nonEmptyString" />`  
  
 `</collection>`  
  
 `</element>`  
  
 The `bindings` element can contain any number of elements that have the same `protocol` attribute. However, the `bindings` element cannot contain more than one `binding` element that has the same `protocol` and `bindingInformation` attributes.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostPropertySchema Interface](../../web-development-reference\native-code-api-reference/iapphostpropertyschema-interface.md)   
 [IAppHostPropertySchema::IsUniqueKey Property](../../web-development-reference\native-code-api-reference/iapphostpropertyschema-isuniquekey-property.md)