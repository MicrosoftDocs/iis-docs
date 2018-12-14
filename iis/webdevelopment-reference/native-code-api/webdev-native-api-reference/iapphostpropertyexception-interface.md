---
title: "IAppHostPropertyException Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b9cf27c2-261a-2dcf-30bb-3c3fd0cf32a2
caps.latest.revision: 10
author: "shirhatti"
manager: "wpickett"
---
# IAppHostPropertyException Interface
Indicates that the configuration system has thrown an exception when it validates a property against the configuration schema.  
  
## Syntax  
  
```cpp  
interface IAppHostPropertyException : public IAppHostConfigException  
```  
  
## Methods  
 This interface contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostPropertyException` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[InvalidValue](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyexception-invalidvalue-method.md)|Gets the property value that did not meet the validation criteria.|  
|[ValidationFailureParameters](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyexception-validationfailureparameters-property.md)|Gets the validation parameters that are defined in the property schema.|  
|[ValidationFailureReason](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyexception-validationfailurereason-property.md)|Gets the reason that the value of the `InvalidValue` property did not validate against the value of the [IAppHostPropertySchema::ValidationParameter](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-validationparameter-property.md) property.|  
  
## Inheritance Hierarchy  
 [IAppHostConfigException](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigexception-interface.md)  
  
 `IAppHostPropertyException`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [IAppHostConfigException Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigexception-interface.md)