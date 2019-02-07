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
|[GetId](../../web-development-reference\webdev-native-api-reference/iappdomaininfo-getid-method.md)|Retrieves the application domain ID.|  
|[GetIsIdle](../../web-development-reference\webdev-native-api-reference/iappdomaininfo-getisidle-method.md)|Retrieves the idle state of the application domain.|  
|[GetPhysicalPath](../../web-development-reference\webdev-native-api-reference/iappdomaininfo-getphysicalpath-method.md)|Retrieves the physical path of the application domain.|  
|[GetSiteId](../../web-development-reference\webdev-native-api-reference/iappdomaininfo-getsiteid-method.md)|Retrieves the site ID of the application domain.|  
|[GetVirtualPath](../../web-development-reference\webdev-native-api-reference/iappdomaininfo-getvirtualpath-method.md)|Retrieves the root virtual path of the application domain.|  
  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Interfaces](../../web-development-reference\webdev-native-api-reference/windows-process-activation-service-interfaces.md)