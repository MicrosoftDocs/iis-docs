---
title: "IAppHostConfigLocationCollection::Item Property"
description: The IAppHostConfigLocationCollection::Item property gets a configuration location at the requested index from the current collection.
ms.date: "10/07/2016"
ms.assetid: 7752989d-a9b4-2c37-c4a3-886923b0e5f8
---
# IAppHostConfigLocationCollection::Item Property
Gets a configuration location at the requested index from the current collection.  
  
## Syntax  
  
```cpp  
HRESULT get_Item(  
   [in] VARIANT varIndex,  
   [out,  
   retval] IAppHostConfigLocation** ppLocation  
);  
```  
  
### Parameters  
 `varIndex`  
 A `VARIANT` that contains the index of the requested location.  
  
 `ppLocation`  
 A pointer to a pointer for an [IAppHostConfigLocation](../../web-development-reference/native-code-api-reference/iapphostconfiglocation-interface.md) interface.  
  
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
 [IAppHostConfigLocationCollection Interface](../../web-development-reference/native-code-api-reference/iapphostconfiglocationcollection-interface.md)
