---
title: "IHttpContext::GetServerVariable Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7771e6fa-b157-4df6-5e6b-97749a3c9fdb
caps.latest.revision: 31
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
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
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::SetServerVariable Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-setservervariable-method.md)