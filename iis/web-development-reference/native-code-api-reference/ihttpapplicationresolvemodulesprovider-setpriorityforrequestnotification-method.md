---
title: "IHttpApplicationResolveModulesProvider::SetPriorityForRequestNotification Method"
ms.date: "10/07/2016"
ms.assetid: 374023e4-2b63-b86b-5fc0-0aebd236b178
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
  
### Parameters  
 `pszModuleName`  
 [IN] A pointer to a string that contains the name of the module.  
  
 `dwRequestNotification`  
 [IN] A bitmask value that contains the request notifications to set for the priority level. (Defined in [Httpserv.h](../../web-development-reference/native-code-api-reference/request-processing-constants.md).)  
  
 `pszPriorityAlias`  
 [IN] A pointer to a string that contains the priority alias. (Defined in [Httpserv.h](../../web-development-reference/native-code-api-reference/request-processing-constants.md).)  
  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpApplicationResolveModulesProvider Interface](../../web-development-reference/native-code-api-reference/ihttpapplicationresolvemodulesprovider-interface.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForRequestNotification Method](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md)