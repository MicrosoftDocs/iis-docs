---
title: "IAppHostSectionGroup Interface"
ms.date: "10/07/2016"
ms.assetid: f39c8583-6e8f-e9ef-354d-2c0f8f8b795d
---
# IAppHostSectionGroup Interface
Provides access to a group of configuration section groups or configuration section definitions.  
  
## Syntax  
  
```cpp  
interface IAppHostSectionGroup : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostSectionGroup` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[AddSectionGroup](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-addsectiongroup-method.md)|Adds a new nested configuration section group under the current configuration section group.|  
|[DeleteSectionGroup](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-deletesectiongroup-method.md)|Removes a configuration section group that is nested under the current configuration section group.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostSectionGroup` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Count](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-count-property.md)|Gets the current number of configuration section groups that are nested in the current section group.|  
|[Item](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-item-property.md)|Gets the nested configuration section group at the requested index.|  
|[Name](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-name-property.md)|Gets the name of the configuration section group.|  
|[Sections](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-sections-property.md)|Gets a configuration section definition collection that contains all the section definitions in the current configuration section group.|  
|[Type](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-type-property.md)|Gets the type name of the configuration section group.|  
  
## Inheritance Hierarchy  
 [IUnknown](/windows/win32/api/unknwn/nn-unknwn-iunknown)  
  
 `IAppHostSectionGroup`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)
