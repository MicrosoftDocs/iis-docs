---
title: "IHttpUser::GetPrimaryToken Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7fa15aa2-ade4-b5e3-afe7-262602bad788
caps.latest.revision: 31
author: "shirhatti"
manager: "wpickett"
---
# IHttpUser::GetPrimaryToken Method
Returns the user primary token.  
  
## Syntax  
  
```cpp  
virtual HANDLE GetPrimaryToken(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `HANDLE` that represents the primary token for the user; otherwise, NULL.  
  
## Remarks  
 The [SupportsIsInRole](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-supportsisinrole-method.md) and [IsInRole](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-isinrole-method.md) methods return FALSE and E_NOTIMPL, respectively. Therefore, use the handle returned from either the [GetImpersonationToken](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-getimpersonationtoken-method.md) or `GetPrimaryToken` method for role-based authorization.  
  
## Notes for Implementers  
 [IHttpUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-interface.md) implementers are responsible for resource management with this data; therefore, `IHttpUser` implementers must call [CloseHandle](http://go.microsoft.com/fwlink/?LinkId=60019) on the handle when it is no longer needed.  
  
## Notes for Callers  
 `IHttpUser` implementers are responsible for resource management with this data; therefore, `IHttpUser` clients must not call `CloseHandle` on the returned handle when this data is no longer needed. Furthermore, clients must not change the state of the memory referenced by this handle, because an access violation will be thrown or the data will become invalid.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that clears the response headers and body and then returns user information to the client as an XML document.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpUser#5](IHttpUser#5)]  -->  
  
 The above code writes XML that is similar to the following to the response stream.  
  
```  
<?xml version="1.0" ?>  
<user primaryToken="valid" />  
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
 [IHttpUser Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-interface.md)