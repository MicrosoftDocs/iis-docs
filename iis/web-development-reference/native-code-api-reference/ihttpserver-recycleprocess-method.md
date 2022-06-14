---
title: "IHttpServer::RecycleProcess Method"
ms.date: "10/07/2016"
description: IHttpServer RecycleProcess Method recycles the worker process that is handling the current request.
ms.assetid: ca5369c7-43b2-0edf-f173-edbb1271802a
---
# IHttpServer::RecycleProcess Method
Recycles the worker process that is handling the current request.  
  
## Syntax  
  
```cpp  
virtual VOID RecycleProcess(  
   PCWSTR pszReason  
) = 0;  
```  
  
### Parameters  
 `pszReason`  
 A pointer to a string that contains the reason for recycling the process.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `RecycleProcess` method requests a shutdown of the current worker process and then starts a new worker process to handle requests.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `RecycleProcess` method to recycle the current worker process.  
  
> [!IMPORTANT]
>  For performance reasons, you should not use this example module on a production server.  
  
 When you test this HTTP module, you can use the Windows Task Manager to monitor the starting and stopping of worker processes.  
  
 [!code-cpp[IHttpServerRecycleProcess#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpServerRecycleProcess/cpp/IHttpServerRecycleProcess.cpp#1)]  
  
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
 [IHttpServer::RecycleApplication Method](../../web-development-reference/native-code-api-reference/ihttpserver-recycleapplication-method.md)
