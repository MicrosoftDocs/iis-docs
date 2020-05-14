---
title: "IHttpUser Interface"
ms.date: "10/07/2016"
ms.assetid: bf06e01f-21ea-14da-9bf5-aef117d9800c
---
# IHttpUser Interface
Provides request-specific information about a user. This information includes data such as credentials and role-based authorization.  
  
## Syntax  
  
```cpp  
class IHttpUser  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpUser` interface.  
  
|Topic|Description|  
|-----------|-----------------|  
|[DereferenceUser](../../web-development-reference/native-code-api-reference/ihttpuser-dereferenceuser-method.md)|Decrements the user internal reference count.|  
|[GetAuthenticationType](../../web-development-reference/native-code-api-reference/ihttpuser-getauthenticationtype-method.md)|Returns the request authentication type.|  
|[GetImpersonationToken](../../web-development-reference/native-code-api-reference/ihttpuser-getimpersonationtoken-method.md)|Returns the user impersonation token.|  
|[GetPassword](../../web-development-reference/native-code-api-reference/ihttpuser-getpassword-method.md)|Returns the user password.|  
|[GetPrimaryToken](../../web-development-reference/native-code-api-reference/ihttpuser-getprimarytoken-method.md)|Returns the primary user token.|  
|[GetRemoteUserName](../../web-development-reference/native-code-api-reference/ihttpuser-getremoteusername-method.md)|Returns the remote user name.|  
|[GetUserName](../../web-development-reference/native-code-api-reference/ihttpuser-getusername-method.md)|Returns the user name.|  
|[GetUserVariable](../../web-development-reference/native-code-api-reference/ihttpuser-getuservariable-method.md)|Returns the custom user data by name.|  
|[IsInRole](../../web-development-reference/native-code-api-reference/ihttpuser-isinrole-method.md)|Returns a value that indicates whether the user is authorized for a named role.|  
|[ReferenceUser](../../web-development-reference/native-code-api-reference/ihttpuser-referenceuser-method.md)|Increments the user internal reference count.|  
|[SupportsIsInRole](../../web-development-reference/native-code-api-reference/ihttpuser-supportsisinrole-method.md)|Returns a value that indicates whether role support is enabled for the user.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 You can retrieve an `IHttpUser` pointer from an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) pointer by calling the [IHttpContext::GetUser](../../web-development-reference/native-code-api-reference/ihttpcontext-getuser-method.md) method. To gain access to these interfaces, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
## Example  
 The following code example demonstrates how to create an HTTP module that clears the response headers and body and then returns user information to the client as an XML document.  
  
 The above code writes XML that is similar to the following to the response stream.  
  
```  
<?xml version="1.0" ?>  
<user
    userName="DOMAIN\user"
    remoteName=" DOMAIN\user"
    passWord="[hidden]"
    authType="Negotiate"
    impersonationToken="valid"
    primaryToken="valid"
    supportsRoles="true"
    isInRole="false"
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
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
