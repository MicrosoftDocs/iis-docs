---
title: "IHttpContext::GetUser Method"
ms.date: "10/07/2016"
ms.assetid: f98e6f16-fa74-fa56-d9cb-26529064e4fa
---
# IHttpContext::GetUser Method
Retrieves the user information container for the current context.  
  
## Syntax  
  
```cpp  
virtual IHttpUser* GetUser(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpUser](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md) interface.  
  
## Remarks  
 The `GetUser` method returns an `IHttpUser` interface, which contains several methods for retrieving security-related information for the current request. For example, you can use the [IHttpUser::GetUserName](../../web-development-reference/native-code-api-reference/ihttpuser-getusername-method.md) and [IHttpUser::GetPassword](../../web-development-reference/native-code-api-reference/ihttpuser-getpassword-method.md) methods to retrieve the user credentials for an authenticated user.  
  
> [!NOTE]
>  The HTTP context object owns the lifetime of the `IHttpUser` interface that is returned by the `GetUser` method. Therefore, you do not free this pointer when you write HTTP modules.  
  
## Example  
 The following code example demonstrates how to use the `GetUser` method to create an HTTP module that retrieves an `IHttpUser` interface. The example then uses the `IHttpUser::GetUserName` method to retrieve the current user name. If the Web site is using anonymous authentication, the user name will be blank, and the HTTP module will return a message that the Web site is using anonymous authentication. Otherwise, the HTTP module will return the current user name to a Web client.  
  
 [!code-cpp[IHttpContextGetUser#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextGetUser/cpp/IHttpContextGetUser.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpUser Interface](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md)