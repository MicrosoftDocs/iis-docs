---
title: "IHttpServer::IncrementThreadCount Method"
ms.date: "10/07/2016"
ms.assetid: 6e59d669-1eae-b7a2-debb-de86ca8f5017
---
# IHttpServer::IncrementThreadCount Method
Increments the thread count for the thread pool.  
  
## Syntax  
  
```cpp  
virtual VOID IncrementThreadCount(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `IncrementThreadCount` method increases count of available threads for the thread pool by a single thread. The count will not exceed the maximum limit for the thread pool of 256 threads.  
  
> [!NOTE]
>  `IncrementThreadCount` does not actually increase the number of threads in use; only the thread count is affected.  
  
 When you are developing an HTTP module that performs operations that require a long time to process, your HTTP module could call `IncrementThreadCount` to increase the available threads for the thread pool while your module executes your long-running operations. When the module is finished, it would call [IIHttpServer::DecrementThreadCount](../../web-development-reference/native-code-api-reference/ihttpserver-decrementthreadcount-method.md) to restore the thread count.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that calls `IncrementThreadCount` to increase the thread count for the thread pool and then sleeps for 30 seconds. The module then calls `DecrementThreadCount` to restore the thread count and exits.  
  
 [!code-cpp[IHttpServerIncrementThreadCount#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpServerIncrementThreadCount/cpp/IHttpServerIncrementThreadCount.cpp#1)]  
  
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
 [IHttpServer::DecrementThreadCount Method](../../web-development-reference/native-code-api-reference/ihttpserver-decrementthreadcount-method.md)
