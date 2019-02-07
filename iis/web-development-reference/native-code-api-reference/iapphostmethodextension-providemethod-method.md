---
title: "IAppHostMethodExtension::ProvideMethod Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 393c6056-eaee-4f74-b81a-8a1688e1baff
caps.latest.revision: 7
author: "shirhatti"
manager: "wpickett"
---
# IAppHostMethodExtension::ProvideMethod Method
Provides a method for an [IAppHostElement Interface](../../web-development-reference\native-code-api-reference/iapphostelement-interface.md) that can provide extended functionality to the element.  
  
## Syntax  
  
```cpp  
HRESULT ProvideMethod(  
   [in] IAppHostMethod * pMethod,  
   [in] IAppHostMethodInstance * pMethodInstance,  
   [in] IAppHostElement * pElement  
);  
```  
  
#### Parameters  
 `pMethod`  
 The static [IAppHostMethod Interface](../../web-development-reference\native-code-api-reference/iapphostmethod-interface.md) object in `pElement`.  
  
 `pMethodInstance`  
 The current [IAppHostMethodInstance Interface](../../web-development-reference\native-code-api-reference/iapphostmethodinstance-interface.md) that holds the invocation list.  
  
 `pElement`  
 The parent [IAppHostElement Interface](../../web-development-reference\native-code-api-reference/iapphostelement-interface.md) of `pMethod`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The method may read input properties and write output properties within an instance of this method...  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostMethodExtension Interface](../../web-development-reference\native-code-api-reference/iapphostmethodextension-interface.md)