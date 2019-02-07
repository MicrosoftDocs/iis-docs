---
title: "IWebSocketContext Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4456d878-e673-41a5-8f36-f2f48809105e
caps.latest.revision: 4
author: "shirhatti"
manager: "wpickett"
---
# IWebSocketContext Interface
Represents context support for bi-directional WebSocket communications over a single TCP socket.  
  
## Syntax  
  
```cpp  
class IWebSocketContext : public IHttpStoredContext  
```  
  
## Methods  
 The following table lists the methods exposed by the `IWebSocketContext` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[CancelOutstandingIO](../../web-development-reference\webdev-native-api-reference/iwebsocketcontext-canceloutstandingio-method.md)|Cancels all remaining input or output operations.|  
|[CloseTcpConnection](../../web-development-reference\webdev-native-api-reference/iwebsocketcontext-closetcpconnection-method.md)|Signals the close of the TCP connection. The connection will not shut down until both sides acknowledge the close.|  
|[GetCloseStatus](../../web-development-reference\webdev-native-api-reference/iwebsocketcontext-getclosestatus-method.md)|Retrieves the close status code for the connection.|  
|[ReadFragment](../../web-development-reference\webdev-native-api-reference/iwebsocketcontext-readfragment-method.md)|Reads a data fragment from an asynchronous connection.|  
|[SendConnectionClose](../../web-development-reference\webdev-native-api-reference/iwebsocketcontext-sendconnectionclose-method.md)|Signals the close of a WebSocket connection.|  
|[WriteFragment](../../web-development-reference\webdev-native-api-reference/iwebsocketcontext-writefragment-method.md)|Writes a data fragment to an asynchronous connection.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IHttpStoredContext](../../web-development-reference\webdev-native-api-reference/ihttpstoredcontext-interface.md)  
  
 `IWebSocketContext`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Iiswebsocket.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\webdev-native-api-reference/web-server-core-interfaces.md)