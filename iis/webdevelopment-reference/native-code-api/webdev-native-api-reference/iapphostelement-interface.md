---
title: "IAppHostElement Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b2e024dd-f7e3-3e43-3343-0fde1a1851d8
caps.latest.revision: 11
author: "shirhatti"
manager: "wpickett"
---
# IAppHostElement Interface
Represents a single element in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
interface IAppHostElement : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostElement` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[Clear](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-clear-method.md)|Removes all elements from the configuration system.|  
|[GetElementByName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-getelementbyname-method.md)|Gets a requested child element from the current element.|  
|[GetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-getmetadata-method.md)|Gets metadata values from the current element.|  
|[GetPropertyByName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-getpropertybyname-method.md)|Gets a requested property from the [IAppHostElement::Properties](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-properties-property.md) collection.|  
|[SetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-setmetadata-method.md)|Sets metadata for the current element.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostElement` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[ChildElements](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-childelements-property.md)|Represents a collection of child elements that are nested under the current [IAppHostElement](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) interface.|  
|[Collection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-collection-property.md)|Represents a collection of elements that belongs to a collection.|  
|[Name](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-name-property.md)|Gets the name of the current element.|  
|[Properties](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-properties-property.md)|Gets the collection of properties that are defined for the current element.|  
|[Schema](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-schema-property.md)|Gets the schema that is assigned to the current element.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [IAppHostProperty Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostproperty-interface.md)