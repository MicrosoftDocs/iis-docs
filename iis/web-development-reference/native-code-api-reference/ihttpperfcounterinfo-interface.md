---
title: "IHttpPerfCounterInfo Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3ca70926-30f4-ebc5-2148-a3b8d0a6cbbe
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IHttpPerfCounterInfo Interface
Provides an interface for incrementing and decrementing performance counters.  
  
## Syntax  
  
```cpp  
class IHttpPerfCounterInfo  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpPerfCounterInfo` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[DecrementCounter](../../web-development-reference\native-code-api-reference/ihttpperfcounterinfo-decrementcounter-method.md)|Decrements a performance counter by a specified amount.|  
|[IncrementCounter](../../web-development-reference\native-code-api-reference/ihttpperfcounterinfo-incrementcounter-method.md)|Increments a performance counter by a specified amount.|  
  
## Remarks  
 Calling the [IHttpServer::GetPerfCounterInfo](../../web-development-reference\native-code-api-reference/ihttpserver-getperfcounterinfo-method.md) and [IHttpSite::GetPerfCounterInfo](../../web-development-reference\native-code-api-reference/ihttpsite-getperfcounterinfo-method.md) methods will return, respectively, a server-level or site-level `IHttpPerfCounterInfo` interface, which is used to modify the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] performance counters.  
  
> [!IMPORTANT]
>  This interface is part of the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] infrastructure and is not intended to be used directly from your code.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)   
 [IHttpServer::GetPerfCounterInfo Method](../../web-development-reference\native-code-api-reference/ihttpserver-getperfcounterinfo-method.md)   
 [IHttpSite::GetPerfCounterInfo Method](../../web-development-reference\native-code-api-reference/ihttpsite-getperfcounterinfo-method.md)