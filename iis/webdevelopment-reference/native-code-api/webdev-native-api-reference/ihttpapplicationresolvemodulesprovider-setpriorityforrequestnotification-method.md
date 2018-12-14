---
title: "IHttpApplicationResolveModulesProvider::SetPriorityForRequestNotification Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 374023e4-2b63-b86b-5fc0-0aebd236b178
caps.latest.revision: 11
author: "shirhatti"
manager: "wpickett"
---
# IHttpApplicationResolveModulesProvider::SetPriorityForRequestNotification Method
Sets the request-level priority for a specific module.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetPriorityForRequestNotification(  
   IN PCWSTR pszModuleName,  
   IN DWORD dwRequestNotification,  
   IN PCWSTR pszPriorityAlias  
) = 0;  
```  
  
#### Parameters  
 `pszModuleName`  
 [IN] A pointer to a string that contains the name of the module.  
  
 `dwRequestNotification`  
 [IN] A bitmask value that contains the request notifications to set for the priority level. (Defined in [Httpserv.h](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md).)  
  
 `pszPriorityAlias`  
 [IN] A pointer to a string that contains the priority alias. (Defined in [Httpserv.h](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md).)  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that one of the parameters is not valid.|  
  
## Remarks  
 IIS uses the `SetPriorityForRequestNotification` method to specify the priority level for the HTTP module that is specified in the `pszModuleName` parameter.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpApplicationResolveModulesProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplicationresolvemodulesprovider-interface.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForRequestNotification Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md)