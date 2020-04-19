---
title: "IAppHostConfigLocation::Item Property"
ms.date: "10/07/2016"
ms.assetid: 7e531625-e3b7-ab30-3c6a-c1a7a2977b45
---
# IAppHostConfigLocation::Item Property
Gets the requested configuration section from the current location.  
  
## Syntax  
  
```cpp  
HRESULT Item(  
   [in] VARIANT cIndex,  
   [out,  
   retval] IAppHostElement** ppSection  
);  
```  
  
### Parameters  
 `cIndex`  
 A `VARIANT` that contains the index of the requested configuration section. The index can contain a `BSTR` that contains the location path.  
  
 `ppSection`  
 A pointer to a pointer for an [IAppHostElement](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_INDEX|Indicates that the requested index was not found.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostConfigLocation Interface](../../web-development-reference/native-code-api-reference/iapphostconfiglocation-interface.md)
