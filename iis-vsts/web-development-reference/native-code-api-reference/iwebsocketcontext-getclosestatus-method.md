---
title: "IWebSocketContext::GetCloseStatus Method"
ms.date: "10/07/2016"
ms.assetid: f5db45c5-a53b-4299-9802-c87e3a58b068
---
# IWebSocketContext::GetCloseStatus Method
Retrieves the close status code for the connection.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetCloseStatus(  
   _Out_ USHORT* pStatusCode,  
   _Out_ BYTE** ppbReason = NULL,  
   _Out_ USHORT* pcbReason = NULL  
) = 0;  
```  
  
### Parameters  
 `pStatusCode`  
 [OUT] Points to the close status code provided by the server.  
  
 `ppbReason`  
 [OUT] Points to the start of the reason text string.  
  
 `pcbReason`  
 [OUT] Number of bytes in the reason text string.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Iiswebsocket.h|  
  
## See Also  
 [IWebSocketContext Interface](../../web-development-reference\native-code-api-reference/iwebsocketcontext-interface.md)