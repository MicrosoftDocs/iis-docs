---
title: "IAppHostPropertyException::ValidationFailureReason Property | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 02fada1b-ad19-af0e-6e28-7ceb7b136af3
caps.latest.revision: 12
author: "shirhatti"
manager: "wpickett"
---
# IAppHostPropertyException::ValidationFailureReason Property
Gets the reason that the value of the [IAppHostPropertyException::InvalidValue](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyexception-invalidvalue-method.md) property did not validate against the value of the [IAppHostPropertySchema::ValidationParameter](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-validationparameter-property.md) property.  
  
## Syntax  
  
```cpp  
HRESULT get_ValidationFailureReason(  
   [out,  
   string,  
   retval] BSTR* pbstrValidationReason  
);  
```  
  
#### Parameters  
 `pbstrValidationReason`  
 A pointer to a `BSTR` that contains a description indicating why the property value is not valid.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 When a property is not valid, the `IAppHostPropertyException::InvalidValue` property contains the value that did not validate against the `IAppHostPropertySchema::ValidationParameter` property. For more information about property validation, see the [IAppHostPropertySchema::ValidationType](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-validationtype-property.md) and `IAppHostPropertySchema::ValidationParameter` properties.  
  
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
 [IAppHostPropertySchema::ValidationParameter Property](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-validationparameter-property.md)