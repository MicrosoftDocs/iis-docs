---
title: "WPF_INTERFACE_ID_ENUM Enumeration"
ms.date: "10/07/2016"
ms.assetid: 4c2adfcf-2145-380a-f2e7-438113c28724
---
# WPF_INTERFACE_ID_ENUM Enumeration
Defines the interfaces that the [IWorkerProcessFramework::GetWpfInterface](../../web-development-reference/native-code-api-reference/iworkerprocessframework-getwpfinterface-method.md) method supports.  
  
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
|`WPF_APPLICATION_INFO_UTIL_ID`|The [IWpfApplicationInfoUtil](../../web-development-reference/native-code-api-reference/iwpfapplicationinfoutil-interface.md) interface.|  
|`WPF_SETTINGS_ID`|The [IWpfSettings](../../web-development-reference/native-code-api-reference/iwpfsettings-interface.md) interface.|  
|`WPF_ACTIONS_ID`|The [IWpfActions](../../web-development-reference/native-code-api-reference/iwpfactions-interface.md) interface.|  
|`WPF_EXPOSE_PROTOCOL_MANAGER_CUSTOM_INTERFACE_ID`|The [IWpfExposeProtocolManagerCustomInterface](../../web-development-reference/native-code-api-reference/iwpfexposeprotocolmanagercustominterface-interface.md) interface.|  
|`WPF_APPLICATION_PRELOAD_INFO_UTIL_ID`|The [IWpfApplicationPreloadUtil](../../web-development-reference/native-code-api-reference/iwpfapplicationpreloadutil-interface.md) interface.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Enumerations](../../web-development-reference/native-code-api-reference/worker-process-and-protocol-manager-enumerations.md)
 [PM_INTERFACE_ID_ENUM Enumeration](../../web-development-reference/native-code-api-reference/pm-interface-id-enum-enumeration.md)
 [WPF_SETTINGS_BOOL_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-bool-enum-enumeration.md)
 [WPF_SETTINGS_DWORD_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-dword-enum-enumeration.md)
 [WPF_SETTINGS_STRING_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-string-enum-enumeration.md)
 [WPF_SETTINGS_ULONGLONG_ENUM Enumeration](../../web-development-reference/native-code-api-reference/wpf-settings-ulonglong-enum-enumeration.md)
