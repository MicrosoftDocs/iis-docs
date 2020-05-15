---
title: "IAppHostPropertyException::InvalidValue Method"
ms.date: "10/07/2016"
ms.assetid: 283ab332-f7b8-9833-72bb-d64209d3569d
---
# IAppHostPropertyException::InvalidValue Method

Gets the property value that did not meet the validation criteria.  
  
## Syntax  
  
```cpp  
HRESULT get_InvalidValue(  
   [out,  
   string,  
   retval] BSTR* pbstrValue  
);  
```  
  
### Parameters  

 `pbstrValue`  
 A pointer to a `BSTR` that contains the value encountered during the validation process that did not meet the criteria defined in the property schema.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  

 For more information about property validation, see the [IAppHostPropertySchema::ValidationType](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-validationtype-property.md) and [IAppHostPropertySchema::ValidationParameter](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-validationparameter-property.md) properties.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  

 [IAppHostPropertyException Interface](../../web-development-reference/native-code-api-reference/iapphostpropertyexception-interface.md)
