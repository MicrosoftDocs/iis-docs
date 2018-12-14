---
title: "IAppHostElementCollection Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 93b238c5-ad20-6322-59c6-6d61b1b120bc
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
---
# IAppHostElementCollection Interface
Represents a collection of [IAppHostElement](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) interfaces.  
  
## Syntax  
  
```cpp  
interface IAppHostElementCollection : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostElementCollection` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[AddElement](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementcollection-addelement-method.md)|Adds an element to the current collection.|  
|[Clear](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementcollection-clear-method.md)|Removes all elements from the current collection.|  
|[CreateNewElement](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementcollection-createnewelement-method.md)|Creates a new element.|  
|[DeleteElement](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementcollection-deleteelement-method.md)|Removes the requested element from the collection|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostElementCollection` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Count](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementcollection-count-property.md)|Returns the number of elements in the current collection|  
|[Item](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementcollection-item-property.md)|Gets the element at the requested index in the current collection.|  
|[Schema](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementcollection-schema-property.md)|Returns the schema assigned to the current collection|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostElementCollection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [IAppHostElement Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md)