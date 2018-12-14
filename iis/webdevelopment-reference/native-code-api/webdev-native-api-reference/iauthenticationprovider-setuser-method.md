---
title: "IAuthenticationProvider::SetUser Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 14f0a659-e8ed-3010-11c5-9cb134455375
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IAuthenticationProvider::SetUser Method
Sets the authenticated user on the authentication provider.  
  
## Syntax  
  
```cpp  
virtual VOID SetUser(  
   IHttpUser* pUser  
) = 0;  
```  
  
#### Parameters  
 `pUser`  
 An authenticated pointer to an [IHttpUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-interface.md).  
  
## Remarks  
 If the `pUser` parameter is NULL, the default authentication continues.  
  
 Calling the `SetUser` method with a non-NULL `IHttpUser` pointer will authenticate that user immediately.  
  
## Notes for Implementers  
 [IAuthenticationProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iauthenticationprovider-interface.md) implementers assume responsibility for memory management with this data; therefore, `IAuthenticationProvider` implementers must call the [IHttpUser::DereferenceUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-dereferenceuser-method.md) method when they no longer need the `IHttpUser`.  
  
## Notes for Callers  
 `IAuthenticationProvider` callers are responsible for creating a custom `IHttpUser` pointer on the heap before calling `SetUser`; `IAuthenticationProvider` implementers then assume responsibility for this `new` pointer.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that allows any user to access a Web site by creating an authenticated user. The example then clears the response headers and body and returns the user information to the client.  
  
> [!CAUTION]
>  The following code example authenticates all users by creating a custom `IHttpUser` pointer with the name `ValidUser`.  
  
<!-- TODO: review snippet reference  [!CODE [IAuthenticationProvider#1](IAuthenticationProvider#1)]  -->  
  
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
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IAuthenticationProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iauthenticationprovider-interface.md)   
 [CHttpModule Class](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md)   
 [CHttpModule::OnAuthenticateRequest Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onauthenticaterequest-method.md)