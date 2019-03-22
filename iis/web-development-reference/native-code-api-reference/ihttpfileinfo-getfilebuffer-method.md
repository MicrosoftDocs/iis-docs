---
title: "IHttpFileInfo::GetFileBuffer Method"
ms.date: "10/07/2016"
ms.assetid: 0518341a-f739-14e4-8440-cc31ef53d04d
---
# IHttpFileInfo::GetFileBuffer Method
Returns a buffer in memory loaded from the corresponding file.  
  
## Syntax  
  
```cpp  
virtual const BYTE* GetFileBuffer(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `const``BYTE` pointer that contains the file data in memory; otherwise, NULL.  
  
## Remarks  
 If the returned `BYTE` pointer is not NULL, the pointer will contain an array of bytes loaded from the corresponding file. This data corresponds to the body of the HTTP response.  
  
 The behavior of the `GetFileBuffer` method is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Implementers that reference an Internet file return NULL.  
  
-   Implementers that reference a non-Internet file return a `BYTE` pointer in memory that contains data from the file, if that file can be opened. Otherwise, these implementers return NULL.  
  
## Notes for Implementers  
 [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpFileInfo` implementers that use dynamic memory allocation must release or call `delete`[] on the `BYTE` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IHttpFileInfo` implementers are responsible for memory management with this data; therefore, `IHttpFileInfo` clients must not release or call `delete`[] on the returned `BYTE` pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this `BYTE` pointer; otherwise, an access violation will be thrown or the data will become invalid.  
  
> [!NOTE]
>  Always test for NULL before inspecting the data contained in the returned `BYTE` pointer, because some implementations return NULL.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method to create an HTTP module that retrieves a pointer to an `IHttpFileInfo` interface for the current request. The example then calls the `GetFileBuffer` method to retrieve the file information for the requested file and displays this information to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpFileInfo#6](IHttpFileInfo#6)]  -->  
  
 The following text is a sample of the data output from the preceding code example.  
  
```  
HTTP/1.1 200 OK  
content-Type:text/plain  
Server: Microsoft-IIS/7.0  
Date: Thu, 15 Dec 2005 22:22:09 GMT  
Content-Length: 348  
  
File Buffer:   
<html>. . .  
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