---
title: "IHttpRequest3 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 2c2d3051-2747-4f8b-8c64-504b417b041c
caps.latest.revision: 5
author: "shirhatti"
manager: "wpickett"
---
# IHttpRequest3 Interface
Provides an interface for reading the request results into a buffer.  
  
## Syntax  
  
```cpp  
class IHttpRequest3 : public IHttpRequest2  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpRequest3` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[ReadEntityBody](../../web-development-reference\webdev-native-api-reference/ihttprequest3-readentitybody-method.md)|Reads the request results into a specified buffer.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IHttpRequest](../../web-development-reference\webdev-native-api-reference/ihttprequest-interface.md)  
  
 [IHttpRequest2](../../web-development-reference\webdev-native-api-reference/ihttprequest2-interface.md)  
  
 `IHttpRequest3`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\webdev-native-api-reference/web-server-core-interfaces.md)