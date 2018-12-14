---
title: "IDispensedHttpModuleContextContainer Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8a58dbe1-8832-9da9-5733-2a9ff2f22962
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# IDispensedHttpModuleContextContainer Interface
Extends the [IHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md) interface by providing functionality for releasing a container.  
  
## Syntax  
  
```cpp  
class IDispensedHttpModuleContextContainer : public IHttpModuleContextContainer  
```  
  
## Methods  
 The following table lists the methods exposed by the `IDispensedHttpModuleContextContainer` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetModuleContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-getmodulecontext-method.md)|(Inherited from [IHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md).)|  
|[ReleaseContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/idispensedhttpmodulecontextcontainer-releasecontainer-method.md)|Deletes the context container if it is dispensed.|  
|[SetModuleContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md)|(Inherited from `IHttpModuleContextContainer`.)|  
  
## Derived Classes  
 This class contains no derived classes.  
  
## Remarks  
 Many [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] classes maintain a `private` `IDispensedHttpModuleContextContainer` pointer as a member variable. These classes implement various interfaces, including [IHttpApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-interface.md), [IHttpConnection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpconnection-interface.md), [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md), [IHttpFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md), [IHttpSite](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-interface.md), [IHttpUrlInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpurlinfo-interface.md), and [IMetadataInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imetadatainfo-interface.md).  
  
 Each of these interfaces defines a `GetModuleContextContainer` method, which accepts no arguments and returns an `IHttpModuleContextContainer` pointer. When the various `GetModuleContextContainer` methods are called, most of these implementers return the `private` data as an upcast `IHttpModuleContextContainer`. This allows the interface implementers to expose custom containers while maintaining the lifetime of those containers.  
  
> [!CAUTION]
>  While it may be a safe operation to downcast an `IHttpModuleContextContainer` to an `IDispensedHttpModuleContextContainer` by using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator, you should avoid performing this cast. The `IDispensedHttpModuleContextContainer` interface adds only one method, `ReleaseContainer`, to its base interface, and this method should be called only internally.  
  
## Inheritance Hierarchy  
 [IHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md)  
  
 `IDispensedHttpModuleContextContainer`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)