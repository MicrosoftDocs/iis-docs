---
title: "IProtocolManager::GetPmInterface Method"
ms.date: "10/07/2016"
ms.assetid: 67a82c02-b569-64ba-e808-8f6a55b336fa
---
# IProtocolManager::GetPmInterface Method
Retrieves a defined interface from a protocol manager.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetPmInterface(  
   IN PM_INTERFACE_ID_ENUM PmInterfaceId,  
   OUT PVOID* ppInterface  
) = 0;  
```  
  
### Parameters  
 `PmInterfaceId`  
 The ID of the interface to return.  
  
 `ppInterface`  
 A pointer to a buffer that will receive the interface specified by the `PmInterfaceId` parameter.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 To select which interface to retrieve, choose the specific interface ID from the [PM_INTERFACE_ID_ENUM](../../web-development-reference/native-code-api-reference/pm-interface-id-enum-enumeration.md) enumeration. If a protocol manager exposes an interface that is not defined by `PM_INTERFACE_ID_ENUM`, use the [IProtocolManager::GetCustomInterface](../../web-development-reference/native-code-api-reference/iprotocolmanager-getcustominterface-method.md) method.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IProtocolManager Interface](../../web-development-reference/native-code-api-reference/iprotocolmanager-interface.md)   
 [IProtocolManager::GetCustomInterface Method](../../web-development-reference/native-code-api-reference/iprotocolmanager-getcustominterface-method.md)   
 [IProtocolManager::Shutdown Method](../../web-development-reference/native-code-api-reference/iprotocolmanager-shutdown-method.md)
