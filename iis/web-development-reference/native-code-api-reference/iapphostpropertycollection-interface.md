---
title: "IAppHostPropertyCollection Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 573fc810-3903-77ba-7494-5e432686d459
caps.latest.revision: 14
author: "shirhatti"
manager: "wpickett"
---
# IAppHostPropertyCollection Interface
Represents a collection of properties.  
  
## Syntax  
  
```cpp  
interface IAppHostPropertyCollection : IUnknown  
```  
  
## Methods  
 This interface contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostPropertyCollection` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Count](../../web-development-reference\native-code-api-reference/iapphostpropertycollection-count-property.md)|Gets the number properties in the collection.|  
|[Item](../../web-development-reference\native-code-api-reference/iapphostpropertycollection-item-property.md)|Gets the property with the requested index or property name in the collection.|  
  
## Example  
 The following code example demonstrates how to use the `IAppHostPropertyCollection` interface to access the `enabled` property of the `defaultDocument` configuration section.  
  
<!-- TODO: review snippet reference  [!CODE [IAppHostAdminLibrary#5](IAppHostAdminLibrary#5)]  -->  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostPropertyCollection`  
  
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