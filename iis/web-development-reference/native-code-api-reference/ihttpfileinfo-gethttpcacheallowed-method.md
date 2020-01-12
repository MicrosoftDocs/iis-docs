---
title: "IHttpFileInfo::GetHttpCacheAllowed Method"
ms.date: "10/07/2016"
ms.assetid: a46e00e7-47ae-2359-120d-0883ee73f8a9
---
# IHttpFileInfo::GetHttpCacheAllowed Method
Returns a value that indicates whether the corresponding file can be cached.  
  
## Syntax  
  
```cpp  
virtual BOOL GetHttpCacheAllowed(  
   OUT DWORD* pSecondsToLive  
) const = 0;  
```  
  
### Parameters  
 `pSecondsToLive`  
 [OUT] A pointer to a `DWORD` that contains the number of seconds that the cached file will be held.  
  
## Return Value  
 `true` if the corresponding file may be cached; otherwise, `false`.  
  
## Remarks  
 While the `pSecondsToLive` parameter must not be NULL, inspect this parameter only if the `GetHttpCacheAllowed` method returns `true`. If that is the case, [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) implementers are not required to set this output parameter before return.  
  
 The behavior of the `GetHttpCacheAllowed` method is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Implementers that reference an Internet file return `false`.  
  
-   Implementers that reference a non-Internet file return `true` if caching is enabled for the file type.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method to create an HTTP module that retrieves a pointer to an `IHttpFileInfo` interface for the current request. The example then calls the `GetHttpCacheAllowed` method to retrieve cache information for the requested file and displays this information to a Web client.  
  
 [!code-cpp[IHttpFileInfo#9](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpFileInfo/cpp/GetHttpCacheAllowed.cpp#9)]  
  
 The following text is a sample of the data output from the preceding code example.  
  
```  
HTTP/1.1 200 OK  
content-Type:text/plain  
Server: Microsoft-IIS/7.0  
Date: Thu, 15 Dec 2005 22:22:09 GMT  
Content-Length: 348  
  
Cache Allowed: true  
Time-to-Live: -1  
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