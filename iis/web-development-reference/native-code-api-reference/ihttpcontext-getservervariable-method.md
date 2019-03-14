---
title: "IHttpContext::GetServerVariable Method"
ms.date: "10/07/2016"
ms.assetid: 7771e6fa-b157-4df6-5e6b-97749a3c9fdb
---
# IHttpContext::GetServerVariable Method
Retrieves a specific server variable.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetServerVariable(  
   PCSTR pszVariableName,  
   PCWSTR * ppszValue,  
   DWORD * pcchValueLength  
) = 0;  
virtual HRESULT GetServerVariable(  
   PCSTR   pszVariableName,  
   PCSTR * ppszValue,  
   DWORD * pcchValueLength  
) = 0;  
```  
  
### Parameters  
 `pszVariableName`  
 A pointer to a string that contains the name of the server variable to return.  
  
 `ppszValue`  
 The address of a pointer to a string buffer that receives a copy of the server variable.  
  
 `pcchValueLengthr`  
 A pointer to a `DWORD` buffer that receives the length of the `ppszValue` parameter.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_INDEX|Indicates that the parameter is not valid.|  
  
## Remarks  
 The `GetServerVariable` method retrieves a server variable specified by the `pszVariableName` parameter from the current HTTP context, and it returns the value in a buffer pointed to by the `ppszValue` parameter. The server variable specified by the `pszVariableName` parameter can be a custom variable or a variable defined in Requests for Comments (RFC) 3875, "The Common Gateway Interface (CGI) Version 1.1."  
  
> [!NOTE]
>  The `GetServerVariable` method supports returning both ANSI and Unicode values through overloaded methods. The buffer pointed to by the `ppszValue` parameter can be either a `PCWSTR` or `PCSTR` buffer.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::SetServerVariable Method](../../web-development-reference/native-code-api-reference/ihttpcontext-setservervariable-method.md)