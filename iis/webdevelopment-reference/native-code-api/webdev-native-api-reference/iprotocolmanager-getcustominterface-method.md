---
title: "IProtocolManager::GetCustomInterface Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: beefd5ac-d536-32c9-6e96-2518c6482b1f
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# IProtocolManager::GetCustomInterface Method
Retrieves a custom interface from a protocol manager.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetCustomInterface(  
   IN DWORD InterfaceId,  
   OUT PVOID* ppInterface  
) = 0;  
```  
  
#### Parameters  
 `InterfaceId`  
 The ID of the interface to return.  
  
 `ppInterface`  
 A pointer to a buffer that will receive the interface specified by `InterfaceId`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 Use the `GetCustomInterface` method to retrieve any interfaces that are not defined in the [PM_INTERFACE_ID_ENUM](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pm-interface-id-enum-enumeration.md) enumeration and that may be exposed by a protocol manager. To retrieve interfaces from a protocol manager that are defined by `PM_INTERFACE_ID_ENUM`, use the [IProtocolManager::GetPmInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprotocolmanager-getpminterface-method.md) method.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IProtocolManager Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprotocolmanager-interface.md)   
 [IProtocolManager::GetPmInterface Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprotocolmanager-getpminterface-method.md)   
 [IProtocolManager::Shutdown Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprotocolmanager-shutdown-method.md)