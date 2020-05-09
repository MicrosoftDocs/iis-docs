---
title: "IHttpUser::SupportsIsInRole Method"
ms.date: "10/07/2016"
ms.assetid: 2b1a1fd5-0624-e9b1-2ca5-c61a37ef44a4
---
# IHttpUser::SupportsIsInRole Method
Returns a value that indicates whether role support is enabled for the user.  
  
## Syntax  
  
```cpp  
virtual BOOL SupportsIsInRole(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if role support is enabled for the user; otherwise, `false`.  
  
## Remarks  
 The `SupportsIsInRole` return value depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
- If the [IHttpUser](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md) implementer handles managed or anonymous authentication, `SupportsIsInRole` returns `true`.  
  
- If the `IHttpUser` implementer implements Custom, Basic, Certification Mapping, or SSPI authentication, `SupportsIsInRole` returns `false`.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that clears the response headers and body and then returns user information to the client as an XML document.  
  
 The above code writes XML that is similar to the following to the response stream.  
  
```  
<?xml version="1.0" ?>  
<user supportsRoles="true" />  
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
 [IHttpUser Interface](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md)
