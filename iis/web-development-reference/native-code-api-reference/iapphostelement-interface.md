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
Represents a single element in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
interface IAppHostElement : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostElement` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[Clear](../../web-development-reference\native-code-api-reference/iapphostelement-clear-method.md)|Removes all elements from the configuration system.|  
|[GetElementByName](../../web-development-reference\native-code-api-reference/iapphostelement-getelementbyname-method.md)|Gets a requested child element from the current element.|  
|[GetMetadata](../../web-development-reference\native-code-api-reference/iapphostelement-getmetadata-method.md)|Gets metadata values from the current element.|  
|[GetPropertyByName](../../web-development-reference\native-code-api-reference/iapphostelement-getpropertybyname-method.md)|Gets a requested property from the [IAppHostElement::Properties](../../web-development-reference\native-code-api-reference/iapphostelement-properties-property.md) collection.|  
|[SetMetadata](../../web-development-reference\native-code-api-reference/iapphostelement-setmetadata-method.md)|Sets metadata for the current element.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostElement` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[ChildElements](../../web-development-reference\native-code-api-reference/iapphostelement-childelements-property.md)|Represents a collection of child elements that are nested under the current [IAppHostElement](../../web-development-reference\native-code-api-reference/iapphostelement-interface.md) interface.|  
|[Collection](../../web-development-reference\native-code-api-reference/iapphostelement-collection-property.md)|Represents a collection of elements that belongs to a collection.|  
|[Name](../../web-development-reference\native-code-api-reference/iapphostelement-name-property.md)|Gets the name of the current element.|  
|[Properties](../../web-development-reference\native-code-api-reference/iapphostelement-properties-property.md)|Gets the collection of properties that are defined for the current element.|  
|[Schema](../../web-development-reference\native-code-api-reference/iapphostelement-schema-property.md)|Gets the schema that is assigned to the current element.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference\native-code-api-reference/application-host-administration-interfaces.md)   
 [IAppHostProperty Interface](../../web-development-reference\native-code-api-reference/iapphostproperty-interface.md)