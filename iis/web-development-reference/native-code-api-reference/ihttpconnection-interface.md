---
title: "IHttpConnection Interface"
ms.date: "10/07/2016"
ms.assetid: b4c860fc-5e1a-e3ce-ec6c-c1fdda229eed
---
# IHttpConnection Interface

Provides an interface for connection-specific information.  
  
## Syntax  
  
```cpp  
class IHttpConnection  
```  
  
## Methods  

 The following table lists the methods exposed by the `IHttpConnection` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[AllocateMemory](../../web-development-reference/native-code-api-reference/ihttpconnection-allocatememory-method.md)|Allocates a specified amount of memory.|  
|[GetModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpconnection-getmodulecontextcontainer-method.md)|Returns the module context container for the connection.|  
|[IsConnected](../../web-development-reference/native-code-api-reference/ihttpconnection-isconnected-method.md)|Determines whether a Web client is still connected to the current request.|  
  
## Derived Classes  

 This interface contains no derived classes.  
  
## Remarks  

 HTTP modules can use the `IHttpConnection` interface to retrieve information related to the connection for the current context. For example, you can use the `IsConnected` method to determine whether a Web client has disconnected its session.  
  
 To retrieve an `IHttpConnection` interface, your module needs to call the [IHttpContext::GetConnection](../../web-development-reference/native-code-api-reference/ihttpcontext-getconnection-method.md) method.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::GetConnection Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getconnection-method.md)
