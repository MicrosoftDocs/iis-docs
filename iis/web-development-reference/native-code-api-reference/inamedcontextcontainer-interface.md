---
title: "INamedContextContainer Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c3e298de-4f26-4766-86cd-5d70e1346acd
caps.latest.revision: 5
author: "shirhatti"
manager: "wpickett"
---
# INamedContextContainer Interface
Provides an interface for binding and retrieving a named context.  
  
## Syntax  
  
```cpp  
class INamedContextContainer  
```  
  
## Methods  
 The following table lists the methods exposed by the `INamedContextContainer` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetNamedContext](../../web-development-reference\webdev-native-api-reference/inamedcontextcontainer-getnamedcontext-method.md)|Retrieves a stored context given its name.|  
|[SetNamedContext](../../web-development-reference\webdev-native-api-reference/inamedcontextcontainer-setnamedcontext.md)|Binds stored context with a specified name.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\webdev-native-api-reference/web-server-core-interfaces.md)