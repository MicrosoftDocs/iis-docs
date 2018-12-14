---
title: "WPF_INTERFACE_ID_ENUM Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4c2adfcf-2145-380a-f2e7-438113c28724
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# WPF_INTERFACE_ID_ENUM Enumeration
Defines the interfaces that the [IWorkerProcessFramework::GetWpfInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iworkerprocessframework-getwpfinterface-method.md) method supports.  
  
## Syntax  
  
```cpp  
enum WPF_INTERFACE_ID_ENUM {  
   WPF_CONFIG_API_ID = 1,  
   WPF_APPLICATION_INFO_UTIL_ID,  
   WPF_SETTINGS_ID,  
   WPF_ACTIONS_ID,  
   WPF_EXPOSE_PROTOCOL_MANAGER_CUSTOM_INTERFACE_ID  
   WPF_APPLICATION_PRELOAD_INFO_UTIL_ID  
};  
```  
  
## Members  
  
|Name|Description|  
|----------|-----------------|  
|`WPF_CONFIG_API_ID`|Reserved for future use.|  
|`WPF_APPLICATION_INFO_UTIL_ID`|The [IWpfApplicationInfoUtil](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfapplicationinfoutil-interface.md) interface.|  
|`WPF_SETTINGS_ID`|The [IWpfSettings](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-interface.md) interface.|  
|`WPF_ACTIONS_ID`|The [IWpfActions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfactions-interface.md) interface.|  
|`WPF_EXPOSE_PROTOCOL_MANAGER_CUSTOM_INTERFACE_ID`|The [IWpfExposeProtocolManagerCustomInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfexposeprotocolmanagercustominterface-interface.md) interface.|  
|`WPF_APPLICATION_PRELOAD_INFO_UTIL_ID`|The [IWpfApplicationPreloadUtil](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfapplicationpreloadutil-interface.md) interface.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Enumerations](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/worker-process-and-protocol-manager-enumerations.md)   
 [PM_INTERFACE_ID_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pm-interface-id-enum-enumeration.md)   
 [WPF_SETTINGS_BOOL_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-bool-enum-enumeration.md)   
 [WPF_SETTINGS_DWORD_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-dword-enum-enumeration.md)   
 [WPF_SETTINGS_STRING_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-string-enum-enumeration.md)   
 [WPF_SETTINGS_ULONGLONG_ENUM Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-ulonglong-enum-enumeration.md)