---
title: "IAppHostSectionDefinition Interface"
ms.date: "10/07/2016"
ms.assetid: 429518b6-f1be-413b-a98c-4cad57b3aaa4
---
# IAppHostSectionDefinition Interface
Provides access to the attributes that define the behavior of a configuration section.  
  
## Syntax  
  
```cpp  
IAppHostSectionDefinition : public IUnknown  
```  
  
## Methods  
 This interface contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostSectionDefinition` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[AllowDefinition](../../web-development-reference\native-code-api-reference/iapphostsectiondefinition-allowdefinition-property.md)|Gets or sets a value that indicates valid configuration path locations for the configuration section.|  
|[AllowLocation](../../web-development-reference\native-code-api-reference/iapphostsectiondefinition-allowlocation-property.md)|Gets or sets a value that indicates whether the configuration section allows the location attribute.|  
|[Name](../../web-development-reference\native-code-api-reference/iapphostsectiondefinition-name-property.md)|Gets the name of the current configuration section definition.|  
|[OverrideModeDefault](../../web-development-reference\native-code-api-reference/iapphostsectiondefinition-overridemodedefault-property.md)|Gets or sets the default override behavior for the current configuration section.|  
|[Type](../../web-development-reference\native-code-api-reference/iapphostsectiondefinition-type-property.md)|Gets the type name of a class that represents the current configuration section.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostSectionDefinition`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference\native-code-api-reference/application-host-administration-interfaces.md)