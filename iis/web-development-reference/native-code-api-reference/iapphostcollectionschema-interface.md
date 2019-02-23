---
title: "IAppHostCollectionSchema Interface"
ms.date: "10/07/2016"
ms.assetid: 4f0fe5e3-1283-6da8-ba92-a0d6a330838b
---
# IAppHostCollectionSchema Interface
Represents a schema for a collection in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
interface IAppHostCollectionSchema : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostCollectionSchema` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetAddElementSchema](../../web-development-reference\native-code-api-reference/iapphostcollectionschema-getaddelementschema-method.md)|Gets the schema for the `add` element that has the requested name.|  
|[GetMetadata](../../web-development-reference\native-code-api-reference/iapphostcollectionschema-getmetadata-method.md)|Gets metadata from the collection schema.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostCollectionSchema` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[AddElementNames](../../web-development-reference\native-code-api-reference/iapphostcollectionschema-addelementnames-property.md)|Gets a comma-delimited list of `add` element names that are valid for the collection.|  
|[ClearElementSchema](../../web-development-reference\native-code-api-reference/iapphostcollectionschema-clearelementschema-property.md)|Gets the schema for the element that will be used to clear all items from the collection.|  
|[DoesAllowDuplicates](../../web-development-reference\native-code-api-reference/iapphostcollectionschema-doesallowduplicates-property.md)|Gets a Boolean value that determines whether a collection that implements the current schema allows for duplicate keys.|  
|[IsMergeAppend](../../web-development-reference\native-code-api-reference/iapphostcollectionschema-ismergeappend-property.md)|Gets a value that determines whether local collection elements are merged after inherited elements are added.|  
|[RemoveElementSchema](../../web-development-reference\native-code-api-reference/iapphostcollectionschema-removeelementschema-property.md)|Gets the schema for the element that will be used to remove an item from the collection.|  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostCollectionSchema`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration API Reference](../../web-development-reference\native-code-api-reference/application-host-administration-api-reference.md)