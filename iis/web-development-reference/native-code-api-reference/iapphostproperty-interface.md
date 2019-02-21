---
title: "IAppHostProperty Interface"
ms.date: "10/07/2016"
ms.assetid: 8cb03b60-3a5c-d308-1532-9f625ec1c5ec
---
# IAppHostProperty Interface
Represents a property of a configuration element.  
  
## Syntax  
  
```cpp  
interface IAppHostProperty : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostProperty` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[Clear](../../web-development-reference\native-code-api-reference/iapphostproperty-clear-method.md)|Removes the current property from the XML persisted by the configuration system.|  
|[GetMetadata](../../web-development-reference\native-code-api-reference/iapphostproperty-getmetadata-method.md)|Gets metadata values for the current property.|  
|[SetMetadata](../../web-development-reference\native-code-api-reference/iapphostproperty-setmetadata-method.md)|Sets metadata for the current property.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostProperty` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Name](../../web-development-reference\native-code-api-reference/iapphostproperty-name-property.md)|Gets the name of the property.|  
|[Exception](../../web-development-reference\native-code-api-reference/iapphostproperty-exception-property.md)|Gets an exception if the current property value does not meet the validation criteria specified in the property schema.|  
|[Schema](../../web-development-reference\native-code-api-reference/iapphostproperty-schema-property.md)|Gets the schema assigned to the current property.|  
|[StringValue](../../web-development-reference\native-code-api-reference/iapphostproperty-stringvalue-property.md)|Gets the persisted string value of the property that is stored in XML by the configuration system.|  
|[Value](../../web-development-reference\native-code-api-reference/iapphostproperty-value-property.md)|Gets or sets the value of the current property.|  
  
## Example  
 The following code example reads the value of the `enabled` attribute by using the `IAppHostProperty::Value` property.  
  
<!-- TODO: review snippet reference  [!CODE [IAppHostAdminLibrary#2](IAppHostAdminLibrary#2)]  -->  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostProperty`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference\native-code-api-reference/application-host-administration-interfaces.md)   
 [IAppHostElement Interface](../../web-development-reference\native-code-api-reference/iapphostelement-interface.md)