---
title: "IHttpCachePolicy2 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 873a0b2a-1dc8-482d-9adc-f407645ba6db
caps.latest.revision: 8
author: "shirhatti"
manager: "wpickett"
---
# IHttpCachePolicy2 Interface
Provides [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) derived classes access to the setting and getting policy for request caching.  
  
## Syntax  
  
```cpp  
class IHttpCachePolicy2  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpCachePolicy2` class.  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpCachePolicy2::SetForceUpdate Method](../../web-development-reference\native-code-api-reference/ihttpcachepolicy2-setforceupdate-method.md)|Sets a value that indicates that the cache should be updated for a specific request or request variation.|  
|[IHttpCachePolicy2::IsForceUpdateSet Method](../../web-development-reference\native-code-api-reference/ihttpcachepolicy2-isforceupdateset-method.md)|Gets a value that determines if the force update flag has been set.|  
  
## Derived Classes  
 This class contains no derived classes.  
  
## Remarks  
 [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md) pointer as a parameter on the corresponding `virtual` method.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)