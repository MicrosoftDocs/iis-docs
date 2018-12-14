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
 [IN] A pointer to an [IHttpStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-interface.md) value. Must be non-NULL.  
  
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
 [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) or [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) pointers register for various events defined in the Httpserv.h header file. For more information, see [Request-Processing Constants](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md). Through any of these classes' `virtual` methods, you can retrieve [IHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md) pointers from various interfaces that implement a `GetModuleContextContainer` method.  
  
 You can define custom classes that implement the `IHttpStoredContext` interface and then create a pointer to this `IHttpStoredContext` class implementer by calling the `new` operator. You can then add and retrieve this pointer on an `IHttpModuleContextContainer` pointer by calling the `SetModuleContext` and [GetModuleContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-getmodulecontext-method.md) methods, respectively.  
  
 When the `IHttpStoredContext` pointer is no longer needed, the [IHttpStoredContext::CleanupStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md) method is called internally, where the implementer of the `IHttpStoredContext` interface method should usually call `delete``this`.  
  
## Notes for Implementers  
 [IHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpModuleContextContainer` implementers that use dynamic memory allocation must release or call `delete` on the `IHttpStoredContext` pointer when it is no longer needed. If cleanup is necessary, you can call the [IHttpStoredContext::CleanupStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md) method.  
  
## Notes for Callers  
 `IHttpModuleContextContainer` implementers are responsible for memory management with this data; therefore, `IHttpModuleContextContainer` clients must not release or call `delete` on the returned `IHttpStoredContext` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes custom [IHttpStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-interface.md) information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
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
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpModuleContextContainer Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md)