---
title: "IHttpFileInfo::CheckIfFileHasChanged Method"
ms.date: "10/07/2016"
ms.assetid: ea91d352-6fa5-7e85-8616-f0294cbd7bd3
---
# IHttpFileInfo::CheckIfFileHasChanged Method
Returns a value that indicates whether the corresponding file has been changed since it was loaded into a file cache.  
  
## Syntax  
  
```cpp  
virtual BOOL CheckIfFileHasChanged(  
   IN HANDLE hUserToken  
) = 0;  
```  
  
### Parameters  
 `hUserToken`  
 [IN] A `HANDLE` that contains the token for the user.  
  
## Return Value  
 `true` if the corresponding file has changed; otherwise, `false`.  
  
## Remarks  
 The behavior of the `CheckIfFileHasChanged` method is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Implementers that reference an Internet file return `false`.  
  
-   Implementers that reference a non-Internet file return `true` if the actual file has changed or if the attributes on the file cannot be accessed.  
  
> [!CAUTION]
>  While most implementers allow the `hUserToken` parameter to be NULL, you should provide a non-NULL value whenever possible because the implementation may change.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetFileInfo](../../web-development-reference\native-code-api-reference/ihttpcontext-getfileinfo-method.md) method to create an HTTP module that retrieves a pointer to an [IHttpFileInfo](../../web-development-reference\native-code-api-reference/ihttpfileinfo-interface.md) interface for the current request. The example then calls the `CheckIfFileHasChanged` method to retrieve file change information for the requested file and displays this information to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpFileInfo#3](IHttpFileInfo#3)]  -->  
  
 The following text is a sample of the data output from the preceding code example.  
  
```  
HTTP/1.1 200 OK  
content-Type:text/plain  
Server: Microsoft-IIS/7.0  
Date: Thu, 15 Dec 2005 22:22:09 GMT  
Content-Length: 348  
  
File Changed: false  
```  
  
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
 [IHttpFileInfo Interface](../../web-development-reference\native-code-api-reference/ihttpfileinfo-interface.md)