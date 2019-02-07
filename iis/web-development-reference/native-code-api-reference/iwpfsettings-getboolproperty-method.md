---
title: "IWpfSettings::GetBoolProperty Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0a0bdc07-acc3-f280-0cc4-efa54a76dfea
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# IWpfSettings::GetBoolProperty Method
Retrieves a `BOOL` value from the worker process or application pool settings.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetBoolProperty(  
   IN WPF_SETTINGS_BOOL_ENUM SettingId,  
   OUT BOOL* pfSetting  
) = 0;  
```  
  
#### Parameters  
 `SettingId`  
 [IN] A [WPF_SETTINGS_BOOL_ENUM](../../web-development-reference\webdev-native-api-reference/wpf-settings-bool-enum-enumeration.md) value that specifies which `BOOL` value to return.  
  
 `pfSetting`  
 [OUT] A pointer to a `BOOL` buffer that receives the value specified by `SettingId`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that the specified parameter is not valid. (The parameter is either out of range or not a `BOOL`.)|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWpfSettings Interface](../../web-development-reference\webdev-native-api-reference/iwpfsettings-interface.md)   
 [IWpfSettings::GetDwordProperty Method](../../web-development-reference\webdev-native-api-reference/iwpfsettings-getdwordproperty-method.md)   
 [IWpfSettings::GetHandleProperty Method](../../web-development-reference\webdev-native-api-reference/iwpfsettings-gethandleproperty-method.md)   
 [IWpfSettings::GetStringProperty Method](../../web-development-reference\webdev-native-api-reference/iwpfsettings-getstringproperty-method.md)   
 [IWpfSettings::GetUlonglongProperty Method](../../web-development-reference\webdev-native-api-reference/iwpfsettings-getulonglongproperty-method.md)   
 [WPF_SETTINGS_BOOL_ENUM Enumeration](../../web-development-reference\webdev-native-api-reference/wpf-settings-bool-enum-enumeration.md)