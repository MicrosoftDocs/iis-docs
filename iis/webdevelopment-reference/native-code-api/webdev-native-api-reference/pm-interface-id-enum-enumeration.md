---
title: "PM_INTERFACE_ID_ENUM Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d2fb6f55-6f44-12ad-09d0-be4efde7ba1c
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# PM_INTERFACE_ID_ENUM Enumeration
Defines the interfaces that the [IProtocolManager::GetPmInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprotocolmanager-getpminterface-method.md) method supports.  
  
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
|`PM_LISTENER_CHANNEL_MANAGER_ID`|The [IPmListenerChannelManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmlistenerchannelmanager-interface.md) interface.|  
|`PM_HEALTH_AND_IDLE_MONITOR_ID`|The [IPmHealthAndIdleMonitor](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmhealthandidlemonitor-interface.md) interface.|  
|`PM_CUSTOM_ACTIONS_ID`|The [IPmCustomActions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmcustomactions-interface.md) interface.|  
|`PM_APPLICATION_PRELOAD_ID`|The [IPmApplicationPreload](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmapplicationpreload-interface.md) interface.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Enumerations](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/worker-process-and-protocol-manager-enumerations.md)   
 [WPF_INTERFACE_ID_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-interface-id-enum-enumeration.md)   
 [WPF_SETTINGS_BOOL_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-bool-enum-enumeration.md)   
 [WPF_SETTINGS_DWORD_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-dword-enum-enumeration.md)   
 [WPF_SETTINGS_STRING_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-string-enum-enumeration.md)   
 [WPF_SETTINGS_ULONGLONG_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-ulonglong-enum-enumeration.md)