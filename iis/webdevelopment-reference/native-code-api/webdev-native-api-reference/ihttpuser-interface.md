---
title: "IHttpUser Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: bf06e01f-21ea-14da-9bf5-aef117d9800c
caps.latest.revision: 47
author: "shirhatti"
manager: "wpickett"
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
|[DereferenceUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-dereferenceuser-method.md)|Decrements the user internal reference count.|  
|[GetAuthenticationType](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-getauthenticationtype-method.md)|Returns the request authentication type.|  
|[GetImpersonationToken](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-getimpersonationtoken-method.md)|Returns the user impersonation token.|  
|[GetPassword](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-getpassword-method.md)|Returns the user password.|  
|[GetPrimaryToken](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-getprimarytoken-method.md)|Returns the primary user token.|  
|[GetRemoteUserName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-getremoteusername-method.md)|Returns the remote user name.|  
|[GetUserName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-getusername-method.md)|Returns the user name.|  
|[GetUserVariable](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-getuservariable-method.md)|Returns the custom user data by name.|  
|[IsInRole](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-isinrole-method.md)|Returns a value that indicates whether the user is authorized for a named role.|  
|[ReferenceUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-referenceuser-method.md)|Increments the user internal reference count.|  
|[SupportsIsInRole](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-supportsisinrole-method.md)|Returns a value that indicates whether role support is enabled for the user.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 You can retrieve an `IHttpUser` pointer from an [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md) pointer by calling the [IHttpContext::GetUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getuser-method.md) method. To gain access to these interfaces, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
## Example  
 The following code example demonstrates how to create an HTTP module that clears the response headers and body and then returns user information to the client as an XML document.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpUser#1](IHttpUser#1)]  -->  
  
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
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)