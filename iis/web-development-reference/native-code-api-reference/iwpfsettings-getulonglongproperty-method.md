---
title: "IWpfSettings::GetUlonglongProperty Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b4654835-6827-0db2-3669-6ea67d4f8d05
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IWpfSettings::GetUlonglongProperty Method
Retrieves a `ULONGLONG` value from the worker process or application pool settings.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetUlonglongProperty(  
   IN WPF_SETTINGS_ULONGLONG_ENUM SettingId,  
   OUT ULONGLONG* pSetting  
) = 0;  
```  
  
#### Parameters  
 `SettingId`  
 [IN] A [WPF_SETTINGS_ULONGLONG_ENUM](../../web-development-reference\native-code-api-reference/wpf-settings-ulonglong-enum-enumeration.md) value that specifies which `ULONGLONG` value to return.  
  
 `pSetting`  
 [OUT] A pointer to a `ULONGLONG` buffer that receives the value specified by `SettingId`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that the specified parameter is not valid. (The parameter is either out of range or not a `ULONGLONG`.)|  
  
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
 [IWpfSettings::GetStringProperty Method](../../web-development-reference\native-code-api-reference/iwpfsettings-getstringproperty-method.md)   
 [WPF_SETTINGS_ULONGLONG_ENUM Enumeration](../../web-development-reference\native-code-api-reference/wpf-settings-ulonglong-enum-enumeration.md)