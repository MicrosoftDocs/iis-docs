---
title: "IAppHostSectionGroup Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f39c8583-6e8f-e9ef-354d-2c0f8f8b795d
caps.latest.revision: 11
author: "shirhatti"
manager: "wpickett"
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
|[AddSectionGroup](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiongroup-addsectiongroup-method.md)|Adds a new nested configuration section group under the current configuration section group.|  
|[DeleteSectionGroup](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiongroup-deletesectiongroup-method.md)|Removes a configuration section group that is nested under the current configuration section group.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostSectionGroup` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Count](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiongroup-count-property.md)|Gets the current number of configuration section groups that are nested in the current section group.|  
|[Item](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiongroup-item-property.md)|Gets the nested configuration section group at the requested index.|  
|[Name](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiongroup-name-property.md)|Gets the name of the configuration section group.|  
|[Sections](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiongroup-sections-property.md)|Gets a configuration section definition collection that contains all the section definitions in the current configuration section group.|  
|[Type](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiongroup-type-property.md)|Gets the type name of the configuration section group.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostSectionGroup`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)