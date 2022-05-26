---
title: "IHttpCachePolicy::SetVaryByValue Method"
ms.date: "10/07/2016"
description: Learn how to set the variable value, such as such as S_OK, E_INVALIDARG, and ERROR_ARITHMETIC_OVERFLOW, for the cache policy.
ms.assetid: 6822e2e0-50cb-1e07-5a9b-2b263d709c3b
---
# IHttpCachePolicy::SetVaryByValue Method
Sets the variable value for the cache policy.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetVaryByValue(  
   PCSTR pszValue  
) = 0;  
```  
  
### Parameters  
 `pszValue`  
 A pointer to a null-terminated string that contains the custom value to append.  
  
 -or-  
  
 NULL.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_INVALIDARG|Indicates that `pszValue` is NULL.|  
|ERROR_ARITHMETIC_OVERFLOW|Indicates that the length of `pszValue` exceeds a maximum limit.|  
  
## Remarks  
 [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) pointer as a parameter on the corresponding `virtual` method. To set the variable value, call the [IHttpContext::GetResponse](../../web-development-reference/native-code-api-reference/ihttpcontext-getresponse-method.md) method, the [IHttpResponse::GetCachePolicy](../../web-development-reference/native-code-api-reference/ihttpresponse-getcachepolicy-method.md) method, and finally the `SetVaryByValue` method.  
  
 `SetVaryByValue` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
- The current default implementer of the [IHttpCachePolicy](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md) interface declares a `private` buffer that contains variable data. During the construction of an implementer, this buffer is initialized to empty.  
  
- `SetVaryByValue` returns E_INVALIDARG immediately if the `pszValue` parameter is NULL. Otherwise, the internal buffer is expanded, if necessary, to hold the contents of `pszValue` and the null-termination character. Then `pszValue`, followed by the null-termination character, is copied into this buffer. Any data in the buffer before the call to `SetVaryByValue` is overwritten, if necessary, during the call to `SetVaryByValue`.  
  
## Notes for Implementers  
 [IHttpCachePolicy](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md) implementers are responsible for copying the `pszValue` parameter into a buffer, because the data associated with the `pszValue` parameter is not guaranteed to be valid after the call to `SetVaryByValue`.  
  
## Notes for Callers  
 `IHttpCachePolicy` clients are responsible for passing a null-terminated string to the `SetVaryByValue` method. Clients are also responsible for disposing of `pszValue` after the call to `SetVaryByValue`, because `IHttpCachePolicy` implementers copy `pszValue` into an internal buffer.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCachePolicy Interface](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md)
