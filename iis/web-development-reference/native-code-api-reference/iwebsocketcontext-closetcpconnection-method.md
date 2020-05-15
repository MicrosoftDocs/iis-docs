---
title: "IWebSocketContext::CloseTcpConnection Method"
ms.date: "10/07/2016"
ms.assetid: 6361b595-0d6d-436c-a67d-d5a8f98d5b46
---
# IWebSocketContext::CloseTcpConnection Method

Signals the close of the TCP connection. The connection will not shut down until both sides acknowledge the close.  
  
## Syntax  
  
```cpp  
virtual VOID CloseTcpConnection(  
   VOID  
) = 0;  
```  
  
### Parameters  

 This method takes no parameters.  
  
## Return Value  

 This method does not return a value.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Iiswebsocket.h|  
  
## See Also  

 [IWebSocketContext Interface](../../web-development-reference/native-code-api-reference/iwebsocketcontext-interface.md)
