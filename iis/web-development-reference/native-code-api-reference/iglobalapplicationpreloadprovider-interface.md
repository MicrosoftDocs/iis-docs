---
title: "IGlobalApplicationPreloadProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: deddc775-1ab0-492c-bda0-b32be5d4f4cc
caps.latest.revision: 7
author: "shirhatti"
manager: "wpickett"
---
# IGlobalApplicationPreloadProvider Interface
Provides a global-level interface for preloading an application into server memory.  
  
## Syntax  
  
```cpp  
IGlobalApplicationPreloadProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IGlobalApplicationPreloadProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[CreateContext](../../web-development-reference\native-code-api-reference/iglobalapplicationpreloadprovider-createcontext-method.md)|Creates an HTTP context and returns a pointer to the context object.|  
|[ExecuteRequest](../../web-development-reference\native-code-api-reference/iglobalapplicationpreloadprovider-executerequest-method.md)|Runs an HTTP request given its context and user information.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IGlobalApplicationPreloadProvider2](../../web-development-reference\native-code-api-reference/iglobalapplicationpreloadprovider2-interface.md)|Provides information about whether an application’s worker process is recycled.|  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference\native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IGlobalApplicationPreloadProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)