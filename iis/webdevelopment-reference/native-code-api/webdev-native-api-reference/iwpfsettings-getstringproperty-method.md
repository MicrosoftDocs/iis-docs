---
title: "IWpfSettings::GetStringProperty Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 45f47ea3-1a10-6bad-326d-45ca18b7e24c
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# IWpfSettings::GetStringProperty Method
Retrieves a string value from the worker process or application pool settings.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetStringProperty(  
   IN WPF_SETTINGS_STRING_ENUM SettingId,  
   __out_ecount_opt(*pcchSetting) PWSTR pszSetting,  
   IN OUT DWORD* pcchSetting  
) = 0;  
```  
  
#### Parameters  
 `SettingId`  
 [IN] A [WPF_SETTINGS_STRING_ENUM](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-string-enum-enumeration.md) value that specifies which string value to return.  
  
 `pszSetting`  
 [OUT] A pointer to a string buffer that receives the value specified by `SettingId`.  
  
 `pcchSetting`  
 [IN][OUT] A pointer to a `DWORD` buffer that receives the size of the string returned in `pszSetting`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INSUFFICIENT_BUFFER|Indicates that there is not enough buffer space to perform the operation.|  
|ERROR_INVALID_PARAMETER|Indicates that the specified parameter is not valid. (The parameter is either out of range or not a string.)|  
  
## Remarks  
 Because the `pszSetting` parameter is optional, it may be NULL. If the size of the string value exceeds the size specified by the `pcchSetting` parameter, the method will return ERROR_INSUFFICIENT_BUFFER.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWpfSettings Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-interface.md)   
 [IWpfSettings::GetBoolProperty Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-getboolproperty-method.md)   
 [IWpfSettings::GetDwordProperty Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-getdwordproperty-method.md)   
 [IWpfSettings::GetHandleProperty Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-gethandleproperty-method.md)   
 [IWpfSettings::GetUlonglongProperty Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-getulonglongproperty-method.md)   
 [WPF_SETTINGS_STRING_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-string-enum-enumeration.md)