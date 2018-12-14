---
title: "WPF_SETTINGS_DWORD_ENUM Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0ed59b94-24e7-5d9d-b2a6-cc24a68a1bd0
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# WPF_SETTINGS_DWORD_ENUM Enumeration
Defines the `DWORD` values that the [IWpfSettings::GetDwordProperty](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-getdwordproperty-method.md) method returns.  
  
## Syntax  
  
```cpp  
enum WPF_SETTINGS_DWORD_ENUM {  
   PERIODIC_RESTART_REQUESTS = 1,  
   PERIODIC_RESTART_TIME,  
   IDLE_TIMEOUT,  
   MANAGED_PIPELINE_MODE  
};  
```  
  
## Members  
  
|Name|Description|  
|----------|-----------------|  
|`PERIODIC_RESTART_REQUESTS`|The total number of requests to process before a restart is initiated.|  
|`PERIODIC_RESTART_TIME`|The scheduled restart time.|  
|`IDLE_TIMEOUT`|The configured idle time-out before a restart is initiated.|  
|`MANAGED_PIPELINE_MODE`|The managed pipeline mode.|  
|`THREAD_AFFINITY_POLICY`|The thread affinity policy.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Enumerations](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/worker-process-and-protocol-manager-enumerations.md)   
 [IWpfSettings::GetDwordProperty Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-getdwordproperty-method.md)   
 [WPF_SETTINGS_BOOL_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-bool-enum-enumeration.md)   
 [WPF_SETTINGS_HANDLE_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-handle-enum-enumeration.md)   
 [WPF_SETTINGS_STRING_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-string-enum-enumeration.md)   
 [WPF_SETTINGS_ULONGLONG_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-ulonglong-enum-enumeration.md)