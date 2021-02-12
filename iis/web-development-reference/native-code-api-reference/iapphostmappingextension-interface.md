---
title: "IAppHostMappingExtension Interface"
ms.date: "10/07/2016"
ms.assetid: 5ed0d0dd-8dfb-df88-a7a8-c0ec0e805f2c
---
# IAppHostMappingExtension Interface
Extends the configuration system mapping functionality.  
  
## Syntax  
  
```cpp  
IAppHostMappingExtension : public IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostMappingExtension` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetSiteElementFromSiteId](../../web-development-reference/native-code-api-reference/iapphostmappingextension-getsiteelementfromsiteid-method.md)|Gets a configuration element that represents a site by using the unique identifier for the site.|  
|[GetSiteIdFromSiteName](../../web-development-reference/native-code-api-reference/iapphostmappingextension-getsiteidfromsitename-method.md)|Gets a unique identifier for a site by using the name of the site.|  
|[GetSiteNameFromSiteId](../../web-development-reference/native-code-api-reference/iapphostmappingextension-getsitenamefromsiteid-method.md)|Gets the name of a site by using the unique identifier for the site.|  
|[MapPath](../../web-development-reference/native-code-api-reference/iapphostmappingextension-mappath-method.md)|Maps a site to a physical path, virtual directory, and application path by using the site name and virtual path.|  
  
## Properties  
 This interface contains no properties.  
  
## Remarks  
 Developers can extend the site-mapping functionality of IIS by implementing this interface to create a custom mapping extension.  
  
## Inheritance Hierarchy  
 [IUnknown](/windows/win32/api/unknwn/nn-unknwn-iunknown)  
  
 `IAppHostMappingExtension`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)   
 [Application Host Administration API Reference](../../web-development-reference/native-code-api-reference/application-host-administration-api-reference.md)
