---
title: "IAppHostPropertyException::ValidationFailureReason Property"
ms.date: "10/07/2016"
ms.assetid: 02fada1b-ad19-af0e-6e28-7ceb7b136af3
---
# IAppHostPropertyException::ValidationFailureReason Property
Gets the reason that the value of the [IAppHostPropertyException::InvalidValue](../../web-development-reference/native-code-api-reference/iapphostpropertyexception-invalidvalue-method.md) property did not validate against the value of the [IAppHostPropertySchema::ValidationParameter](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-validationparameter-property.md) property.  
  
## Syntax  
  
```cpp  
HRESULT get_ValidationFailureReason(  
   [out,  
   string,  
   retval] BSTR* pbstrValidationReason  
);  
```  
  
### Parameters  
 `pbstrValidationReason`  
 A pointer to a `BSTR` that contains a description indicating why the property value is not valid.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 When a property is not valid, the `IAppHostPropertyException::InvalidValue` property contains the value that did not validate against the `IAppHostPropertySchema::ValidationParameter` property. For more information about property validation, see the [IAppHostPropertySchema::ValidationType](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-validationtype-property.md) and `IAppHostPropertySchema::ValidationParameter` properties.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostPropertyException Interface](../../web-development-reference/native-code-api-reference/iapphostpropertyexception-interface.md)   
 [IAppHostPropertySchema::ValidationType Property](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-validationtype-property.md)   
 [IAppHostPropertySchema::ValidationParameter Property](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-validationparameter-property.md)