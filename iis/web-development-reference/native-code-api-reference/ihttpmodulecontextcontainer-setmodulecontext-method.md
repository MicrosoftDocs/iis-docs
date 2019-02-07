---
title: "IHttpModuleContextContainer::SetModuleContext Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b6c08c35-90c0-c5b4-c59c-2a280b6f00d9
caps.latest.revision: 24
author: "shirhatti"
manager: "wpickett"
---
# IHttpModuleContextContainer::SetModuleContext Method
Sets the stored context on the context container.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetModuleContext(  
   IN IHttpStoredContext* ppStoredContext,  
   IN HTTP_MODULE_ID moduleId  
) = 0;  
```  
  
#### Parameters  
 `ppStoredContext`  
 [IN] A pointer to an [IHttpStoredContext](../../web-development-reference\native-code-api-reference/ihttpstoredcontext-interface.md) value. Must be non-NULL.  
  
 `moduleId`  
 [IN] An `HTTP_MODULE_ID` pointer.  
  
> [!NOTE]
>  `HTTP_MODULE_ID` is a type definition of a `void` pointer.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|NO_ERROR|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that `ppStoredContext` is NULL.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that heap memory is exhausted.|  
|ERROR_ALREADY_ASSIGNED|Indicates that `SetModuleContext` has been called previously.|  
  
## Remarks  
 [CGlobalModule](../../web-development-reference\native-code-api-reference/cglobalmodule-class.md) or [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) pointers register for various events defined in the Httpserv.h header file. For more information, see [Request-Processing Constants](../../web-development-reference\native-code-api-reference/request-processing-constants.md). Through any of these classes' `virtual` methods, you can retrieve [IHttpModuleContextContainer](../../web-development-reference\native-code-api-reference/ihttpmodulecontextcontainer-interface.md) pointers from various interfaces that implement a `GetModuleContextContainer` method.  
  
 You can define custom classes that implement the `IHttpStoredContext` interface and then create a pointer to this `IHttpStoredContext` class implementer by calling the `new` operator. You can then add and retrieve this pointer on an `IHttpModuleContextContainer` pointer by calling the `SetModuleContext` and [GetModuleContext](../../web-development-reference\native-code-api-reference/ihttpmodulecontextcontainer-getmodulecontext-method.md) methods, respectively.  
  
 When the `IHttpStoredContext` pointer is no longer needed, the [IHttpStoredContext::CleanupStoredContext](../../web-development-reference\native-code-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md) method is called internally, where the implementer of the `IHttpStoredContext` interface method should usually call `delete``this`.  
  
## Notes for Implementers  
 [IHttpModuleContextContainer](../../web-development-reference\native-code-api-reference/ihttpmodulecontextcontainer-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpModuleContextContainer` implementers that use dynamic memory allocation must release or call `delete` on the `IHttpStoredContext` pointer when it is no longer needed. If cleanup is necessary, you can call the [IHttpStoredContext::CleanupStoredContext](../../web-development-reference\native-code-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md) method.  
  
## Notes for Callers  
 `IHttpModuleContextContainer` implementers are responsible for memory management with this data; therefore, `IHttpModuleContextContainer` clients must not release or call `delete` on the returned `IHttpStoredContext` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../web-development-reference\native-code-api-reference/request-processing-constants.md) events and then writes custom [IHttpStoredContext](../../web-development-reference\native-code-api-reference/ihttpstoredcontext-interface.md) information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpModuleContextContainer#3](IHttpModuleContextContainer#3)]  -->  
  
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
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpModuleContextContainer Interface](../../web-development-reference\native-code-api-reference/ihttpmodulecontextcontainer-interface.md)