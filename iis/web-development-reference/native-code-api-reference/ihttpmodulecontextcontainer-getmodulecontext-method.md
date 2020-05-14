---
title: "IHttpModuleContextContainer::GetModuleContext Method"
ms.date: "10/07/2016"
ms.assetid: d0e75a04-da9d-3822-f2dd-5e931ed7a8e7
---
# IHttpModuleContextContainer::GetModuleContext Method
Returns the stored context from the context container.  
  
## Syntax  
  
```cpp  
virtual IHttpStoredContext* GetModuleContext(  
   IN HTTP_MODULE_ID moduleId  
) = 0;  
```  
  
### Parameters  
 `moduleId`  
 [IN] An `HTTP_MODULE_ID` pointer.  
  
> [!NOTE]
>  `HTTP_MODULE_ID` is a type definition of a `void` pointer.  
  
## Return Value  
 A pointer to an [IHttpStoredContext](../../web-development-reference/native-code-api-reference/ihttpstoredcontext-interface.md); otherwise, NULL.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) or [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) pointers register for various events defined in the Httpserv.h header file. For more information, see [Request-Processing Constants](../../web-development-reference/native-code-api-reference/request-processing-constants.md). Through any of these classes' `virtual` methods, you can retrieve [IHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-interface.md) pointers from various interfaces that implement a `GetModuleContextContainer` method.  
  
 You can define custom classes that implement the `IHttpStoredContext` interface and then create a pointer to this `IHttpStoredContext` class implementer by calling the `new` operator. You can then add and retrieve this pointer on an `IHttpModuleContextContainer` pointer by calling the [SetModuleContext](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md) and `GetModuleContext` methods, respectively.  
  
 When the `IHttpStoredContext` pointer is no longer needed, the [IHttpStoredContext::CleanupStoredContext](../../web-development-reference/native-code-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md) method is called internally, where the implementer of the `IHttpStoredContext` interface method should usually call `delete``this`.  
  
## Notes for Implementers  
 [IHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpModuleContextContainer` implementers that use dynamic memory allocation must release or call `delete` on the `IHttpStoredContext` pointer when it is no longer needed. If cleanup is necessary, you can call the [IHttpStoredContext::CleanupStoredContext](../../web-development-reference/native-code-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md) method.  
  
## Notes for Callers  
 `IHttpModuleContextContainer` implementers are responsible for memory management with this data; therefore, `IHttpModuleContextContainer` clients must not release or call `delete` on the returned `IHttpStoredContext` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then calls the `GetModuleContext` method to retrieve the `IHttpStoredContext` pointer.  
  
 [!code-cpp[IHttpModuleContextContainer#2](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpModuleContextContainer/cpp/GetModuleContext.cpp#2)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpModuleContextContainer Interface](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-interface.md)
 [IHttpModuleContextContainer::SetModuleContext Method](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md)
