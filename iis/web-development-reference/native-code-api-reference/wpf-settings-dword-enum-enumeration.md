---
title: "WPF_SETTINGS_DWORD_ENUM Enumeration"
ms.date: "10/07/2016"
ms.assetid: 0ed59b94-24e7-5d9d-b2a6-cc24a68a1bd0
---
# WPF_SETTINGS_DWORD_ENUM Enumeration
Defines the `DWORD` values that the [IWpfSettings::GetDwordProperty](../../web-development-reference/native-code-api-reference/iwpfsettings-getdwordproperty-method.md) method returns.  
  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Enumerations](../../web-development-reference/native-code-api-reference/worker-process-and-protocol-manager-enumerations.md)   
 [IWpfSettings::GetDwordProperty Method](../../web-development-reference/native-code-api-reference/iwpfsettings-getdwordproperty-method.md)   
 [WPF_SETTINGS_BOOL_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-bool-enum-enumeration.md)   
 [WPF_SETTINGS_HANDLE_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-handle-enum-enumeration.md)   
 [WPF_SETTINGS_STRING_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-string-enum-enumeration.md)   
 [WPF_SETTINGS_ULONGLONG_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-ulonglong-enum-enumeration.md)