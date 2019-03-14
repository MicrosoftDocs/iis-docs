---
title: "IAppHostSectionGroup::Item Property"
ms.date: "10/07/2016"
ms.assetid: 65aea56f-d6bb-8f65-12b8-4c4e8aa07e4f
---
# IAppHostSectionGroup::Item Property
Gets the nested configuration section group at the requested index.  
  
## Syntax  
  
```cpp  
HRESULT get_Item(  
   [in] VARIANT varIndex,  
   [out,  
   retval] IAppHostSectionGroup** ppSectionGroup  
);  
```  
  
### Parameters  
 `varIndex`  
 A `VARIANT` that contains the index of the nested configuration section group to return from the collection.  
  
 `ppSectionGroup`  
 A pointer to a pointer for the [IAppHostSectionGroup](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-interface.md) interface.  
  
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