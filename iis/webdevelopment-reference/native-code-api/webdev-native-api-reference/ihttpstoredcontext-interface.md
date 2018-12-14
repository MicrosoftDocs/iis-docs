---
title: "IHttpStoredContext Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 55e0ddf6-4df3-87c2-ad25-2aa1b903aa76
caps.latest.revision: 29
author: "shirhatti"
manager: "wpickett"
---
# IHttpStoredContext Interface
Defines context information for stored data.  
  
## Syntax  
  
```cpp  
class IHttpStoredContext  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpStoredContext` class.  
  
|Name|Description|  
|----------|-----------------|  
|[CleanupStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md)|Cleans up the stored context.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IWebSocketContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwebsocketcontext-interface.md)|Represents context support for bi-directional WebSocket communications over a single TCP socket.|  
  
## Remarks  
 Many [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] classes maintain a `private` [IDispensedHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/idispensedhttpmodulecontextcontainer-interface.md) pointer as a member variable. These classes implement various interfaces, including [IHttpApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-interface.md), [IHttpConnection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpconnection-interface.md), [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md), [IHttpFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md), [IHttpSite](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-interface.md), [IHttpUrlInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpurlinfo-interface.md), and [IMetadataInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imetadatainfo-interface.md).  
  
 Each of these interfaces defines a `GetModuleContextContainer` method, which accepts no arguments and returns an [IHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md) pointer. When the various `GetModuleContextContainer` methods are called, most of these implementers return the `private` data as an upcast `IHttpModuleContextContainer`. This allows the interface implementers to expose custom containers while maintaining the lifetime of those containers.  
  
 You can define custom classes that implement the `IHttpStoredContext` interface and then create a pointer to this `IHttpStoredContext` class implementer by calling the `new` operator. You can then add and retrieve this pointer on an `IHttpModuleContextContainer` pointer by calling the [IHttpModuleContextContainer::SetModuleContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md) and [IHttpModuleContextContainer::GetModuleContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-getmodulecontext-method.md) methods, respectively.  
  
 When the `IHttpStoredContext` pointer is no longer needed, the `CleanupStoredContext` method is called internally, where the implementer of the `IHttpStoredContext` interface method should usually call `delete``this`.  
  
> [!CAUTION]
>  While it may be a safe operation to downcast an `IHttpModuleContextContainer` to an `IDispensedHttpModuleContextContainer` by using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator, you should avoid performing this cast. The `IDispensedHttpModuleContextContainer` interface adds only one method, [ReleaseContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/idispensedhttpmodulecontextcontainer-releasecontainer-method.md), to its base interface, and this method should be called only internally.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)