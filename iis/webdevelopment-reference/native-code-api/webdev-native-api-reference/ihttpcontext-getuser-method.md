---
title: "IHttpContext::GetUser Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f98e6f16-fa74-fa56-d9cb-26529064e4fa
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::GetUser Method
Retrieves the user information container for the current context.  
  
## Syntax  
  
```cpp  
virtual IHttpUser* GetUser(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-interface.md) interface.  
  
## Remarks  
 The `GetUser` method returns an `IHttpUser` interface, which contains several methods for retrieving security-related information for the current request. For example, you can use the [IHttpUser::GetUserName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-getusername-method.md) and [IHttpUser::GetPassword](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-getpassword-method.md) methods to retrieve the user credentials for an authenticated user.  
  
> [!NOTE]
>  The HTTP context object owns the lifetime of the `IHttpUser` interface that is returned by the `GetUser` method. Therefore, you do not free this pointer when you write HTTP modules.  
  
## Example  
 The following code example demonstrates how to use the `GetUser` method to create an HTTP module that retrieves an `IHttpUser` interface. The example then uses the `IHttpUser::GetUserName` method to retrieve the current user name. If the Web site is using anonymous authentication, the user name will be blank, and the HTTP module will return a message that the Web site is using anonymous authentication. Otherwise, the HTTP module will return the current user name to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetUser#1](IHttpContextGetUser#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)   
 [IHttpUser Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-interface.md)