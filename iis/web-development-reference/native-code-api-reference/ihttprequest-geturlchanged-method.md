---
title: "IHttpRequest::GetUrlChanged Method"
ms.date: "10/07/2016"
ms.assetid: fb1a6f37-8da1-5118-a581-5fe6684a88a2
---
# IHttpRequest::GetUrlChanged Method
Determines whether the request URL has been modified.  
  
## Syntax  
  
```cpp  
virtual BOOL GetUrlChanged(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if the URL has been modified; otherwise, `false`.  
  
## Remarks  
 The `GetUrlChanged` method determines whether the URL for the current request was changed after the [IHttpRequest::SetUrl Method](../../web-development-reference/native-code-api-reference/ihttprequest-seturl-method.md) method was called.  
  
## Example  
 The following code example demonstrates how to use the `GetUrlChanged` method to create an HTTP module that determines whether the request URL has been modified.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpRequestGetUrlChanged#1](IHttpRequestGetUrlChanged#1)]  -->  
  
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
 [IHttpRequest::SetUrl Method](../../web-development-reference/native-code-api-reference/ihttprequest-seturl-method.md)