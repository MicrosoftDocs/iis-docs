---
title: IAuthenticationProvider::SetUser Method
description: Describes the IAuthenticationProvider::SetUser method and provides the method's syntax, remarks, an example, and requirements.
ms.date: 10/07/2016
ms.assetid: 14f0a659-e8ed-3010-11c5-9cb134455375
ms.custom: sfi-ropc-nochange
---
# IAuthenticationProvider::SetUser Method
Sets the authenticated user on the authentication provider.  
  
## Syntax  
  
```cpp  
virtual VOID SetUser(  
   IHttpUser* pUser  
) = 0;  
```  
  
### Parameters  
 `pUser`  
 An authenticated pointer to an [IHttpUser](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md).  
  
## Remarks  
 If the `pUser` parameter is NULL, the default authentication continues.  
  
 Calling the `SetUser` method with a non-NULL `IHttpUser` pointer will authenticate that user immediately.  
  
## Notes for Implementers  
 [IAuthenticationProvider](../../web-development-reference/native-code-api-reference/iauthenticationprovider-interface.md) implementers assume responsibility for memory management with this data; therefore, `IAuthenticationProvider` implementers must call the [IHttpUser::DereferenceUser](../../web-development-reference/native-code-api-reference/ihttpuser-dereferenceuser-method.md) method when they no longer need the `IHttpUser`.  
  
## Notes for Callers  
 `IAuthenticationProvider` callers are responsible for creating a custom `IHttpUser` pointer on the heap before calling `SetUser`; `IAuthenticationProvider` implementers then assume responsibility for this `new` pointer.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that allows any user to access a Web site by creating an authenticated user. The example then clears the response headers and body and returns the user information to the client.  
  
> [!CAUTION]
>  The following code example authenticates all users by creating a custom `IHttpUser` pointer with the name `ValidUser`.  
  
 [!code-cpp[IAuthenticationProvider#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAuthenticationProvider/cpp/SetUser.cpp#1)]  
  
 The above code writes XML that is similar to the following to the response stream.  
  
```  
<?xml version="1.0" ?>  
<user   
    userName="ValidUser"   
    remoteName=" ValidUser"   
    passWord="[hidden]"   
    authType="Anonymous"   
    impersonationToken="NULL"   
    primaryToken="NULL"   
    supportsRoles="false"   
    userVariable="NULL" />  
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
 [IAuthenticationProvider Interface](../../web-development-reference/native-code-api-reference/iauthenticationprovider-interface.md)   
 [CHttpModule Class](../../web-development-reference/native-code-api-reference/chttpmodule-class.md)   
 [CHttpModule::OnAuthenticateRequest Method](../../web-development-reference/native-code-api-reference/chttpmodule-onauthenticaterequest-method.md)
