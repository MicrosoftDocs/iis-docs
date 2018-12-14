---
title: "IHttpConnection Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b4c860fc-5e1a-e3ce-ec6c-c1fdda229eed
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
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
|[AllocateMemory](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpconnection-allocatememory-method.md)|Allocates a specified amount of memory.|  
|[GetModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpconnection-getmodulecontextcontainer-method.md)|Returns the module context container for the connection.|  
|[IsConnected](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpconnection-isconnected-method.md)|Determines whether a Web client is still connected to the current request.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 HTTP modules can use the `IHttpConnection` interface to retrieve information related to the connection for the current context. For example, you can use the `IsConnected` method to determine whether a Web client has disconnected its session.  
  
 To retrieve an `IHttpConnection` interface, your module needs to call the [IHttpContext::GetConnection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getconnection-method.md) method.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)   
 [IHttpContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::GetConnection Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getconnection-method.md)