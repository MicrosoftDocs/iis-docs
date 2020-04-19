---
title: "IHttpFileInfo::GetModuleContextContainer Method"
ms.date: "10/07/2016"
ms.assetid: 4a2a126b-279e-3424-ec98-2c8022343a9c
---
# IHttpFileInfo::GetModuleContextContainer Method
Returns an [IHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-interface.md) pointer for the corresponding file.  
  
## Syntax  
  
```cpp  
virtual IHttpModuleContextContainer* GetModuleContextContainer(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an `IHttpModuleContextContainer` interface.  
  
## Remarks  
 The `GetModuleContextContainer` method return value depends on implementation. By default, the current implementation creates an [IDispensedHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/idispensedhttpmodulecontextcontainer-interface.md) that is synchronized but not dispensed.  
  
## Notes for Implementers  
 [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpFileInfo` implementers should create an `IDispensedHttpModuleContextContainer` pointer at construction and hold a `private` reference to this `IDispensedHttpModuleContextContainer` pointer for the life of the `IHttpFileInfo` pointer. When the `GetModuleContextContainer` method is called, you should upcast and return this same `IDispensedHttpModuleContextContainer` pointer. When the destructor of the class that implements the `IHttpFileInfo` interface is called, this destructor should call the [IDispensedHttpModuleContextContainer::ReleaseContainer](../../web-development-reference/native-code-api-reference/idispensedhttpmodulecontextcontainer-releasecontainer-method.md) method on this `private` reference and then set that reference to NULL.  
  
 `GetModuleContextContainer` should not return NULL. If the internal container is NULL, set this internal container to the value on the call to [IHttpServer::DispenseContainer](../../web-development-reference/native-code-api-reference/ihttpserver-dispensecontainer-method.md), and then return this same container.  
  
> [!NOTE]
>  Although implicit upcast operations are considered safe, consider using an explicit cast for program clarity. Also consider using the [dynamic_cast](https://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible.  
  
## Notes for Callers  
 `IHttpFileInfo` implementers are responsible for memory management with this data; therefore, `IHttpFileInfo` clients must not release, call `delete` on, or attempt to downcast and call `IDispensedHttpModuleContextContainer::ReleaseContainer` on the returned `IHttpModuleContextContainer` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates a custom class named `MyContainer` that implements the `IDispensedHttpModuleContextContainer` interface, and a custom class named `MyClass` that implements the `IHttpFileInfo` interface. `MyClass` manages a `MyContainer` pointer during the lifetime of a `MyClass` pointer.  
  
 [!code-cpp[IHttpFileInfo#12](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpFileInfo/cpp/GetModuleContextContainer.cpp#12)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpFileInfo Interface](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md)   
 [IHttpApplication::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpapplication-getmodulecontextcontainer-method.md)   
 [IHttpConnection::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpconnection-getmodulecontextcontainer-method.md)   
 [IHttpContext::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getmodulecontextcontainer-method.md)   
 [IHttpFileMonitor::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpfilemonitor-getmodulecontextcontainer-method.md)   
 [IHttpSite::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpsite-getmodulecontextcontainer-method.md)   
 [IHttpUrlInfo::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpurlinfo-getmodulecontextcontainer-method.md)   
 [IMetadataInfo::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/imetadatainfo-getmodulecontextcontainer-method.md)