---
title: "IAppHostConfigLocationCollection Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 47442932-c536-9753-0146-fab1c2973ff6
caps.latest.revision: 9
author: "shirhatti"
manager: "wpickett"
---
# IAppHostConfigLocationCollection Interface
Provides access to a collection of configuration locations in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
interface IAppHostConfigLocationCollection : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostConfigLocationCollection` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[AddLocation](../../web-development-reference\webdev-native-api-reference/iapphostconfiglocationcollection-addlocation-method.md)|Adds a new configuration location to the collection.|  
|[DeleteLocation](../../web-development-reference\webdev-native-api-reference/iapphostconfiglocationcollection-deletelocation-method.md)|Removes a configuration location from the collection.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostConfigLocationCollection` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Count](../../web-development-reference\webdev-native-api-reference/iapphostconfiglocationcollection-count-property.md)|Gets the number of configuration locations in the collection.|  
|[Item](../../web-development-reference\webdev-native-api-reference/iapphostconfiglocationcollection-item-property.md)|Gets a configuration location at the requested index from the current collection.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostConfigLocationCollection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [Application Host Administration API Reference](../../web-development-reference\webdev-native-api-reference/application-host-administration-api-reference.md)