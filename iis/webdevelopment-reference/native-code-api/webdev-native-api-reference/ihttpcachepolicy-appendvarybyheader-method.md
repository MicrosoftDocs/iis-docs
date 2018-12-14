---
title: "IHttpCachePolicy::AppendVaryByHeader Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: dd9ade2d-8fe5-138d-f750-fba64f10d30d
caps.latest.revision: 25
author: "shirhatti"
manager: "wpickett"
---
# IHttpCachePolicy::AppendVaryByHeader Method
Appends the header value to the cache policy.  
  
## Syntax  
  
```cpp  
virtual HRESULT AppendVaryByHeader(  
   PCSTR pszHeader  
) = 0;  
```  
  
#### Parameters  
 `pszHeader`  
 A pointer to a null-terminated string that contains the custom header to append.  
  
 -or-  
  
 NULL.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that `pszHeader` is NULL.<br /><br /> -or-<br /><br /> Indicates that `pszHeader` is appended to the variable header list.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that heap memory is exhausted.|  
|E_FAIL|Indicates that the operation failed.|  
  
## Remarks  
 [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md) pointer as a parameter on the corresponding `virtual` method. To append a custom header, call the [IHttpContext::GetResponse](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getresponse-method.md) method, the [IHttpResponse::GetCachePolicy](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getcachepolicy-method.md) method, and finally the `AppendVaryByHeader` method.  
  
 `AppendVaryByHeader` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
 The current default implementer of the [IHttpCachePolicy](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-interface.md) interface declares a `private` buffer that contains variable header data. During the construction of an implementer, this buffer is initialized to empty. Every time `AppendVaryByHeader` is called, `AppendVaryByHeader` immediately returns S_OK if the `pszHeader` parameter is NULL. Otherwise, the buffer is expanded to hold a copy of `pszHeader`, including the null-termination character, plus 1 if the buffer is not currently empty. Then, if the buffer is not empty, the ',' character is appended to the buffer. Finally, the contents of `pszHeader`, including the null-termination character, are appended to the buffer.  
  
## Notes for Implementers  
 [IHttpCachePolicy](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-interface.md) implementers are responsible for copying the `pszHeader` parameter into a buffer, because the data associated with `pszHeader` is not guaranteed to be valid after the call to `AppendVaryByHeader`.  
  
## Notes for Callers  
 `IHttpCachePolicy` clients are responsible for passing either a NULL `pszHeader` parameter or a null-terminated string to the `AppendVaryByHeader` method. Clients are also responsible for disposing of `pszHeader` after the call to `AppendVaryByHeader`, because `IHttpCachePolicy` implementers copy `pszHeader` into an internal buffer.  
  
 The internal buffer used by the default `IHttpCachePolicy` implementer is a comma-delimited string of custom headers. Therefore, `pszHeader` must not include the ',' character.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCachePolicy Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-interface.md)