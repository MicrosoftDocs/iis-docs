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
 [OUT] Points to the [IHttpTokenEntry](../../web-development-reference\webdev-native-api-reference/ihttptokenentry-interface.md) interface that represents the token.  
  
 `pszDefaultDomain`  
 [IN] Optional default domain name.  
  
 `pSockAddr`  
 [IN] Optional socket address.  
  
 `pHttpTraceContext`  
 [IN] Optional pointer to an [IHttpTraceContext](../../web-development-reference\webdev-native-api-reference/ihttptracecontext-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer2 Interface](../../web-development-reference\webdev-native-api-reference/ihttpserver2-interface.md)