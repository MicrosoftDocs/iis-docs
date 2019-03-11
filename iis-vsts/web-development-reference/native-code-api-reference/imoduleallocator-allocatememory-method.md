---
title: "IModuleAllocator::AllocateMemory Method"
ms.date: "10/07/2016"
ms.assetid: 0d96c164-62ed-4ee5-89ad-77961d929411
---
# IModuleAllocator::AllocateMemory Method
Allocates a specified amount of memory.  
  
## Syntax  
  
```cpp  
virtual VOID* AllocateMemory(  
   IN DWORD cbAllocation  
) = 0;  
```  
  
### Parameters  
 `cbAllocation`  
 [IN] The number of bytes to allocate.  
  
## Return Value  
 A pointer to `VOID`.  
  
## Remarks  
 The `AllocateMemory` method allocates an amount of memory that is specified by the `cbAllocation` parameter. This memory is allocated within the request memory pool, which is faster than allocating memory on the heap.  
  
## Example  
 The following code example demonstrates how to use the `AllocateMemory` method to create an HTTP module that allocates a 1-KB buffer. The example then copies a string into the buffer and returns the response to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IModuleAllocatorAllocateMemory#1](IModuleAllocatorAllocateMemory#1)]  -->  
  
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
 [IModuleAllocator Interface](../../web-development-reference\native-code-api-reference/imoduleallocator-interface.md)