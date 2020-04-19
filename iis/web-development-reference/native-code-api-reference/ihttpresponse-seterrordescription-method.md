---
title: "IHttpResponse::SetErrorDescription Method"
ms.date: "10/07/2016"
ms.assetid: 65e5e9a2-0efc-4d11-af6b-c152d58d8b2b
---
# IHttpResponse::SetErrorDescription Method
Specifies the custom error description.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetErrorDescription(  
   IN PCWSTR pszDescription,  
   IN DWORD cchDescription,  
   IN BOOL fHtmlEncode = TRUE  
) = 0;  
```  
  
### Parameters  
 `pszDescription`  
 [IN] A pointer to a string that contains the custom error description.  
  
 `cchDescription`  
 [IN] A `DWORD` that contains the length, in characters, of the string in `pszDescription`.  
  
 `fHtmlEncode`  
 [IN] `true` if the string in `pszDescription` should be encoded for HTML; otherwise, `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that an invalid value was passed in one of the parameters.|  
  
## Remarks  
 Developers use the `SetErrorDescription` method to specify the custom error description. IIS displays the custom error description as part of the detailed information that is sent to a Web client when IIS returns an error message.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1. Retrieves a pointer to an [IHttpResponse](../../web-development-reference/native-code-api-reference/ihttpresponse-interface.md) interface by using the [IHttpContext::GetResponse](../../web-development-reference/native-code-api-reference/ihttpcontext-getresponse-method.md) method.  
  
2. Retrieves the current HTTP status code by using the [IHttpResponse::GetStatus](../../web-development-reference/native-code-api-reference/ihttpresponse-getstatus-method.md) method.  
  
3. If the current HTTP status code is a 404.0 error, retrieves the current custom error description by using the [IHttpResponse::GetErrorDescription](../../web-development-reference/native-code-api-reference/ihttpresponse-geterrordescription-method.md) method.  
  
4. If no custom error description is currently defined, sets the custom error description by using the `SetErrorDescription` method.  
  
 [!code-cpp[IHttpResponseSetErrorDescription#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseSetErrorDescription/cpp/IHttpResponseSetErrorDescription.cpp#1)]  
  
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
 [IHttpResponse Interface](../../web-development-reference/native-code-api-reference/ihttpresponse-interface.md)   
 [IHttpResponse::GetErrorDescription Method](../../web-development-reference/native-code-api-reference/ihttpresponse-geterrordescription-method.md)