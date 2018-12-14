---
title: "IHttpApplicationResolveModulesProvider::RegisterModule Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 32674f32-24a8-a8cf-57f6-2c942ed29b26
caps.latest.revision: 14
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
 `parentModuleId`  
 [IN] The unique identifier for the parent module.  
  
 `pModuleFactory`  
 [IN] A pointer to the [IHttpModuleFactory](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-interface.md) interface for the HTTP module.  
  
 `pszModuleName`  
 [IN] A pointer to a string that contains the name of the module to register.  
  
 `pszModuleType`  
 [IN] A pointer to a string that contains the type of the module.  
  
 `pszModulePreCondition`  
 [IN] A pointer to a string that contains any preconditions for the module.  
  
 `dwRequestNotifications`  
 [IN] A bitmask value that contains the request notifications to set for the module. (Defined in [Httpserv.h](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md).)  
  
 `dwPostRequestNotifications`  
 [IN] A bitmask value that contains the post-request notifications to set for the module. (Defined in [Httpserv.h](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md).)  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_FILE_NOT_FOUND|Indicates that the module cannot be found.|  
|ERROR_INVALID_PARAMETER|Indicates that one of the parameters is not valid.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 Use the `RegisterModule` method inside a [CGlobalModule::OnGlobalApplicationResolveModules](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalapplicationresolvemodules-method.md) method to register additional modules that are not listed in the IIS configuration.  
  
> [!NOTE]
>  Do not confuse the `RegisterModule` method with the exported [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function that is required for all HTTP modules.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpApplicationResolveModulesProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplicationresolvemodulesprovider-interface.md)