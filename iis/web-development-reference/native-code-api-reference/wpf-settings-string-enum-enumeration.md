---
title: "WPF_SETTINGS_STRING_ENUM Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a062423c-b707-a3ed-2db0-930c4a752cef
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# WPF_SETTINGS_STRING_ENUM Enumeration
Defines the `string` values that the [IWpfSettings::GetStringProperty](../../web-development-reference\webdev-native-api-reference/iwpfsettings-getstringproperty-method.md) method returns.  
  
## Syntax  
  
```cpp  
enum WPF_SETTINGS_STRING_ENUM {  
   CLR_VERSION,  
   APP_POOL_NAME,  
   APP_HOST_FILE_NAME,  
   ROOT_WEB_CONFIG_FILE_NAME  
};  
```  
  
## Members  
  
|Name|Description|  
|----------|-----------------|  
|`CLR_VERSION`|The version of the common language runtime (CLR).|  
|`APP_POOL_NAME`|The name of the application pool.|  
|`APP_HOST_FILE_NAME`|The name of the ApplicationHost.config file for the application.|  
|`ROOT_WEB_CONFIG_FILE_NAME`|The name of the root-level Web.config file for the site.|  
|`CLR_CONFIG_FILE_NAME`|The name of the application configuration file.|  
|`CLR_VERSION_PATH`|The version path of the common language runtime (CLR).|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Enumerations](../../web-development-reference\webdev-native-api-reference/worker-process-and-protocol-manager-enumerations.md)   
 [IWpfSettings::GetStringProperty Method](../../web-development-reference\webdev-native-api-reference/iwpfsettings-getstringproperty-method.md)   
 [WPF_SETTINGS_BOOL_ENUM Enumeration](../../web-development-reference\webdev-native-api-reference/wpf-settings-bool-enum-enumeration.md)   
 [WPF_SETTINGS_DWORD_ENUM Enumeration](../../web-development-reference\webdev-native-api-reference/wpf-settings-dword-enum-enumeration.md)   
 [WPF_SETTINGS_HANDLE_ENUM Enumeration](../../web-development-reference\webdev-native-api-reference/wpf-settings-handle-enum-enumeration.md)   
 [WPF_SETTINGS_ULONGLONG_ENUM Enumeration](../../web-development-reference\webdev-native-api-reference/wpf-settings-ulonglong-enum-enumeration.md)