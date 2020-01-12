---
title: "IHttpServer::GetFileInfo Method"
ms.date: "10/07/2016"
ms.assetid: 1c3d91fe-062b-93c1-c5ad-e0dda028d987
---
# IHttpServer::GetFileInfo Method
Returns an [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface for a specific file path.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetFileInfo(  
   IN PCWSTR pszPhysicalPath,  
   IN HANDLE hUserToken,  
   IN PSID pSid,  
   IN PCWSTR pszVrPath,  
   IN HANDLE hVrToken,  
   IN BOOL fCache,  
   OUT IHttpFileInfo** ppFileInfo,  
   IN IHttpTraceContext* pHttpTraceContext = NULL  
) = 0;  
```  
  
### Parameters  
 `pszPhysicalPath`  
 [IN] A pointer to a string that contains the physical path to a file.  
  
 `hUserToken`  
 [IN] A `HANDLE` that contains the token for the impersonation user; otherwise, NULL.  
  
 `pSid`  
 [IN] A pointer to a security identifier ([SID](https://go.microsoft.com/fwlink/?LinkId=63529)) that contains the security ID for the impersonation user; otherwise, NULL.  
  
 `pszVrPath`  
 [IN] A pointer to a string that contains the virtual path to register for change notifications; otherwise, NULL.  
  
 `hVrToken`  
 [IN] A `HANDLE` that contains the impersonation token to register for change notifications; otherwise, NULL.  
  
 `fCache`  
 [IN] `true` to indicate that the file should be cached; otherwise, `false`.  
  
 `ppFileInfo`  
 [OUT] A dereferenced pointer to an `IHttpFileInfo` interface.  
  
 `pHttpTraceContext`  
 [IN] A pointer to an optional [IHttpTraceContext](../../web-development-reference/native-code-api-reference/ihttptracecontext-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_FAIL|Indicates that the call to `GetFileInfo` was made while the module host was terminating.|  
  
## Remarks  
 The `IHttpServer::GetFileInfo` method creates an `IHttpFileInfo` interface for a specific path. This method differs from the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method, which returns an `IHttpFileInfo` interface for the file that IIS is processing within a request context.  
  
 The `pszPhysicalPath` and `ppFileInfo` parameters are required to create an `IHttpFileInfo` interface. The `pszPhysicalPath` parameter specifies the path to the file, and the `ppFileInfo` parameter defines the pointer that IIS will populate with the corresponding `IHttpFileInfo` interface.  
  
 The `pszVrPath` and `hVrToken` parameters are optional, and you should set them to NULL if you do not use them. These parameters specify, respectively, the virtual path and impersonation token to use when a module registers for change notifications (for example, if you request caching by setting the `fCache` parameter to `true`).  
  
> [!NOTE]
>  Other configuration settings may prevent IIS from caching the file, even if you specify `true` for the `fCache` parameter.  
  
 The `hUserToken` and `pSid` parameters are also optional, and you should set them to NULL if you do not use them. These parameters specify, respectively, the token and SID for the impersonation user. The remaining optional parameter, `pHttpTraceContext`, specifies the `IHttpTraceContext` interface for tracing.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  Registers for the [RQ_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification.  
  
2.  Creates a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class that contains an [OnBeginRequest](../../web-development-reference/native-code-api-reference/chttpmodule-onbeginrequest-method.md) method. When a client requests a file, the `OnBeginRequest` method performs the following tasks:  
  
    1.  Maps a path to a relative URL by using the [IHttpContext::MapPath](../../web-development-reference/native-code-api-reference/ihttpcontext-mappath-method.md) method.  
  
    2.  Creates an `IHttpFileInfo` interface for the file path by using the `IHttpServer::GetFileInfo` method.  
  
    3.  Retrieves the entity tag for the file by using the [IHttpFileInfo::GetETag](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getetag-method.md) method.  
  
    4.  Returns the entity tag to the client by using the [IHttpResponse::WriteEntityChunks](../../web-development-reference/native-code-api-reference/ihttpresponse-writeentitychunks-method.md) method.  
  
3.  Removes the `CHttpModule` class from memory and then exits.  
  
 [!code-cpp[IHttpServerGetFileInfo#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpServerGetFileInfo/cpp/IHttpServerGetFileInfo.cpp#1)]  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
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
 [IHttpContext::GetFileInfo Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md)