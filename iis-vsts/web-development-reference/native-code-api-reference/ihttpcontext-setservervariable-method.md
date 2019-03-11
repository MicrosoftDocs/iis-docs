---
title: "IHttpContext::SetServerVariable Method"
ms.date: "10/07/2016"
ms.assetid: 1099f28d-b795-fd21-3832-53f2531169a4
---
# IHttpContext::SetServerVariable Method
Sets a server variable to a specified value.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetServerVariable(  
   PCSTR pszVariableName,  
   PCWSTR pszVariableValue  
) = 0;  
```  
  
### Parameters  
 `pszVariableName`  
 [IN] A pointer to a string that contains the name of the server variable to set.  
  
 `pszVariableValue`  
 [IN] A pointer to a string that contains the value of the server variable to set.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `SetServerVariable` method specifies the values for Common Gateway Interface (CGI) server variables. The server variable specified by the `pszVariableName` parameter can be a custom variable or a variable defined in Request for Comments (RFC) 3875, "The Common Gateway Interface (CGI) Version 1.1."  
  
> [!NOTE]
>  The server variable specified by the `pszVariableName` parameter is created if it does not exist.  
  
## Example  
 The following code example demonstrates how to use the `SetServerVariable` method to create an HTTP module that sets the value of the `SERVER_NAME` server variable to an example value.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextSetServerVariable#1](IHttpContextSetServerVariable#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::GetServerVariable Method](../../web-development-reference\native-code-api-reference/ihttpcontext-getservervariable-method.md)