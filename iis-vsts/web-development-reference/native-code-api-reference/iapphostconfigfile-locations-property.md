---
title: "IAppHostConfigFile::Locations Property"
ms.date: "10/07/2016"
ms.assetid: 731ea11c-d7af-219c-4936-9bb386f71625
---
# IAppHostConfigFile::Locations Property
Returns a collection of [IAppHostConfigLocation](../../web-development-reference\native-code-api-reference/iapphostconfiglocation-interface.md) interfaces that represent location tags defined for the current configuration file.  
  
## Syntax  
  
```cpp  
HRESULT get_Locations(  
   [out,  
   retval] IAppHostConfigLocationCollection** ppLocations  
);  
```  
  
### Parameters  
 `ppLocations`  
 A pointer to a pointer for an [IAppHostConfigLocationCollection](../../web-development-reference\native-code-api-reference/iapphostconfiglocationcollection-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 If the operation is successful, the collection returned in the `ppLocations` parameter will contain a pointer to an [IAppHostConfigLocation](../../web-development-reference\native-code-api-reference/iapphostconfiglocation-interface.md) interface for each location tag in the current configuration file.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostConfigFile Interface](../../web-development-reference\native-code-api-reference/iapphostconfigfile-interface.md)   
 [IAppHostConfigLocation Interface](../../web-development-reference\native-code-api-reference/iapphostconfiglocation-interface.md)   
 [IAppHostConfigLocationCollection Interface](../../web-development-reference\native-code-api-reference/iapphostconfiglocationcollection-interface.md)