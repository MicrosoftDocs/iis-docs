---
title: "IAppHostPropertySchema Interface"
ms.date: "10/07/2016"
ms.assetid: f38eaa29-b0c9-8df1-7dea-46fa9cba9771
---
# IAppHostPropertySchema Interface
Provides access to the attributes that define the schema for a property.  
  
## Syntax  
  
```cpp  
IAppHostPropertySchema : public IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostPropertySchema` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetMetadata](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-getmetadata-method.md)|Gets metadata values from the schema.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostPropertySchema` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[DefaultValue](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-defaultvalue-property.md)|Gets the value that the [IAppHostProperty::Value](../../web-development-reference/native-code-api-reference/iapphostproperty-value-property.md) property returns when a value is not explicitly set.|  
|[IsCaseSensitive](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-iscasesensitive-property.md)|Gets a value that indicates whether the property value is case-sensitive.|  
|[IsCombinedKey](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-iscombinedkey-property.md)|Determines whether a property is part of a multiple-attribute key for a collection.|  
|[IsExpanded](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-isexpanded-property.md)|Determines whether environment variables in a property value should be expanded.|  
|[IsRequired](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-isrequired-property.md)|Determines whether a value must be defined for a property.|  
|[IsUniqueKey](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-isuniquekey-property.md)|Determines whether a property value is a unique key for a collection.|  
|[Name](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-name-property.md)|Gets the name of the current schema.|  
|[Type](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-type-property.md)|Gets the data type of the current schema.|  
|[ValidationParameter](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-validationparameter-property.md)|Provides attribute-validation parameter information for the current property.|  
|[ValidationType](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-validationtype-property.md)|Describes the type of validation that will be performed for the current property.|  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostPropertySchema`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)
 [IAppHostElementSchema Interface](../../web-development-reference/native-code-api-reference/iapphostelementschema-interface.md)
