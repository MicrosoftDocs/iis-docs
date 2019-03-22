---
title: "IHttpServer::AssociateWithThreadPool Method"
ms.date: "10/07/2016"
ms.assetid: b215486a-b494-4873-044a-9d105ce7744e
---
# IHttpServer::AssociateWithThreadPool Method
Associates an asynchronous completion operation with the thread pool.  
  
## Syntax  
  
```cpp  
virtual HRESULT AssociateWithThreadPool(  
   IN HANDLE hHandle,  
   IN LPOVERLAPPED_COMPLETION_ROUTINE completionRoutine  
) = 0;  
```  
  
### Parameters  
 `hHandle`  
 [IN] A `HANDLE` for the asynchronous operation.  
  
 `completionRoutine`  
 [IN] An `LPOVERLAPPED_COMPLETION_ROUTINE` function pointer.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 Developers can use the `AssociateWithThreadPool` method to associate a handle for an asynchronous input/output operation with the IIS thread pool. Because the asynchronous operation associated with that handle will complete within the IIS thread pool, the `AssociateWithThreadPool` method allows you to perform a series of asynchronous operations without maintaining your own thread pool.  
  
## Example  
 The following code example demonstrates how to use the `AssociateWithThreadPool` method to create an HTTP module that creates a condition that requires an asynchronous input/output operation and associates the asynchronous completion routine with the IIS thread pool.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerAssociateWithThreadPool#1](IHttpServerAssociateWithThreadPool#1)]  -->  
  
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
 [IHttpServer Interface](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md)