---
title: "IAppHostConfigLocation::AddConfigSection Method"
ms.date: "10/07/2016"
ms.assetid: c26ddb6b-2166-3486-870f-fb5b0574feb1
---
# IAppHostConfigLocation::AddConfigSection Method
Adds a configuration section to the current configuration location.  
  
## Syntax  
  
```cpp  
HRESULT AddConfigSection(  
   [in] BSTR bstrSectionName,  
   [out,  
   retval] IAppHostElement** ppAdminElement  
);  
```  
  
### Parameters  
 `bstrSectionName`  
 A `BSTR` that contains the name of the section to add.  
  
 `ppAdminElement`  
 A pointer to a pointer for an [IAppHostElement](../../web-development-reference\native-code-api-reference/iapphostelement-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_ALREADY_EXISTS|Indicates that the configuration section already exists|  
|ERROR_INVALID_DATA|Indicates that the data is invalid.|  
  
## Remarks  
 Configuration locations enable the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system to customize the configuration based on the path of the content that the location represents. For instance, you may want to configure the `system.webServer/asp` configuration section for each Web site. In that case, you would remove the configuration section from the default location in the ApplicationHost.config configuration system file. To enable the configuration section for a Web site, you would add the configuration section under the Web site's configuration location.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostConfigLocation Interface](../../web-development-reference\native-code-api-reference/iapphostconfiglocation-interface.md)