---
title: "IHttpServer::DispenseContainer Method"
ms.date: "10/07/2016"
ms.assetid: 6ba8224a-bd99-15b8-2025-64ea4b1578b0
---
# IHttpServer::DispenseContainer Method
Returns a context container that may be dispensed.  
  
## Syntax  
  
```cpp  
virtual IDispensedHttpModuleContextContainer* DispenseContainer(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IDispensedHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/idispensedhttpmodulecontextcontainer-interface.md).  
  
## Remarks  
 [IHttpServer](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md) implementers will typically return a `new``IDispensedHttpModuleContextContainer` that will call `delete` on itself when the [IDispensedHttpModuleContextContainer::ReleaseContainer](../../web-development-reference/native-code-api-reference/idispensedhttpmodulecontextcontainer-releasecontainer-method.md) method is called.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events. This module defines a custom [IHttpStoredContext](../../web-development-reference/native-code-api-reference/ihttpstoredcontext-interface.md) class and then calls the `DispenseContainer` method with a `new` pointer to that custom class. The example then writes the custom data to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IHttpServer#5](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpServer/cpp/DispenseContainer.cpp#5)]  
  
 The above code writes new events to the Event Viewer, where the Data box contains strings similar to the following.  
  
 `DispensedContext::~DispensedContext`  
  
 `DispensedContext::CleanupStoredContext`  
  
 `DispensedContext::Display`  
  
 `DispensedContext::DispensedContext`  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The `RegisterModule` calling convention must be stdcall. The best way to guarantee this is to explicitly declare `RegisterModule` with [__stdcall](https://go.microsoft.com/fwlink/?LinkId=107360).  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer Interface](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md)