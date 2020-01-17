---
title: "IHttpUser::IsInRole Method"
ms.date: "10/07/2016"
ms.assetid: 578b34a8-b697-0f48-20d0-4cf448388c91
---
# IHttpUser::IsInRole Method
Returns a value that indicates whether the user is authorized for a named role.  
  
## Syntax  
  
```cpp  
virtual HRESULT IsInRole(  
   IN PCWSTR pszRoleName,  
   OUT BOOL* pfInRole  
) = 0;  
```  
  
### Parameters  
 `pszRoleName`  
 [IN] A pointer to a constant null-terminated Unicode string that contains the name of the role.  
  
 `pfInRole`  
 [OUT] A pointer to a `BOOL` that indicates whether the user is authorized for the role specified by `pszRoleName`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_NOTIMPL|Indicates that the `IsInRole` method was not implemented.|  
  
## Remarks  
 Call the `IsInRole` method only if the [SupportsIsInRole](../../web-development-reference/native-code-api-reference/ihttpuser-supportsisinrole-method.md) method first returns `true` on the same [IHttpUser](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md) pointer.  
  
 The `IsInRole` return value depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   If the `IHttpUser` implementer handles Anonymous authentication, the dereferenced `pfInRole` parameter is set to `true` only if the `pszRoleName` parameter is either NULL or empty. `IsInRole` then always returns S_OK.  
  
-   If the `IHttpUser` implementer handles Basic, Certification Mapping, SSPI, or Custom authentication, the `pfInRole` parameter is unmodified, and `IsInRole` returns E_NOTIMPL immediately.  
  
-   If the `IHttpUser` implementer handles Managed authentication, the `pfInRole` parameter is unmodified, and `IsInRole` returns E_INVALIDARG immediately if either parameter is NULL. Otherwise, `pfInRole` is set to `true`, and `IsInRole` returns S_OK only if the user is in the role.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that clears the response headers and body and then returns user information to the client as an XML document.  
  
  
  
 The above code writes XML that is similar to the following to the response stream.  
  
```  
<?xml version="1.0" ?>  
<user supportsRoles="true" isInRole="false" />  
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