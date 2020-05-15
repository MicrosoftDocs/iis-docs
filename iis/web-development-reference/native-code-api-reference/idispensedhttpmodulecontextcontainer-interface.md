---
title: "IDispensedHttpModuleContextContainer Interface"
ms.date: "10/07/2016"
ms.assetid: 8a58dbe1-8832-9da9-5733-2a9ff2f22962
---
# IDispensedHttpModuleContextContainer Interface

Extends the [IHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-interface.md) interface by providing functionality for releasing a container.  
  
## Syntax  
  
```cpp  
class IDispensedHttpModuleContextContainer : public IHttpModuleContextContainer  
```  
  
## Methods  

 The following table lists the methods exposed by the `IDispensedHttpModuleContextContainer` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetModuleContext](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-getmodulecontext-method.md)|(Inherited from [IHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-interface.md).)|  
|[ReleaseContainer](../../web-development-reference/native-code-api-reference/idispensedhttpmodulecontextcontainer-releasecontainer-method.md)|Deletes the context container if it is dispensed.|  
|[SetModuleContext](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md)|(Inherited from `IHttpModuleContextContainer`.)|  
  
## Derived Classes  

 This class contains no derived classes.  
  
## Remarks  

 Many [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] classes maintain a `private` `IDispensedHttpModuleContextContainer` pointer as a member variable. These classes implement various interfaces, including [IHttpApplication](../../web-development-reference/native-code-api-reference/ihttpapplication-interface.md), [IHttpConnection](../../web-development-reference/native-code-api-reference/ihttpconnection-interface.md), [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md), [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md), [IHttpSite](../../web-development-reference/native-code-api-reference/ihttpsite-interface.md), [IHttpUrlInfo](../../web-development-reference/native-code-api-reference/ihttpurlinfo-interface.md), and [IMetadataInfo](../../web-development-reference/native-code-api-reference/imetadatainfo-interface.md).  
  
 Each of these interfaces defines a `GetModuleContextContainer` method, which accepts no arguments and returns an `IHttpModuleContextContainer` pointer. When the various `GetModuleContextContainer` methods are called, most of these implementers return the `private` data as an upcast `IHttpModuleContextContainer`. This allows the interface implementers to expose custom containers while maintaining the lifetime of those containers.  
  
> [!CAUTION]
>  While it may be a safe operation to downcast an `IHttpModuleContextContainer` to an `IDispensedHttpModuleContextContainer` by using the [dynamic_cast](https://go.microsoft.com/fwlink/?LinkId=57556) operator, you should avoid performing this cast. The `IDispensedHttpModuleContextContainer` interface adds only one method, `ReleaseContainer`, to its base interface, and this method should be called only internally.  
  
## Inheritance Hierarchy  

 [IHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-interface.md)  
  
 `IDispensedHttpModuleContextContainer`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
