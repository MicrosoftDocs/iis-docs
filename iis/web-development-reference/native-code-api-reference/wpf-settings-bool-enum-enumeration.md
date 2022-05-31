---
title: "WPF_SETTINGS_BOOL_ENUM Enumeration"
description: Describes the WPF_SETTINGS_BOOL_ENUM enumeration and provides syntax, members, and requirements. 
ms.date: "10/07/2016"
ms.assetid: 530cbe9f-cf27-47d0-927a-563b795db69c
---
# WPF_SETTINGS_BOOL_ENUM Enumeration
Defines the `BOOL` values that the [IWpfSettings::GetBoolProperty](../../web-development-reference/native-code-api-reference/iwpfsettings-getboolproperty-method.md) method returns.  
  
## Syntax  
  
```cpp  
enum WPF_SETTINGS_BOOL_ENUM {  
   ENABLED_CENTRAL_BINARY_LOGGING,  
   ENABLED_HOSTABLE_WEB_CORE  
};  
```  
  
## Members  
  
|Name|Description|  
|----------|-----------------|  
|`ENABLED_CENTRAL_BINARY_LOGGING`|A value that indicates whether central binary logging is enabled.|  
|`ENABLED_HOSTABLE_WEB_CORE`|A value that indicates whether the [Hosted Web Core](../../web-development-reference/native-code-api-reference/hosted-web-core-api-reference.md) is enabled.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Enumerations](../../web-development-reference/native-code-api-reference/worker-process-and-protocol-manager-enumerations.md)   
 [IWpfSettings::GetBoolProperty Method](../../web-development-reference/native-code-api-reference/iwpfsettings-getboolproperty-method.md)   
 [WPF_SETTINGS_DWORD_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-dword-enum-enumeration.md)   
 [WPF_SETTINGS_HANDLE_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-handle-enum-enumeration.md)   
 [WPF_SETTINGS_STRING_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-string-enum-enumeration.md)   
 [WPF_SETTINGS_ULONGLONG_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-ulonglong-enum-enumeration.md)
