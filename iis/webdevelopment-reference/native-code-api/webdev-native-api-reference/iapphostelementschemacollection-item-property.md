---
title: "IAppHostElementSchemaCollection::Item Property | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 49cd2a06-8bb9-4bab-9d0d-b49b5045bb35
caps.latest.revision: 8
author: "shirhatti"
manager: "wpickett"
---
# IAppHostElementSchemaCollection::Item Property
Gets the [IAppHostElementSchema Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementschema-interface.md) with the requested index or property name in the collection.  
  
## Syntax  
  
```cpp  
[propget, id(DISPID_VALUE)] HRESULT Item(  
   [in] VARIANT cIndex,  
   [out,  
   retval] IAppHostElementSchema** ppElementSchema  
);  
```  
  
#### Parameters  
 `cIndex`  
 A `VARIANT` that specifies the [IAppHostElementSchema Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementschema-interface.md) to retreive from the collection. If the `VARIANT` is of type integer, this is a zero-based index to the collection. If the `VARIANT` is of type string, this is a string index that represents the name of the [IAppHostElementSchema Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementschema-interface.md) to retrieve.  
  
 `ppElementSchema`  
 Contains the [IAppHostElementSchema Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementschema-interface.md) at the requested `cIndex`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_INDEX|Indicates that the requested element schema was not found.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostElementSchemaCollection Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementschemacollection-interface.md)   
 [IAppHostElementSchema Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementschema-interface.md)