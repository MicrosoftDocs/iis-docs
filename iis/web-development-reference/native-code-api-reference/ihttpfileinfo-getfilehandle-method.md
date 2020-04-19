---
title: "IHttpFileInfo::GetFileHandle Method"
ms.date: "10/07/2016"
ms.assetid: ff010463-a9a9-4e7f-5fcd-367e09aeb1cf
---
# IHttpFileInfo::GetFileHandle Method
Returns the file handle for the corresponding file.  
  
## Syntax  
  
```cpp  
virtual HANDLE GetFileHandle(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A valid `HANDLE` to the corresponding file; otherwise, INVALID_HANDLE_VALUE (defined in the Winbase.h header file).  
  
## Remarks  
 The returned handle must use an overlapped structure to process read requests; otherwise, the current pointer in the file handle might point to random files if multiple threads access the handle concurrently.  
  
 If the returned handle is not INVALID_HANDLE_VALUE, it will point to a valid file handle returned from a method such as the [CreateFile](https://go.microsoft.com/fwlink/?LinkId=58231) global function.  
  
 The behavior of the `GetFileHandle` method is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Implementers that reference an Internet file return a handle to the file if opened; otherwise, implementers return INVALID_HANDLE_VALUE.  
  
-   Implementers that reference a non-Internet file return INVALID_HANDLE_VALUE.  
  
## Notes for Implementers  
 [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) implementers are responsible for resource management with this data; therefore, `IHttpFileInfo` implementers must call the [CloseHandle](https://go.microsoft.com/fwlink/?LinkId=86428) function on the `HANDLE` when it is no longer needed.  
  
## Notes for Callers  
 `IHttpFileInfo` implementers are responsible for resource management with this data; therefore, `IHttpFileInfo` clients must not call `CloseHandle` on the returned `HANDLE` when this data is no longer needed. Furthermore, clients must not change the state of the memory referenced by this `HANDLE`; otherwise, an access violation will be thrown or the data will become invalid.  
  
## Example  
 The following example demonstrates how to use the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method to create an HTTP module that retrieves a pointer to an `IHttpFileInfo` interface for the current request. The example then calls the `GetFileHandle` method to retrieve a `HANDLE` to the corresponding file and displays this information to a Web client.  
  
 [!code-cpp[IHttpFileInfo#7](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpFileInfo/cpp/GetFileHandle.cpp#7)]  
  
 The following text is an example of the data output from the preceding code example.  
  
```  
HTTP/1.1 200 OK  
content-Type:text/plain  
Server: Microsoft-IIS/7.0  
Date: Thu, 15 Dec 2005 22:22:09 GMT  
Content-Length: 348  
  
File Handle: INVALID_HANDLE_VALUE  
```  
  
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