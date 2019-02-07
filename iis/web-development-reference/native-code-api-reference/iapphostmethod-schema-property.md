---
title: "IAppHostMethod::Schema Property | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d611032c-f7bd-43d0-ab3a-9c6cfa2ffd65
caps.latest.revision: 7
author: "shirhatti"
manager: "wpickett"
---
# IAppHostMethod::Schema Property
Gets the schema assigned to the current method.  
  
## Syntax  
  
```cpp  
HRESULT Schema(  
   [out,  
   retval] IAppHostMethodSchema ** ppMethodSchema  
);  
```  
  
#### Parameters  
 `ppMethodSchema`  
 Contains the schema for the specified [IAppHostMethod Interface](../../web-development-reference\webdev-native-api-reference/iapphostmethod-interface.md).  
  
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
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostMethod Interface](../../web-development-reference\webdev-native-api-reference/iapphostmethod-interface.md)   
 [IAppHostMethodInstance Interface](../../web-development-reference\webdev-native-api-reference/iapphostmethodinstance-interface.md)