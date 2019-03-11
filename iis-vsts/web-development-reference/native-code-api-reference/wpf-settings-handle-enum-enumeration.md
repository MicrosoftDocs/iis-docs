---
title: "WPF_SETTINGS_HANDLE_ENUM Enumeration"
ms.date: "10/07/2016"
ms.assetid: 81a84a38-c9ab-323f-f181-8379d50c26c8
---
# WPF_SETTINGS_HANDLE_ENUM Enumeration
Defines the `HANDLE` values that the [IWpfSettings::GetHandleProperty](../../web-development-reference\native-code-api-reference/iwpfsettings-gethandleproperty-method.md) method returns.  
  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Enumerations](../../web-development-reference\native-code-api-reference/worker-process-and-protocol-manager-enumerations.md)   
 [IWpfSettings::GetHandleProperty Method](../../web-development-reference\native-code-api-reference/iwpfsettings-gethandleproperty-method.md)   
 [WPF_SETTINGS_BOOL_ENUM Enumeration](../../web-development-reference\native-code-api-reference/wpf-settings-bool-enum-enumeration.md)   
 [WPF_SETTINGS_DWORD_ENUM Enumeration](../../web-development-reference\native-code-api-reference/wpf-settings-dword-enum-enumeration.md)   
 [WPF_SETTINGS_STRING_ENUM Enumeration](../../web-development-reference\native-code-api-reference/wpf-settings-string-enum-enumeration.md)   
 [WPF_SETTINGS_ULONGLONG_ENUM Enumeration](../../web-development-reference\native-code-api-reference/wpf-settings-ulonglong-enum-enumeration.md)