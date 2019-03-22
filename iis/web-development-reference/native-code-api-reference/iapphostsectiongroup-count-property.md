---
title: "IAppHostSectionGroup::Count Property"
ms.date: "10/07/2016"
ms.assetid: eeb5d8fa-6242-c708-866e-895fffc2d725
---
# IAppHostSectionGroup::Count Property
Gets the current number of configuration section groups that are nested in the current section group.  
  
## Syntax  
  
```cpp  
HRESULT get_Count(  
   [out,  
   retval] ULONG* pcSectionGroup  
);  
```  
  
### Parameters  
 `pcSectionGroup`  
 A pointer to a `ULONG` that contains the number of configuration section groups that are nested under the current configuration section group object.  
  
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
 [IAppHostSectionGroup Interface](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-interface.md)