---
title: "IAppHostAdminManager::ConfigManager Property"
ms.date: "10/07/2016"
ms.assetid: 5cca2a0c-a91a-581b-a527-f19d588353d6
---
# IAppHostAdminManager::ConfigManager Property
Gets an [IAppHostConfigManager](../../web-development-reference/native-code-api-reference/iapphostconfigmanager-interface.md) interface that provides access to the physical files in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
HRESULT get_ConfigManager(  
   [out,  
   retval] IAppHostConfigManager** ppConfigManager  
);  
```  
  
### Parameters  
 `ppConfigManager`  
 A pointer to a pointer for an `IAppHostConfigManager` interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|HRESULT_FROM_WIN32(ERROR_INVALID_PARAMETER)|Indicates that `ppConfigManager` is NULL.|  
|HRESULT_FROM_WIN32(ERROR_NOT_ENOUGH_MEMORY)|Indicates that the method cannot allocate enough memory for the return value.|  
  
## Example  
 The following code example demonstrates the role of the `IAppHostConfigManager` interface in accessing the configuration system.  
  
<!-- TODO: review snippet reference  [!CODE [IAppHostAdminLibrary#7](IAppHostAdminLibrary#7)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostAdminManager Interface](../../web-development-reference/native-code-api-reference/iapphostadminmanager-interface.md)