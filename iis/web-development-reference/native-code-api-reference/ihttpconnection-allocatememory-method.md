---
title: "IHttpConnection::AllocateMemory Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 25fd377b-68aa-c2da-f21d-bddc92f71a51
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# IHttpConnection::AllocateMemory Method
Allocates a specified amount of memory.  
  
## Syntax  
  
```cpp  
virtual VOID* AllocateMemory(  
   DWORD cbAllocation  
) = 0;  
```  
  
#### Parameters  
 `cbAllocation`  
 The number of bytes to allocate.  
  
## Return Value  
 A pointer to `VOID`.  
  
## Remarks  
 The `AllocateMemory` method allocates an amount of memory that is specified by the `cbAllocation` parameter and has the lifetime of the current request. The server will automatically reclaim this memory at the end of the request.  
  
## Example  
 The following code example demonstrates how to use the `AllocateMemory` method to create an HTTP module that allocates a chunk of memory to retrieve the value of the HTTP `User-Agent` header.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpConnectionAllocateMemory#1](IHttpConnectionAllocateMemory#1)]  -->  
  
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
 [IHttpConnection Interface](../../web-development-reference\native-code-api-reference/ihttpconnection-interface.md)