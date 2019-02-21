---
title: "IUriKey::UpdateFrequentlyHitTickCount Method"
ms.date: "10/07/2016"
ms.assetid: 8996d0b8-7b23-4394-aee6-a809965e0e7e
---
# IUriKey::UpdateFrequentlyHitTickCount Method
Increments a counter each time the URI is requested.  
  
## Syntax  
  
```cpp  
virtual VOID UpdateFrequentlyHitTickCount(  
   DWORD   dwTicks  
) = 0;  
```  
  
### Parameters  
 `dwTicks`  
 [OUT] Ticks counter increments each time the URI is requested.  
  
## Return Value  
 `VOID`.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [IUriKey Interface](../../web-development-reference\native-code-api-reference/iurikey-interface.md)