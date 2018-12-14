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
|[Count](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfoenum-count-method.md)|Retrieves the number of application domains.|  
|[GetData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfoenum-getdata-method.md)|Retrieves an [IAppDomainInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfo-interface.md) interface.|  
|[MoveNext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfoenum-movenext-method.md)|Moves to the next [IAppDomainInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfo-interface.md) interface.|  
|[Reset](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfoenum-reset-method.md)|Initializes the `IAppDomainInfoEnum` interface.|  
  
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
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/windows-process-activation-service-interfaces.md)