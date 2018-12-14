---
title: "IHttpModuleContextContainer::GetModuleContext Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d0e75a04-da9d-3822-f2dd-5e931ed7a8e7
caps.latest.revision: 29
author: "shirhatti"
manager: "wpickett"
---
# IHttpModuleContextContainer::GetModuleContext Method
Returns the stored context from the context container.  
  
## Syntax  
  
```cpp  
virtual IHttpStoredContext* GetModuleContext(  
   IN HTTP_MODULE_ID moduleId  
) = 0;  
```  
  
#### Parameters  
 `moduleId`  
 [IN] An `HTTP_MODULE_ID` pointer.  
  
> [!NOTE]
>  `HTTP_MODULE_ID` is a type definition of a `void` pointer.  
  
## Return Value  
 A pointer to an [IHttpStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-interface.md); otherwise, NULL.  
  
## Remarks  
 [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) or [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) pointers register for various events defined in the Httpserv.h header file. For more information, see [Request-Processing Constants](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md). Through any of these classes' `virtual` methods, you can retrieve [IHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md) pointers from various interfaces that implement a `GetModuleContextContainer` method.  
  
 You can define custom classes that implement the `IHttpStoredContext` interface and then create a pointer to this `IHttpStoredContext` class implementer by calling the `new` operator. You can then add and retrieve this pointer on an `IHttpModuleContextContainer` pointer by calling the [SetModuleContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md) and `GetModuleContext` methods, respectively.  
  
 When the `IHttpStoredContext` pointer is no longer needed, the [IHttpStoredContext::CleanupStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md) method is called internally, where the implementer of the `IHttpStoredContext` interface method should usually call `delete``this`.  
  
## Notes for Implementers  
 [IHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpModuleContextContainer` implementers that use dynamic memory allocation must release or call `delete` on the `IHttpStoredContext` pointer when it is no longer needed. If cleanup is necessary, you can call the [IHttpStoredContext::CleanupStoredContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md) method.  
  
## Notes for Callers  
 `IHttpModuleContextContainer` implementers are responsible for memory management with this data; therefore, `IHttpModuleContextContainer` clients must not release or call `delete` on the returned `IHttpStoredContext` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then calls the `GetModuleContext` method to retrieve the `IHttpStoredContext` pointer.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpModuleContextContainer#2](IHttpModuleContextContainer#2)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpModuleContextContainer Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md)   
 [IHttpModuleContextContainer::SetModuleContext Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md)