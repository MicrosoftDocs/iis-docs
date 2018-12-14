---
title: "IAppHostMappingExtension Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 5ed0d0dd-8dfb-df88-a7a8-c0ec0e805f2c
caps.latest.revision: 8
author: "shirhatti"
manager: "wpickett"
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
|[GetSiteElementFromSiteId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmappingextension-getsiteelementfromsiteid-method.md)|Gets a configuration element that represents a site by using the unique identifier for the site.|  
|[GetSiteIdFromSiteName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmappingextension-getsiteidfromsitename-method.md)|Gets a unique identifier for a site by using the name of the site.|  
|[GetSiteNameFromSiteId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmappingextension-getsitenamefromsiteid-method.md)|Gets the name of a site by using the unique identifier for the site.|  
|[MapPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmappingextension-mappath-method.md)|Maps a site to a physical path, virtual directory, and application path by using the site name and virtual path.|  
  
## Properties  
 This interface contains no properties.  
  
## Remarks  
 Developers can extend the site-mapping functionality of IIS by implementing this interface to create a custom mapping extension.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostMappingExtension`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [Application Host Administration API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-api-reference.md)