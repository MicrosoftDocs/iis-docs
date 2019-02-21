---
title: "IWpfSettings::GetStringProperty Method"
ms.date: "10/07/2016"
ms.assetid: 45f47ea3-1a10-6bad-326d-45ca18b7e24c
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
  
### Parameters  
 `SettingId`  
 [IN] A [WPF_SETTINGS_STRING_ENUM](../../web-development-reference\native-code-api-reference/wpf-settings-string-enum-enumeration.md) value that specifies which string value to return.  
  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWpfSettings Interface](../../web-development-reference\native-code-api-reference/iwpfsettings-interface.md)   
 [IWpfSettings::GetBoolProperty Method](../../web-development-reference\native-code-api-reference/iwpfsettings-getboolproperty-method.md)   
 [IWpfSettings::GetDwordProperty Method](../../web-development-reference\native-code-api-reference/iwpfsettings-getdwordproperty-method.md)   
 [IWpfSettings::GetHandleProperty Method](../../web-development-reference\native-code-api-reference/iwpfsettings-gethandleproperty-method.md)   
 [IWpfSettings::GetUlonglongProperty Method](../../web-development-reference\native-code-api-reference/iwpfsettings-getulonglongproperty-method.md)   
 [WPF_SETTINGS_STRING_ENUM Enumeration](../../web-development-reference\native-code-api-reference/wpf-settings-string-enum-enumeration.md)