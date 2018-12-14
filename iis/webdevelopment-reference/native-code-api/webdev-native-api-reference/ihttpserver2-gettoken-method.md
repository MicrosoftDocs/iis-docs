---
title: "IHttpServer2::GetToken Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 797d704e-9540-4b04-bd6a-6d01d48819a4
caps.latest.revision: 4
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer2::GetToken Method
Retrieves an authentication token given a user name, password, and login method.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetToken(  
   _In_ PCWSTR                     pszUserName,  
   _In_ PCWSTR                     pszPassword,  
   _In_ DWORD                      dwLogonMethod,   _Outptr_ IHttpTokenEntry **      ppTokenEntry,  
   _In_opt_ PCWSTR                 pszDefaultDomain = NULL,  
   _In_opt_ PSOCKADDR              pSockAddr = NULL,  
   _In_opt_ IHttpTraceContext *    pHttpTraceContext = NULL  
) = 0;  
```  
  
#### Parameters  
 `pszUserName`  
 [IN] Points to the user name.  
  
 `pszPassword`  
 [IN] Points to the password.  
  
 `dwLogonMethod`  
 [IN] The logon method.  
  
 `ppTokenEntry`  
 [OUT] Points to the [IHttpTokenEntry](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-interface.md) interface that represents the token.  
  
 `pszDefaultDomain`  
 [IN] Optional default domain name.  
  
 `pSockAddr`  
 [IN] Optional socket address.  
  
 `pHttpTraceContext`  
 [IN] Optional pointer to an [IHttpTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer2 Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver2-interface.md)