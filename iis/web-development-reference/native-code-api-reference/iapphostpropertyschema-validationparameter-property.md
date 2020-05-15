---
title: "IAppHostPropertySchema::ValidationParameter Property"
ms.date: "10/07/2016"
ms.assetid: 44cfa36d-c54d-3c23-6ca6-7509e9dfc8f4
---
# IAppHostPropertySchema::ValidationParameter Property

Provides attribute-validation parameter information for the current property.  
  
## Syntax  
  
```cpp  
HRESULT get_ValidationParameter(  
   [out,  
   retval,  
   string] BSTR* pbstrValidationParameter  
);  
```  
  
### Parameters  

 `pbstrValidationParameter`  
 A pointer to a `BSTR` that contains the validation parameter.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  

 Attribute validation is performed when XML is parsed and when the API makes a call to set a value in the configuration system.  
  
 The following table provides the available validation types.  
  
|Validation type|Description|  
|---------------------|-----------------|  
|applicationPoolName|Will fail validation if the property value contains any one of the following characters: `&#124;<>&\"`<br /><br /> The following example will cause validation failure if the property value includes one of the restricted characters.<br /><br /> `validationType="applicationPoolName"`<br /><br /> `validationParameter=""`|  
|integerRange|Syntax: `<minimum>,<maximum>[,exclude]`<br /><br /> Will fail validation if the property value is set to a value outside the specified range.<br /><br /> The following example will cause validation failure if the property is set to a value less than 1 or larger than 10.<br /><br /> `validationType="integerRange"`<br /><br /> `validationParameter="1,10,exclude"`|  
|nonEmptyString|Will fail validation if the property value is set to an empty string.<br /><br /> The following example will cause validation failure if the property value is set to an empty string.<br /><br /> `validationType="nonEmptyString"`<br /><br /> `validationParameter=""`|  
|siteName|Will fail validation if the property value contains any one of the following characters: `/\.?`<br /><br /> The following example will cause validation failure if the property value includes one of the restricted characters.<br /><br /> `validationType="siteName"`<br /><br /> `validationParameter=""`|  
|timeSpanRange|Syntax: `<minimum>,<maximum>,<granularity>[,exclude]`<br /><br /> Will fail validation if the property value is set to a value outside the specified range. `<granularity>` indicates the increments that are allowed between `<minimum>` and `<maximum>`.<br /><br /> The following example will cause validation failure if the property is set to a value less than 1, greater than 2592000, and is not an increment of 60 within the range.<br /><br /> `validationType="timeSpanRange"`<br /><br /> `validationParameter="1,2592000,60"`|  
|requireTrimmedString|Will fail validation if white space is found at the start or end the property value.<br /><br /> The following example will cause validation failure if the property value contains white space at the start or end of the value.<br /><br /> `validationType="requireTrimmedString"`<br /><br /> `validationParameter=""`|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  

 [IAppHostPropertySchema Interface](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-interface.md)   
 [IAppHostPropertySchema::ValidationType Property](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-validationtype-property.md)
