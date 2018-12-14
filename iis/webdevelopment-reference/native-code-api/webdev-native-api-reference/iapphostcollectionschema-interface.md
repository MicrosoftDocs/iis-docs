---
title: "IAppHostCollectionSchema Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4f0fe5e3-1283-6da8-ba92-a0d6a330838b
caps.latest.revision: 10
author: "shirhatti"
manager: "wpickett"
---
# IAppHostCollectionSchema Interface
Represents a schema for a collection in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
interface IAppHostCollectionSchema : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostCollectionSchema` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetAddElementSchema](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostcollectionschema-getaddelementschema-method.md)|Gets the schema for the `add` element that has the requested name.|  
|[GetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostcollectionschema-getmetadata-method.md)|Gets metadata from the collection schema.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostCollectionSchema` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[AddElementNames](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostcollectionschema-addelementnames-property.md)|Gets a comma-delimited list of `add` element names that are valid for the collection.|  
|[ClearElementSchema](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostcollectionschema-clearelementschema-property.md)|Gets the schema for the element that will be used to clear all items from the collection.|  
|[DoesAllowDuplicates](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostcollectionschema-doesallowduplicates-property.md)|Gets a Boolean value that determines whether a collection that implements the current schema allows for duplicate keys.|  
|[IsMergeAppend](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostcollectionschema-ismergeappend-property.md)|Gets a value that determines whether local collection elements are merged after inherited elements are added.|  
|[RemoveElementSchema](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostcollectionschema-removeelementschema-property.md)|Gets the schema for the element that will be used to remove an item from the collection.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostCollectionSchema`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-api-reference.md)