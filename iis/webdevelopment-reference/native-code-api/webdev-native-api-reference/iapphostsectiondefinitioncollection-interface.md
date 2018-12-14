---
title: "IAppHostSectionDefinitionCollection Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8194bba0-4607-b515-3b54-0a50523dd26d
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
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
|[AddSection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinitioncollection-addsection-method.md)|Adds a new configuration section definition  to the collection.|  
|[DeleteSection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinitioncollection-deletesection-method.md)|Removes a configuration section definition from the collection|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostSectionDefinitionCollection` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Count](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinitioncollection-count-property.md)|Gets the number of configuration section definitions in the current collection.|  
|[Item](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinitioncollection-item-property.md)|Gets the configuration section definition at the requested index from the current collection.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostSectionDefinitionCollection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [IAppHostPropertyCollection Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertycollection-interface.md)