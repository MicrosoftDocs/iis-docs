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
 For more information about property validation, see the [IAppHostPropertySchema::ValidationType](../../web-development-reference\webdev-native-api-reference/iapphostpropertyschema-validationtype-property.md) and [IAppHostPropertySchema::ValidationParameter](../../web-development-reference\webdev-native-api-reference/iapphostpropertyschema-validationparameter-property.md) properties.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostPropertyException Interface](../../web-development-reference\webdev-native-api-reference/iapphostpropertyexception-interface.md)   
 [IAppHostPropertySchema::ValidationType Property](../../web-development-reference\webdev-native-api-reference/iapphostpropertyschema-validationtype-property.md)   
 [IAppHostPropertyException Interface](../../web-development-reference\webdev-native-api-reference/iapphostpropertyexception-interface.md)