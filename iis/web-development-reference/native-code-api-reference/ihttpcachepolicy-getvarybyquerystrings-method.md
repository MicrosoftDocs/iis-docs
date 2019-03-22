---
title: "IHttpCachePolicy::GetVaryByQueryStrings Method"
ms.date: "10/07/2016"
ms.assetid: 44714859-9692-7881-1978-662089aed17a
---
# IHttpCachePolicy::GetVaryByQueryStrings Method
Returns the custom query values for the cache policy.  
  
## Syntax  
  
```cpp  
virtual PCSTR GetVaryByQueryStrings(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A null-terminated `PCSTR` that contains a comma-delimited list of custom query values.  
  
## Remarks  
 [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) pointer as a parameter on the corresponding `virtual` method. Call the [IHttpContext::GetResponse](../../web-development-reference/native-code-api-reference/ihttpcontext-getresponse-method.md) method, then the [IHttpResponse::GetCachePolicy](../../web-development-reference/native-code-api-reference/ihttpresponse-getcachepolicy-method.md) method, and finally the `GetVaryByQueryStrings` method to retrieve the custom query values.  
  
 `GetVaryByQueryStrings` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   The current default implementer of the [IHttpCachePolicy](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md) interface declares a `private` buffer that contains variable query data. During the construction of an implementer, this buffer is initialized to empty. If the supplied parameter is NULL, the [AppendVaryByQueryString](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-appendvarybyquerystring-method.md) method immediately returns S_OK. Otherwise, the buffer is expanded to hold a copy of the parameter, including the null-termination character, plus 1 if the buffer is not currently empty. If the buffer is not empty, the "," character is appended to the buffer. Finally, the contents of the parameter, including the null-termination character, are appended to the buffer.  
  
-   `GetVaryByQueryStrings` returns the comma-delimited list of custom query values set through successive calls to `AppendVaryByQueryString`.  
  
## Notes for Implementers  
 `IHttpCachePolicy` implementers are responsible for memory management with this data; therefore, `IHttpCachePolicy` implementers that use dynamic memory allocation must release or call `delete` on the `PCSTR` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IHttpCachePolicy` implementers are responsible for memory management with this data; therefore, `IHttpCachePolicy` clients must not release or call `delete` on the returned `PCSTR` pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this `PCSTR`, because an access violation will be thrown or the data will become invalid.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [RQ_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [RQ_SEND_RESPONSE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events. The module then retrieves an `IHttpCachePolicy` pointer and writes variable query information to the response stream.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpCachePolicy#8](IHttpCachePolicy#8)]  -->  
  
 For more information about how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes data that is similar to the following to the response stream:  
  
```  
Vary-by-Query:   
```  
  
 You can optionally compile the code by using the __`stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCachePolicy Interface](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md)