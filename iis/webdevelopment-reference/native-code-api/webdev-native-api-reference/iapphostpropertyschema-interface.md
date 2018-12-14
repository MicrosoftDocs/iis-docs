---
title: "IAppHostPropertySchema Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f38eaa29-b0c9-8df1-7dea-46fa9cba9771
caps.latest.revision: 11
author: "shirhatti"
manager: "wpickett"
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
|[GetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-getmetadata-method.md)|Gets metadata values from the schema.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostPropertySchema` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[DefaultValue](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-defaultvalue-property.md)|Gets the value that the [IAppHostProperty::Value](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostproperty-value-property.md) property returns when a value is not explicitly set.|  
|[IsCaseSensitive](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-iscasesensitive-property.md)|Gets a value that indicates whether the property value is case-sensitive.|  
|[IsCombinedKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-iscombinedkey-property.md)|Determines whether a property is part of a multiple-attribute key for a collection.|  
|[IsExpanded](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-isexpanded-property.md)|Determines whether environment variables in a property value should be expanded.|  
|[IsRequired](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-isrequired-property.md)|Determines whether a value must be defined for a property.|  
|[IsUniqueKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-isuniquekey-property.md)|Determines whether a property value is a unique key for a collection.|  
|[Name](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-name-property.md)|Gets the name of the current schema.|  
|[Type](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-type-property.md)|Gets the data type of the current schema.|  
|[ValidationParameter](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-validationparameter-property.md)|Provides attribute-validation parameter information for the current property.|  
|[ValidationType](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-validationtype-property.md)|Describes the type of validation that will be performed for the current property.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostPropertySchema`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [IAppHostElementSchema Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementschema-interface.md)