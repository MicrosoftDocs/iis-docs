---
title: "IAppHostConfigLocation Interface"
ms.date: "10/07/2016"
ms.assetid: 561b9314-d818-d465-9445-209aa61c44f9
---
# IAppHostConfigLocation Interface
Represents a configuration location in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
interface IAppHostConfigLocation : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostConfigLocation` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[AddConfigSection](../../web-development-reference\native-code-api-reference/iapphostconfiglocation-addconfigsection-method.md)|Adds a configuration section to the current configuration location.|  
|[DeleteConfigSection](../../web-development-reference\native-code-api-reference/iapphostconfiglocation-deleteconfigsection-method.md)|Removes a configuration section from the current configuration location.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostConfigLocation` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Count](../../web-development-reference\native-code-api-reference/iapphostconfiglocation-count-property.md)|Gets the number of configuration sections that are configured for the current configuration location.|  
|[Item](../../web-development-reference\native-code-api-reference/iapphostconfiglocation-item-property.md)|Gets the requested configuration section from the current location.|  
|[Path](../../web-development-reference\native-code-api-reference/iapphostconfiglocation-path-property.md)|Gets the path of the current configuration location.|  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostConfigLocation`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference\native-code-api-reference/application-host-administration-interfaces.md)