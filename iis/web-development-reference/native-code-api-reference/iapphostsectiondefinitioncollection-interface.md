---
title: "IAppHostSectionDefinitionCollection Interface"
ms.date: "10/07/2016"
ms.assetid: 8194bba0-4607-b515-3b54-0a50523dd26d
---
# IAppHostSectionDefinitionCollection Interface
Represents a collection of configuration section definitions.  
  
## Syntax  
  
```cpp  
interface IAppHostSectionDefinitionCollection : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostSectionDefinitionCollection` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[AddSection](../../web-development-reference/native-code-api-reference/iapphostsectiondefinitioncollection-addsection-method.md)|Adds a new configuration section definition  to the collection.|  
|[DeleteSection](../../web-development-reference/native-code-api-reference/iapphostsectiondefinitioncollection-deletesection-method.md)|Removes a configuration section definition from the collection|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostSectionDefinitionCollection` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Count](../../web-development-reference/native-code-api-reference/iapphostsectiondefinitioncollection-count-property.md)|Gets the number of configuration section definitions in the current collection.|  
|[Item](../../web-development-reference/native-code-api-reference/iapphostsectiondefinitioncollection-item-property.md)|Gets the configuration section definition at the requested index from the current collection.|  
  
## Inheritance Hierarchy  
 [IUnknown](/windows/win32/api/unknwn/nn-unknwn-iunknown)  
  
 `IAppHostSectionDefinitionCollection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)   
 [IAppHostPropertyCollection Interface](../../web-development-reference/native-code-api-reference/iapphostpropertycollection-interface.md)
