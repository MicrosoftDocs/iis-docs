---
title: "IAppHostAdminManager::GetAdminSection Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9b611373-5022-0372-942f-4825a8bc3bd3
caps.latest.revision: 16
author: "shirhatti"
manager: "wpickett"
---
# IAppHostAdminManager::GetAdminSection Method
Gets an [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration section that has the requested name and configuration path.  
  
## Syntax  
  
```cpp  
HRESULT GetAdminSection(  
   [in,  
   string] BSTR bstrSectionName,  
   [in,  
   string] BSTR bstrPath,  
   [out,  
   retval] IAppHostElement** ppAdminSection  
);  
```  
  
#### Parameters  
 `bstrSectionName`  
 A `BSTR` that contains the path to a valid section name in the configuration system.  
  
 `bstrPath`  
 A `BSTR` that contains the configuration system path.  
  
 `ppAdminSection`  
 A pointer to a pointer for an [IAppHostElement](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_DATA|Indicates that the data is invalid.|  
|ERROR_FILE_NOT_FOUND|Indicates that the requested path was not found.|  
|ERROR_INVALID_PARAMETER|Indicates that a parameter is incorrect.|  
|E_ACCESSDENIED|Indicates that the operation was not successful because of access restrictions.|  
  
## Remarks  
 For a specified configuration path, the return values of this method represent the corresponding values in the hierarchically merged configuration set. To set the configuration path, use the `bstrPath` parameter of this method.  
  
## Example  
 The following code example uses the [IAppHostAdminManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-interface.md) interface to obtain all merged child elements for the `system.webServer/asp` configuration section in the MACHINE/WEBROOT/APPHOST configuration path.  
  
<!-- TODO: review snippet reference  [!CODE [IAppHostAdminLibrary#1](IAppHostAdminLibrary#1)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostAdminManager Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-interface.md)   
 [IAppHostConfigFile::GetAdminSection Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigfile-getadminsection-method.md)