---
title: "IAppDomainInfo Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c56ab96e-4307-6959-2276-7523527d96c2
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IAppDomainInfo Interface
Provides information about the application domain.  
  
## Syntax  
  
```cpp  
struct IAppDomainInfo : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppDomainInfo` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfo-getid-method.md)|Retrieves the application domain ID.|  
|[GetIsIdle](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfo-getisidle-method.md)|Retrieves the idle state of the application domain.|  
|[GetPhysicalPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfo-getphysicalpath-method.md)|Retrieves the physical path of the application domain.|  
|[GetSiteId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfo-getsiteid-method.md)|Retrieves the site ID of the application domain.|  
|[GetVirtualPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iappdomaininfo-getvirtualpath-method.md)|Retrieves the root virtual path of the application domain.|  
  
## Properties  
 This interface contains no properties.  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppDomainInfo`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/windows-process-activation-service-interfaces.md)