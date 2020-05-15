---
title: "IHttpUser::GetUserName Method"
ms.date: "10/07/2016"
ms.assetid: a958e0e3-4166-13a2-ab9d-ff79fd8aa67a
---
# IHttpUser::GetUserName Method

Returns the user name.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetUserName(  
   VOID  
) = 0;  
```  
  
### Parameters  

 This method takes no parameters.  
  
## Return Value  

 A pointer to a constant null-terminated Unicode string that contains the user name.  
  
## Remarks  

 The value returned depends on the authentication type. The authentication type is returned from the [GetAuthenticationType](../../web-development-reference/native-code-api-reference/ihttpuser-getauthenticationtype-method.md) method.  
  
 The following table shows authentication types with the associated user name values or pattern.  
  
|Authentication type|User name|  
|-------------------------|---------------|  
|Anonymous|Empty string|  
|Basic|*domain*\\*username*|  
|Digest|domain\username or username|  
|Forms|username|  
|Windows|*domain*\\*username*|  
  
## Notes for Implementers  

 `IHttpUser` implementers are responsible for memory management with this data; therefore, `IHttpUser` implementers that use dynamic memory allocation must release or call `delete` on the `PCWSTR` pointer when it is no longer needed.  
  
## Notes for Callers  

 `IHttpUser` implementers are responsible for memory management with this data; therefore, `IHttpUser` clients must not release or call `delete` on the returned `PCWSTR` pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this `PCWSTR`; otherwise, an access violation will be thrown or the data will become invalid.  
  
## Example  

 The following code example demonstrates how to create an HTTP module that clears the response headers and body and then returns user information to the client as an XML document.  
  
 The above code writes XML to the response stream similar to the following.  
  
```  
<?xml version="1.0" ?>  
<user userName="DOMAIN\user" />  
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
 [IHttpUser::GetPassword Method](../../web-development-reference/native-code-api-reference/ihttpuser-getpassword-method.md)   
 [IHttpUser::GetRemoteUserName Method](../../web-development-reference/native-code-api-reference/ihttpuser-getremoteusername-method.md)
