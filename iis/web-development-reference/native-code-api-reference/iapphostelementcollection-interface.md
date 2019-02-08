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
Represents a collection of [IAppHostElement](../../web-development-reference\native-code-api-reference/iapphostelement-interface.md) interfaces.  
  
## Syntax  
  
```cpp  
interface IAppHostElementCollection : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostElementCollection` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[AddElement](../../web-development-reference\native-code-api-reference/iapphostelementcollection-addelement-method.md)|Adds an element to the current collection.|  
|[Clear](../../web-development-reference\native-code-api-reference/iapphostelementcollection-clear-method.md)|Removes all elements from the current collection.|  
|[CreateNewElement](../../web-development-reference\native-code-api-reference/iapphostelementcollection-createnewelement-method.md)|Creates a new element.|  
|[DeleteElement](../../web-development-reference\native-code-api-reference/iapphostelementcollection-deleteelement-method.md)|Removes the requested element from the collection|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostElementCollection` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Count](../../web-development-reference\native-code-api-reference/iapphostelementcollection-count-property.md)|Returns the number of elements in the current collection|  
|[Item](../../web-development-reference\native-code-api-reference/iapphostelementcollection-item-property.md)|Gets the element at the requested index in the current collection.|  
|[Schema](../../web-development-reference\native-code-api-reference/iapphostelementcollection-schema-property.md)|Returns the schema assigned to the current collection|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostElementCollection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference\native-code-api-reference/application-host-administration-interfaces.md)   
 [IAppHostElement Interface](../../web-development-reference\native-code-api-reference/iapphostelement-interface.md)