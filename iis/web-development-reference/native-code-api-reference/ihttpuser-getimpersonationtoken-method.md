---
title: "IHttpUser::GetImpersonationToken Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 25f33eb6-64ac-aae2-92fe-8d4e03a1142e
caps.latest.revision: 34
author: "shirhatti"
manager: "wpickett"
---
# IHttpUser::GetImpersonationToken Method
Returns the user impersonation token.  
  
## Syntax  
  
```cpp  
virtual HANDLE GetImpersonationToken(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `HANDLE` that represents the impersonation token for the user; otherwise, NULL.  
  
## Remarks  
 The [SupportsIsInRole](../../web-development-reference\webdev-native-api-reference/ihttpuser-supportsisinrole-method.md) and [IsInRole](../../web-development-reference\webdev-native-api-reference/ihttpuser-isinrole-method.md) methods return FALSE and E_NOTIMPL, respectively, from the default implementation. Therefore, use the handle that is returned from either the `GetImpersonationToken` or [GetPrimaryToken](../../web-development-reference\webdev-native-api-reference/ihttpuser-getprimarytoken-method.md) method for role-based authorization.  
  
## Notes for Implementers  
 [IHttpUser](../../web-development-reference\webdev-native-api-reference/ihttpuser-interface.md) implementers are responsible for resource management with this data; therefore, `IHttpUser` implementers must call [CloseHandle](http://go.microsoft.com/fwlink/?LinkId=60019) on the handle when it is no longer needed.  
  
## Notes for Callers  
 `IHttpUser` implementers are responsible for resource management with this data; therefore, `IHttpUser` clients must not call `CloseHandle` on the returned handle when this data is no longer needed. Furthermore, clients must not change the state of the memory referenced by this handle, because an access violation will be thrown or the data will become invalid.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that clears the response headers and body and then returns user information to the client as an XML document.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpUser#3](IHttpUser#3)]  -->  
  
 The above code writes XML that is similar to the following to the response stream.  
  
```  
<?xml version="1.0" ?>  
<user impersonationToken="valid" />  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpUser Interface](../../web-development-reference\webdev-native-api-reference/ihttpuser-interface.md)