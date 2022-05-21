---
title: "IHttpServer::GetManagedType Method"
description: Learn how the GetManagedType method retrieves the managed type for a specific site and Uniform Resource Identifier (URI).
ms.date: "10/07/2016"
ms.assetid: b4e71c1b-10cd-5cf2-0198-0d73ba87fd9f
---
# IHttpServer::GetManagedType Method
Retrieves the managed type for a specific site and Uniform Resource Identifier (URI).  
  
## Syntax  
  
```cpp  
virtual HRESULT GetManagedType(  
   IN DWORD dwSiteId,  
   IN PCWSTR pszVirtualPath,  
   __out PWSTR pszManagedType,  
   IN OUT DWORD* pcchManagedType  
) = 0;  
```  
  
### Parameters  
 `dwSiteId`  
 [IN] The site identifier for the URI in `pszVirtualPath`.  
  
 `pszVirtualPath`  
 [IN] A pointer to a string that contains a URI.  
  
 `pszManagedType`  
 [__out] A pointer to a preallocated string buffer.  
  
 `pcchManagedType`  
 [IN][OUT] The length, in bytes, of the `pszManagedType` buffer.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_INVALIDARG|Indicates that an invalid value was passed in one of the parameters (for example, one of the pointers is set to NULL).|  
|E_OUTOFMEMORY|Indicates that there is not enough available memory to perform the operation.|  
|ERROR_INVALID_PARAMETER|Indicates that an invalid value was passed in one of the parameters.|  
|ERROR_INSUFFICIENT_BUFFER|Indicates that there is not enough buffer space to perform the operation.|  
  
## Remarks  
 The `GetManagedType` method retrieves the `type` attribute for request handler that will process a specific virtual path that is specified by the `dwSiteId` and `pszVirtualPath` parameters. The method then returns this information in the buffer that is specified by the `pszManagedType` parameter.  
  
> [!IMPORTANT]
>  The caller must allocate the buffer for `pszManagedType`. If the caller passes NULL for this parameter, the method will return E_INVALIDARG.  
  
 The `type` attribute for a request handler is located in the `<handlers>` section of the ApplicationHost.config file. This attribute contains a list of the [!INCLUDE[dnprdnshort](../../wmi-provider/includes/dnprdnshort-md.md)] namespaces for a request handler. For example, the "TraceHandler-Integrated" request handler has a `type` attribute of "System.Web.Handlers.TraceHandler" by default.  
  
 The `IHttpServer::GetManagedType` method differs from the [IScriptMapInfo::GetManagedType](../../web-development-reference/native-code-api-reference/iscriptmapinfo-getmanagedtype-method.md) method in that the `IHttpServer::GetManagedType` method can retrieve the `type` attribute for any virtual path, whereas the `IScriptMapInfo::GetManagedType` method will retrieve only the `type` attribute for the [IScriptMapInfo](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md) interface.  
  
## Example  
 The following code example demonstrates how to use the `GetManagedType` method to create an HTTP module that retrieves the managed type for the /default.aspx URI.  
  
 The module completes the following steps:  
  
1. Retrieves the site identifier for the current request.  
  
2. Retrieves the length needed to retrieve the managed type for the request.  
  
3. Allocates a buffer for the managed type.  
  
4. Retrieves the managed type.  
  
5. Returns the result to a Web client and then exits.  
  
 [!code-cpp[IHttpServerGetManagedType#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpServerGetManagedType/cpp/IHttpServerGetManagedType.cpp#1)]  
  
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
 [IScriptMapInfo::GetManagedType Method](../../web-development-reference/native-code-api-reference/iscriptmapinfo-getmanagedtype-method.md)
