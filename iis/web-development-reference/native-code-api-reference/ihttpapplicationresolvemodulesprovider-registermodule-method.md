---
title: "IHttpApplicationResolveModulesProvider::RegisterModule Method"
ms.date: "10/07/2016"
ms.assetid: 32674f32-24a8-a8cf-57f6-2c942ed29b26
---
# IHttpApplicationResolveModulesProvider::RegisterModule Method

Registers an HTTP module.  
  
## Syntax  
  
```cpp  
virtual HRESULT RegisterModule(  
   IN HTTP_MODULE_ID parentModuleId,  
   IN IHttpModuleFactory* pModuleFactory,  
   IN PCWSTR pszModuleName,  
   IN PCWSTR pszModuleType,  
   IN PCWSTR pszModulePreCondition,  
   IN DWORD dwRequestNotifications,  
   IN DWORD dwPostRequestNotifications  
) = 0;  
```  
  
### Parameters  

 `parentModuleId`  
 [IN] The unique identifier for the parent module.  
  
 `pModuleFactory`  
 [IN] A pointer to the [IHttpModuleFactory](../../web-development-reference/native-code-api-reference/ihttpmodulefactory-interface.md) interface for the HTTP module.  
  
 `pszModuleName`  
 [IN] A pointer to a string that contains the name of the module to register.  
  
 `pszModuleType`  
 [IN] A pointer to a string that contains the type of the module.  
  
 `pszModulePreCondition`  
 [IN] A pointer to a string that contains any preconditions for the module.  
  
 `dwRequestNotifications`  
 [IN] A bitmask value that contains the request notifications to set for the module. (Defined in [Httpserv.h](../../web-development-reference/native-code-api-reference/request-processing-constants.md).)  
  
 `dwPostRequestNotifications`  
 [IN] A bitmask value that contains the post-request notifications to set for the module. (Defined in [Httpserv.h](../../web-development-reference/native-code-api-reference/request-processing-constants.md).)  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_FILE_NOT_FOUND|Indicates that the module cannot be found.|  
|ERROR_INVALID_PARAMETER|Indicates that one of the parameters is not valid.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  

 Use the `RegisterModule` method inside a [CGlobalModule::OnGlobalApplicationResolveModules](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalapplicationresolvemodules-method.md) method to register additional modules that are not listed in the IIS configuration.  
  
> [!NOTE]
>  Do not confuse the `RegisterModule` method with the exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function that is required for all HTTP modules.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [IHttpApplicationResolveModulesProvider Interface](../../web-development-reference/native-code-api-reference/ihttpapplicationresolvemodulesprovider-interface.md)
