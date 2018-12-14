---
title: "IAppHostPropertySchema::IsCombinedKey Property | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1a7b0abb-b457-4782-4c1c-eb0990cbe93a
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
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
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostPropertySchema Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-interface.md)   
 [IAppHostPropertySchema::IsUniqueKey Property](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-isuniquekey-property.md)