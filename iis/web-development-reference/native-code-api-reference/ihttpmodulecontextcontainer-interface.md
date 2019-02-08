---
title: "IHttpModuleContextContainer Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9e80529b-fc32-c845-5d31-6feac3d7034b
caps.latest.revision: 32
author: "shirhatti"
manager: "wpickett"
---
# IHttpModuleContextContainer Interface
Maintains a collection of [IHttpStoredContext](../../web-development-reference\native-code-api-reference/ihttpstoredcontext-interface.md) pointers.  
  
## Syntax  
  
```cpp  
class IHttpModuleContextContainer  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpModuleContextContainer` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetModuleContext](../../web-development-reference\native-code-api-reference/ihttpmodulecontextcontainer-getmodulecontext-method.md)|Returns the stored context from the context container.|  
|[SetModuleContext](../../web-development-reference\native-code-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md)|Sets the stored context on the context container.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IDispensedHttpModuleContextContainer](../../web-development-reference\native-code-api-reference/idispensedhttpmodulecontextcontainer-interface.md)|Extends `IHttpModuleContextContainer` by providing functionality for releasing a container.|  
  
## Remarks  
 Many [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] classes maintain a `private` `IDispensedHttpModuleContextContainer` pointer as a member variable. These classes implement various interfaces, including [IHttpApplication](../../web-development-reference\native-code-api-reference/ihttpapplication-interface.md), [IHttpConnection](../../web-development-reference\native-code-api-reference/ihttpconnection-interface.md), [IHttpContext](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md), [IHttpFileInfo](../../web-development-reference\native-code-api-reference/ihttpfileinfo-interface.md), [IHttpSite](../../web-development-reference\native-code-api-reference/ihttpsite-interface.md), [IHttpUrlInfo](../../web-development-reference\native-code-api-reference/ihttpurlinfo-interface.md), and [IMetadataInfo](../../web-development-reference\native-code-api-reference/imetadatainfo-interface.md).  
  
 Each of these interfaces defines a `GetModuleContextContainer` method, which accepts no arguments and returns an `IHttpModuleContextContainer` pointer. When the various `GetModuleContextContainer` methods are called, most of these implementers return the `private` data as an upcast `IHttpModuleContextContainer`. This allows the interface implementers to expose custom containers while maintaining the lifetime of those containers.  
  
 You can define custom classes that implement the `IHttpStoredContext` interface and then create a pointer to this `IHttpStoredContext` class implementer by calling the `new` operator. You can then add and retrieve this pointer on an `IHttpModuleContextContainer` pointer by calling the [SetModuleContext](../../web-development-reference\native-code-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md) and [GetModuleContext](../../web-development-reference\native-code-api-reference/ihttpmodulecontextcontainer-getmodulecontext-method.md) methods, respectively.  
  
 When the `IHttpStoredContext` pointer is no longer needed, the [IHttpStoredContext::CleanupStoredContext](../../web-development-reference\native-code-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md) method is called internally, where the implementer of the `IHttpStoredContext` interface method should usually call `delete``this`.  
  
> [!CAUTION]
>  While it may be a safe operation to downcast an `IHttpModuleContextContainer` to an `IDispensedHttpModuleContextContainer` by using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator, you should avoid performing this cast. The `IDispensedHttpModuleContextContainer` interface adds only one method, `ReleaseContainer`, to its base interface, and this method should be called only internally.  
  
## Notes for Callers  
 In some cases, an `IHttpModuleContextContainer` pointer may be downcast to an `IDispensedHttpModuleContextContainer` interface to access extended behavior.  
  
> [!CAUTION]
>  Before performing any downcast operation, always verify that the cast is correct to guarantee correct program behavior.  
  
> [!NOTE]
>  Consider using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible when you perform a downcast operation.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../web-development-reference\native-code-api-reference/request-processing-constants.md) events and then writes custom [IHttpStoredContext](../../web-development-reference\native-code-api-reference/ihttpstoredcontext-interface.md) information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpModuleContextContainer#1](IHttpModuleContextContainer#1)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains consecutive strings similar to the following.  
  
```  
CStoredContext::Destructor  
```  
  
```  
CStoredContext::CleanupStoredContext  
```  
  
```  
CStoredContext::Display  
```  
  
```  
CStoredContext::Constructor  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 `IHttpModuleContextContainer`  
  
 [IDispensedHttpModuleContextContainer](../../web-development-reference\native-code-api-reference/idispensedhttpmodulecontextcontainer-interface.md)  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)