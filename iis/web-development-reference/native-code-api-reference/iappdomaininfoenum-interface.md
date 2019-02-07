---
title: "IAppDomainInfoEnum Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 518d5cde-6260-9f20-ae66-05cd38edcddd
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# IAppDomainInfoEnum Interface
Provides access to each application domain.  
  
## Syntax  
  
```cpp  
struct IAppDomainInfoEnum : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppDomainInfoEnum` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[Count](../../web-development-reference\webdev-native-api-reference/iappdomaininfoenum-count-method.md)|Retrieves the number of application domains.|  
|[GetData](../../web-development-reference\webdev-native-api-reference/iappdomaininfoenum-getdata-method.md)|Retrieves an [IAppDomainInfo](../../web-development-reference\webdev-native-api-reference/iappdomaininfo-interface.md) interface.|  
|[MoveNext](../../web-development-reference\webdev-native-api-reference/iappdomaininfoenum-movenext-method.md)|Moves to the next [IAppDomainInfo](../../web-development-reference\webdev-native-api-reference/iappdomaininfo-interface.md) interface.|  
|[Reset](../../web-development-reference\webdev-native-api-reference/iappdomaininfoenum-reset-method.md)|Initializes the `IAppDomainInfoEnum` interface.|  
  
## Properties  
 This interface contains no properties.  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 To access the first `IAppDomainInfo` interface you must call the methods in the following order:  
  
1.  `Reset`  
  
2.  `MoveNext`  
  
3.  `GetData`  
  
 To access subsequent `IAppDomainInfo` interfaces, call `MoveNext`. If the `pfMoreItems` parameter of `MoveNext` is nonzero, call `GetData` and repeat this sequence until `pfMoreItems` is 0.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppDomainInfoEnum`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Interfaces](../../web-development-reference\webdev-native-api-reference/windows-process-activation-service-interfaces.md)