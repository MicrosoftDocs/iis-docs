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
|[CancelOutstandingIO](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwebsocketcontext-canceloutstandingio-method.md)|Cancels all remaining input or output operations.|  
|[CloseTcpConnection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwebsocketcontext-closetcpconnection-method.md)|Signals the close of the TCP connection. The connection will not shut down until both sides acknowledge the close.|  
|[GetCloseStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwebsocketcontext-getclosestatus-method.md)|Retrieves the close status code for the connection.|  
|[ReadFragment](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwebsocketcontext-readfragment-method.md)|Reads a data fragment from an asynchronous connection.|  
|[SendConnectionClose](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwebsocketcontext-sendconnectionclose-method.md)|Signals the close of a WebSocket connection.|  
|[WriteFragment](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwebsocketcontext-writefragment-method.md)|Writes a data fragment to an asynchronous connection.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IHttpStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-interface.md)  
  
 `IWebSocketContext`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Iiswebsocket.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)