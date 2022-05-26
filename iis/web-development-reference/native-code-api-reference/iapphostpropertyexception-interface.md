---
title: IAppHostPropertyException Interface
description: Describes the IAppHostPropertyException interface and provides the interface's syntax, properties, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: b9cf27c2-261a-2dcf-30bb-3c3fd0cf32a2
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
|[InvalidValue](../../web-development-reference/native-code-api-reference/iapphostpropertyexception-invalidvalue-method.md)|Gets the property value that did not meet the validation criteria.|  
|[ValidationFailureParameters](../../web-development-reference/native-code-api-reference/iapphostpropertyexception-validationfailureparameters-property.md)|Gets the validation parameters that are defined in the property schema.|  
|[ValidationFailureReason](../../web-development-reference/native-code-api-reference/iapphostpropertyexception-validationfailurereason-property.md)|Gets the reason that the value of the `InvalidValue` property did not validate against the value of the [IAppHostPropertySchema::ValidationParameter](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-validationparameter-property.md) property.|  
  
## Inheritance Hierarchy  
 [IAppHostConfigException](../../web-development-reference/native-code-api-reference/iapphostconfigexception-interface.md)  
  
 `IAppHostPropertyException`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)   
 [IAppHostConfigException Interface](../../web-development-reference/native-code-api-reference/iapphostconfigexception-interface.md)
