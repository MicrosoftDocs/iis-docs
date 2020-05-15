---
title: "IAppHostConfigManager::GetConfigFile Method"
ms.date: "10/07/2016"
ms.assetid: addd9da3-1dc3-a705-9f0f-95ffa02025de
---
# IAppHostConfigManager::GetConfigFile Method

Gets a configuration file that is represented by the requested configuration path.  
  
## Syntax  
  
```cpp  
HRESULT GetConfigFile(  
   [in,  
   string] BSTR bstrConfigPath,  
   [out,  
   retval] IAppHostConfigFile** ppConfigFile  
);  
```  
  
### Parameters  

 `bstrConfigPath`  
 A `BSTR` that contains the configuration file path being requested.  
  
 `ppConfigFile`  
 A pointer to a pointer for an [IAppHostConfigFile](../../web-development-reference/native-code-api-reference/iapphostconfigfile-interface.md) interface.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  

 This method provides access to the physical configuration files represented by a configuration system path. For example, passing "MACHINE/WEBROOT/APPHOST" to the `bstrConfigPath` parameter would return an `IAppHostConfigFile` instance in the `ppConfigFile` parameter that represents the ApplicationHost.config file.  
  
## Example  

 The following code example obtains a configuration file, adds a new section group and a new section, sets properties on the new section, and then commits the changes to the configuration system.  
  
 [!code-cpp[IAppHostAdminLibrary#7](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostSectionGroupAddSectionGroup.cpp#7)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  

 [IAppHostConfigManager Interface](../../web-development-reference/native-code-api-reference/iapphostconfigmanager-interface.md)
