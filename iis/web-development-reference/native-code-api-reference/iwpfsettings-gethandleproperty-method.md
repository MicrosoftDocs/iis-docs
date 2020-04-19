---
title: "IWpfSettings::GetHandleProperty Method"
ms.date: "10/07/2016"
ms.assetid: c85c58b1-7996-c5b0-9f1c-c2fbae6e7f0a
---
# IWpfSettings::GetHandleProperty Method
Retrieves a `HANDLE` property from the worker process or application pool settings.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetHandleProperty(  
   IN WPF_SETTINGS_HANDLE_ENUM SettingId,  
   OUT HANDLE* phSetting  
) = 0;  
```  
  
### Parameters  
 `SettingId`  
 [IN] A [WPF_SETTINGS_HANDLE_ENUM](../../web-development-reference/native-code-api-reference/wpf-settings-handle-enum-enumeration.md) value that specifies which `HANDLE` property to return.  
  
 `phSetting`  
 [OUT] A pointer to a `HANDLE` buffer that receives the property specified by `SettingId`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that the specified parameter is not valid. (The parameter is either out of range or not a `HANDLE`.)|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWpfSettings Interface](../../web-development-reference/native-code-api-reference/iwpfsettings-interface.md)   
 [IWpfSettings::GetBoolProperty Method](../../web-development-reference/native-code-api-reference/iwpfsettings-getboolproperty-method.md)   
 [IWpfSettings::GetDwordProperty Method](../../web-development-reference/native-code-api-reference/iwpfsettings-getdwordproperty-method.md)   
 [IWpfSettings::GetStringProperty Method](../../web-development-reference/native-code-api-reference/iwpfsettings-getstringproperty-method.md)   
 [IWpfSettings::GetUlonglongProperty Method](../../web-development-reference/native-code-api-reference/iwpfsettings-getulonglongproperty-method.md)   
 [WPF_SETTINGS_HANDLE_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-handle-enum-enumeration.md)