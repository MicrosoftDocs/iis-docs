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
Maintains a collection of [IHttpStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-interface.md) pointers.  
  
## Syntax  
  
```cpp  
class IHttpModuleContextContainer  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpModuleContextContainer` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetModuleContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-getmodulecontext-method.md)|Returns the stored context from the context container.|  
|[SetModuleContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md)|Sets the stored context on the context container.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IDispensedHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/idispensedhttpmodulecontextcontainer-interface.md)|Extends `IHttpModuleContextContainer` by providing functionality for releasing a container.|  
  
## Remarks  
 Many [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] classes maintain a `private` `IDispensedHttpModuleContextContainer` pointer as a member variable. These classes implement various interfaces, including [IHttpApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-interface.md), [IHttpConnection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpconnection-interface.md), [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md), [IHttpFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md), [IHttpSite](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-interface.md), [IHttpUrlInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpurlinfo-interface.md), and [IMetadataInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imetadatainfo-interface.md).  
  
 Each of these interfaces defines a `GetModuleContextContainer` method, which accepts no arguments and returns an `IHttpModuleContextContainer` pointer. When the various `GetModuleContextContainer` methods are called, most of these implementers return the `private` data as an upcast `IHttpModuleContextContainer`. This allows the interface implementers to expose custom containers while maintaining the lifetime of those containers.  
  
 You can define custom classes that implement the `IHttpStoredContext` interface and then create a pointer to this `IHttpStoredContext` class implementer by calling the `new` operator. You can then add and retrieve this pointer on an `IHttpModuleContextContainer` pointer by calling the [SetModuleContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md) and [GetModuleContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-getmodulecontext-method.md) methods, respectively.  
  
 When the `IHttpStoredContext` pointer is no longer needed, the [IHttpStoredContext::CleanupStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md) method is called internally, where the implementer of the `IHttpStoredContext` interface method should usually call `delete``this`.  
  
> [!CAUTION]
>  While it may be a safe operation to downcast an `IHttpModuleContextContainer` to an `IDispensedHttpModuleContextContainer` by using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator, you should avoid performing this cast. The `IDispensedHttpModuleContextContainer` interface adds only one method, `ReleaseContainer`, to its base interface, and this method should be called only internally.  
  
## Notes for Callers  
 In some cases, an `IHttpModuleContextContainer` pointer may be downcast to an `IDispensedHttpModuleContextContainer` interface to access extended behavior.  
  
> [!CAUTION]
>  Before performing any downcast operation, always verify that the cast is correct to guarantee correct program behavior.  
  
> [!NOTE]
>  Consider using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible when you perform a downcast operation.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes custom [IHttpStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-interface.md) information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
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
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 `IHttpModuleContextContainer`  
  
 [IDispensedHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/idispensedhttpmodulecontextcontainer-interface.md)  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)