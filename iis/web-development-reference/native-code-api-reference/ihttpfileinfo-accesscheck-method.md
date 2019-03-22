---
title: "IHttpFileInfo::AccessCheck Method"
ms.date: "10/07/2016"
ms.assetid: 87318954-5b0c-3d49-5cf5-b9d58de912a5
---
# IHttpFileInfo::AccessCheck Method
Returns a value that indicates whether the user can access the corresponding file.  
  
## Syntax  
  
```cpp  
virtual HRESULT AccessCheck(  
   IN HANDLE hUserToken,  
   IN PSID pUserSid  
) = 0;  
```  
  
### Parameters  
 `hUserToken`  
 [IN] A `HANDLE` that contains the token for the user.  
  
 `pUserSid`  
 [IN] A pointer that contains the security identifier ([SID](https://go.microsoft.com/fwlink/?LinkId=63529)) for the user.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_FAIL|Indicates that the operation failed.|  
  
## Remarks  
 To determine whether the user can or cannot access the file, call either the [SUCCEEDED](https://go.microsoft.com/fwlink/?LinkId=58226) or [FAILED](https://go.microsoft.com/fwlink/?LinkId=58235) function, respectively, by passing the returned `HRESULT` from the `AccessCheck` method.  
  
 The behavior of the `AccessCheck` method is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Most implementers return S_OK immediately if the `hUserToken` parameter is NULL.  
  
-   Most implementers return the value from calling the [HRESULT_FROM_WIN32](https://go.microsoft.com/fwlink/?LinkId=58220) function by supplying the value from the [GetLastError](https://go.microsoft.com/fwlink/?LinkId=86917) function as a parameter if there are any internal errors or if the corresponding file cannot be opened.  
  
> [!CAUTION]
>  Because most implementers return S_OK immediately if `hUserToken` is NULL, you should provide the user token whenever possible because the implementation may change.  
  
> [!CAUTION]
>  While most implementers allow either or both parameters to be NULL, you should provide non-NULL values for each parameter whenever possible because the implementation may change.  
  
## Example  
 The following example demonstrates how to use the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method to create an HTTP module that retrieves a pointer to an [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface for the current request. The example then calls the `AccessCheck` method to retrieve access information for the requested file and displays this information to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpFileInfo#2](IHttpFileInfo#2)]  -->  
  
 The following text is a sample of the data output from the preceding code example.  
  
```  
HTTP/1.1 200 OK  
content-Type:text/plain  
Server: Microsoft-IIS/7.0  
Date: Thu, 15 Dec 2005 22:22:09 GMT  
Content-Length: 348  
  
Access: -2147024891  
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