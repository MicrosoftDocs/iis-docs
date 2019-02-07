---
title: "IAppDomainInfoEnum::Reset Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9cfb056c-d51e-a932-9892-8d32a26d072c
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# IAppDomainInfoEnum::Reset Method
Initializes the [IAppDomainInfoEnum](../../web-development-reference\native-code-api-reference/iappdomaininfoenum-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual HRESULT __stdcall Reset(  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 You must call the `Reset` method before you call any other methods on the `IAppDomainInfoEnum` interface. You can also call this method when you want to reinitialize the interface to the beginning.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [IAppDomainInfoEnum Interface](../../web-development-reference\native-code-api-reference/iappdomaininfoenum-interface.md)   
 [IAppDomainInfoEnum::GetData Method](../../web-development-reference\native-code-api-reference/iappdomaininfoenum-getdata-method.md)   
 [IAppDomainInfoEnum::GetData Method](../../web-development-reference\native-code-api-reference/iappdomaininfoenum-getdata-method.md)