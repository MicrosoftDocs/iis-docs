---
title: "PM_INTERFACE_ID_ENUM Enumeration"
ms.date: "10/07/2016"
ms.assetid: d2fb6f55-6f44-12ad-09d0-be4efde7ba1c
---
# PM_INTERFACE_ID_ENUM Enumeration

Defines the interfaces that the [IProtocolManager::GetPmInterface](../../web-development-reference/native-code-api-reference/iprotocolmanager-getpminterface-method.md) method supports.  
  
## Syntax  
  
```cpp  
enum PM_INTERFACE_ID_ENUM {  
   PM_LISTENER_CHANNEL_MANAGER_ID = 1,  
   PM_HEALTH_AND_IDLE_MONITOR_ID,  
   PM_CUSTOM_ACTIONS_ID  
};  
```  
  
## Members  
  
|Name|Description|  
|----------|-----------------|  
|`PM_LISTENER_CHANNEL_MANAGER_ID`|The [IPmListenerChannelManager](../../web-development-reference/native-code-api-reference/ipmlistenerchannelmanager-interface.md) interface.|  
|`PM_HEALTH_AND_IDLE_MONITOR_ID`|The [IPmHealthAndIdleMonitor](../../web-development-reference/native-code-api-reference/ipmhealthandidlemonitor-interface.md) interface.|  
|`PM_CUSTOM_ACTIONS_ID`|The [IPmCustomActions](../../web-development-reference/native-code-api-reference/ipmcustomactions-interface.md) interface.|  
|`PM_APPLICATION_PRELOAD_ID`|The [IPmApplicationPreload](../../web-development-reference/native-code-api-reference/ipmapplicationpreload-interface.md) interface.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  

 [Worker Process and Protocol Manager Enumerations](../../web-development-reference/native-code-api-reference/worker-process-and-protocol-manager-enumerations.md)   
 [WPF_INTERFACE_ID_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-interface-id-enum-enumeration.md)   
 [WPF_SETTINGS_BOOL_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-bool-enum-enumeration.md)   
 [WPF_SETTINGS_DWORD_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-dword-enum-enumeration.md)   
 [WPF_SETTINGS_STRING_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-string-enum-enumeration.md)   
 [WPF_SETTINGS_ULONGLONG_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-ulonglong-enum-enumeration.md)
