---
title: "IHttpUser::GetUserVariable Method"
ms.date: "10/07/2016"
ms.assetid: 44dee11b-8008-48d9-b6a6-df173acd3507
---
# IHttpUser::GetUserVariable Method
Returns the custom user data by name.  
  
## Syntax  
  
```cpp  
virtual PVOID GetUserVariable(  
   IN PCSTR pszVariableName  
) = 0;  
```  
  
### Parameters  
 `pszVariableName`  
 [IN] A pointer to a constant null-terminated string that contains the variable name of the data to retrieve.  
  
## Return Value  
 A `void` pointer that contains the upcast custom data.  
  
## Remarks  
 The default is `HTTP_USER_VARIABLE_SID`, which is defined in the Httpserv.h header file.  
  
## Notes for Implementers  
 [IHttpUser](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpUser` implementers that use dynamic memory allocation must release or `delete` the `void` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IHttpUser` implementers are responsible for memory management with this data; therefore, `IHttpUser` clients must not release or `delete` the returned `void` pointer when this data is no longer needed. Furthermore, clients must not change the state of the memory referenced by this `void` pointer, because an access violation will be thrown or the data will become invalid.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that clears the response headers and body and then returns user information to the client as an XML document.  
  
  
  
 The above code writes XML that is similar to the following to the response stream.  
  
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