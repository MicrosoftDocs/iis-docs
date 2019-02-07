---
title: "IAppDomainInfo::GetIsIdle Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: cf1700cc-952e-4215-4343-ef4e8ebd9fb3
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
---
# IAppDomainInfo::GetIsIdle Method
Retrieves the idle state of the application domain.  
  
## Syntax  
  
```cpp  
virtual HRESULT __stdcall GetIsIdle(  
   DWORD* pfIsIdle  
) = 0;  
```  
  
#### Parameters  
 `pfIsIdle`  
 A pointer to a `DWORD` that contains the idle state of the application domain since the last call. A nonzero value indicates that the application domain is idle; 0 indicates that the application domain is not idle.  
  
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
|Header|Webhost.h|  
  
## See Also  
 [IAppDomainInfo Interface](../../web-development-reference\webdev-native-api-reference/iappdomaininfo-interface.md)