---
title: "IAppHostPropertyException::ValidationFailureParameters Property | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 86a3ed6b-6bf6-c5c5-c090-2d7952e43029
caps.latest.revision: 10
author: "shirhatti"
manager: "wpickett"
---
# IAppHostPropertyException::ValidationFailureParameters Property
Gets the validation parameters that are defined in the property schema.  
  
## Syntax  
  
```cpp  
HRESULT get_ValidationFailureParameters(  
   [out,  
   retval] SAFEARRAY(VARIANT  
)* pParameterArray);  
```  
  
#### Parameters  
 `pParameterArray`  
 A pointer to a `SAFEARRAY` of `VARIANT` values that contains the validation parameters found in the property schema.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 For more information about property validation, see the [IAppHostPropertySchema::ValidationType](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-validationtype-property.md) and [IAppHostPropertySchema::ValidationParameter](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-validationparameter-property.md) properties.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostPropertyException Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyexception-interface.md)   
 [IAppHostPropertySchema::ValidationType Property](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-validationtype-property.md)   
 [IAppHostPropertyException Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyexception-interface.md)