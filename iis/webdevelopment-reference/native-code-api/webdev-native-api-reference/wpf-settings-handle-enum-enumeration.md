---
title: "WPF_SETTINGS_HANDLE_ENUM Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 81a84a38-c9ab-323f-f181-8379d50c26c8
caps.latest.revision: 11
author: "shirhatti"
manager: "wpickett"
---
# WPF_SETTINGS_HANDLE_ENUM Enumeration
Defines the `HANDLE` values that the [IWpfSettings::GetHandleProperty](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-gethandleproperty-method.md) method returns.  
  
## Syntax  
  
```cpp  
enum WPF_SETTINGS_HANDLE_ENUM {  
   ANONYMOUS_USER_TOKEN  
};  
```  
  
## Members  
  
|Name|Description|  
|----------|-----------------|  
|`ANONYMOUS_USER_TOKEN`|The user token for the anonymous user account.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Enumerations](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/worker-process-and-protocol-manager-enumerations.md)   
 [IWpfSettings::GetHandleProperty Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-gethandleproperty-method.md)   
 [WPF_SETTINGS_BOOL_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-bool-enum-enumeration.md)   
 [WPF_SETTINGS_DWORD_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-dword-enum-enumeration.md)   
 [WPF_SETTINGS_STRING_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-string-enum-enumeration.md)   
 [WPF_SETTINGS_ULONGLONG_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-ulonglong-enum-enumeration.md)