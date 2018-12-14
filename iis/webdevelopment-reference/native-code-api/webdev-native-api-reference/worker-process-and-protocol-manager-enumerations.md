---
title: "Worker Process and Protocol Manager Enumerations | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 2b076ecb-77cb-4c76-b96b-500d6e1d6a10
caps.latest.revision: 12
author: "shirhatti"
manager: "wpickett"
---
# Worker Process and Protocol Manager Enumerations
This section describes the enumerations that are used by the interfaces and methods in the worker process framework. These enumerations are defined in the Wpframework.h header file.  
  
## In This Section  
 The IIS worker process framework exposes the following enumerations.  
  
|Enumeration|Description|  
|-----------------|-----------------|  
|[PM_INTERFACE_ID_ENUM](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pm-interface-id-enum-enumeration.md)|Defines the interfaces that the [IProtocolManager::GetPmInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprotocolmanager-getpminterface-method.md) method supports.|  
|[WPF_INTERFACE_ID_ENUM](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-interface-id-enum-enumeration.md)|Defines the interfaces that the [IWorkerProcessFramework::GetWpfInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iworkerprocessframework-getwpfinterface-method.md) method supports.|  
|[WPF_SETTINGS_BOOL_ENUM](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-bool-enum-enumeration.md)|Defines the `BOOL` values that the [IWpfSettings::GetBoolProperty](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-getboolproperty-method.md) method returns.|  
|[WPF_SETTINGS_DWORD_ENUM](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-dword-enum-enumeration.md)|Defines the `DWORD` values that the [IWpfSettings::GetDwordProperty](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-getdwordproperty-method.md) method returns.|  
|[WPF_SETTINGS_HANDLE_ENUM](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-handle-enum-enumeration.md)|Defines the `HANDLE` values that the [IWpfSettings::GetHandleProperty](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-gethandleproperty-method.md) method returns.|  
|[WPF_SETTINGS_STRING_ENUM](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-string-enum-enumeration.md)|Defines the `string` values that the [IWpfSettings::GetStringProperty](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-getstringproperty-method.md) method returns.|  
|[WPF_SETTINGS_ULONGLONG_ENUM](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/wpf-settings-ulonglong-enum-enumeration.md)|Defines the `ULONGLONG` values that the [IWpfSettings::GetUlonglongProperty](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfsettings-getulonglongproperty-method.md) method returns.|  
  
## See Also  
 [Worker Process Framework API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/worker-process-framework-api-reference.md)