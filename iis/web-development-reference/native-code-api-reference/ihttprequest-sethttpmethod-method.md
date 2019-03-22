---
title: "IHttpRequest::SetHttpMethod Method"
ms.date: "10/07/2016"
ms.assetid: abf2c37d-5703-8701-ad32-0f8480118d52
---
# IHttpRequest::SetHttpMethod Method
Sets the HTTP method for the request.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetHttpMethod(  
   IN PCSTR pszHttpMethod  
) = 0;  
```  
  
### Parameters  
 `pszHttpMethod`  
 [IN] The HTTP method to set.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that the specified parameter is not valid (for example, the parameter is set to NULL).|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `SetHttpMethod` modifies the HTTP method for the current request. The method specified by the `pszHttpMethod` parameter can be a custom method or a method defined in Request for Comments (RFC) 1945, "Hypertext Transfer Protocol -- HTTP/1.0," or RFC 2616, "Hypertext Transfer Protocol -- HTTP/1.1." Subsequent request processing functions and logging operations will process the new method as if the client had requested the method. Therefore, any error conditions caused by modifying the method will be returned to the client. For example, if the new method is not supported, the Web server will return an HTTP 405 error.  
  
## Example  
 The following code example demonstrates how to use the `SetHttpMethod` method to create an HTTP module that modifies the HTTP method for the current request to an "OPTIONS" request method.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpRequestSetHttpMethod#1](IHttpRequestSetHttpMethod#1)]  -->  
  
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
 [IHttpRequest Interface](../../web-development-reference/native-code-api-reference/ihttprequest-interface.md)   
 [IHttpRequest::GetHttpMethod Method](../../web-development-reference/native-code-api-reference/ihttprequest-gethttpmethod-method.md)