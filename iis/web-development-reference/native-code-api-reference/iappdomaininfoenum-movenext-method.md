---
title: "IAppDomainInfoEnum::MoveNext Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9746ee49-951d-a658-169a-9527bc1d57c8
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IAppDomainInfoEnum::MoveNext Method
Moves to the next [IAppDomainInfo](../../web-development-reference\native-code-api-reference/iappdomaininfo-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual HRESULT __stdcall MoveNext(  
   DWORD* pfMoreItems  
) = 0;  
```  
  
#### Parameters  
 `pfMoreItems`  
 A pointer to a `DWORD` that indicates whether `MoveNext` was successful.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The first call to the `MoveNext` method moves to the first [IAppDomainInfo](../../web-development-reference\native-code-api-reference/iappdomaininfo-interface.md) interface. If the `pfMoreItems` parameter is nonzero, `MoveNext` moves to the next `IAppDomainInfo` interface, after which you can call the [GetData](../../web-development-reference\native-code-api-reference/iappdomaininfoenum-getdata-method.md) method. If `pfMoreItems` is 0, there are no more `IAppDomainInfo` objects in the application domain.  
  
 You must call the [Reset](../../web-development-reference\native-code-api-reference/iappdomaininfoenum-reset-method.md) method before you call `MoveNext` the first time.  
  
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
 [IAppDomainInfoEnum::Reset Method](../../web-development-reference\native-code-api-reference/iappdomaininfoenum-reset-method.md)