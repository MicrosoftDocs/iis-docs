---
title: "IHttpFileInfo::GetETag Method"
ms.date: "10/07/2016"
ms.assetid: d2d7360d-8d40-f029-02da-36572b1b8a52
---
# IHttpFileInfo::GetETag Method

Retrieves the entity tag of the corresponding file for an [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual PCSTR GetETag(  
   OUT USHORT* pcchETag = NULL  
) const = 0;  
```  
  
### Parameters  

 `pcchETag`  
 [OUT] A pointer to a `USHORT` buffer that receives the length, in bytes, of the returned string.  
  
## Return Value  

 A pointer to a string that contains the entity tag.  
  
## Remarks  

 The `GetETag` method retrieves the entity tag (ETag) for the file that is currently referenced by an `IHttpFileInfo` interface. You can use the entity tag for file comparisons. For example, you can use the entity tag to determine whether a file that has been cached by a client differs from the version on the server.  
  
> [!NOTE]
>  For additional information about file comparisons that use the entity tag, see section 13.3.3 in Request for Comments (RFC) 2616, "Hypertext Transfer Protocol -- HTTP/1.1."  
  
 After you call the `GetETag` method, the `pcchETag` parameter will contain the size, in bytes, of the entity tag that was returned.  
  
## Example  

 The following code example demonstrates how to use the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method to create an HTTP module that retrieves a pointer to an `IHttpFileInfo` interface for the current request. The example then calls the `GetETag` method to retrieve the entity tag for the requested file and displays this information to a Web client.  
  
 [!code-cpp[IHttpFileInfoGetETag#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpFileInfoGetETag/cpp/IHttpFileInfoGetETag.cpp#1)]  
  
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
