---
title: "IWpfExposeProtocolManagerCustomInterface::LoadProtocolManagerAndGetCustomInterface Method"
ms.date: "10/07/2016"
ms.assetid: load-protocol-manager-and-get-custom-interface
---
# IWpfExposeProtocolManagerCustomInterface::LoadProtocolManagerAndGetCustomInterface Method

Loads a specified protocol manager and retrieves an interface for that protocol manager.  
  
## Syntax  
  
```cpp  
virtual HRESULT LoadProtocolManagerAndGetCustomInterface(  
   IN PCWSTR pProtocolManagerDll,  
   IN PCWSTR pProtocolManagerDllInitFunction,  
   IN DWORD dwCustomInterfaceId,  
   OUT PVOID* ppCustomInterface  
) = 0;  
```  
  
### Parameters  

 `pProtocolManagerDll`  
 The DLL for the protocol manager to load.  
  
 `pProtocolManagerDllInitFunction`  
 The DLL entry point for the protocol manager.  
  
 `dwCustomInterfaceId`  
 The interface to return for the protocol manager.  
  
 `ppCustomInterface`  
 A pointer to a buffer that will receive the interface specified by `dwCustomInterfaceId`.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_FILE_NOT_FOUND|Indicates that the protocol manager specified by `pProtocolManagerDll` does not exist, or that the DLL entry point specified by `pProtocolManagerDllInitFunction` is not valid.|  
|ERROR_INVALID_PARAMETER|Indicates that the interface specified by `dwCustomInterfaceId` is not valid.|  
  
## Remarks  

 The `LoadProtocolManagerAndGetCustomInterface` method allows one protocol manager to take advantage of functionality that is implemented in another protocol manager. You can load only a subset of protocol manager interfaces by using this method, because most interaction with protocol managers is completed through the worker process framework.  
  
 When you no longer need the interface, release it before you call the protocol manger's [IProtocolManager::Shutdown](../../web-development-reference/native-code-api-reference/iprotocolmanager-shutdown-method.md) method.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  

 [IWpfExposeProtocolManagerCustomInterface Interface](../../web-development-reference/native-code-api-reference/iwpfexposeprotocolmanagercustominterface-interface.md)   
 [Worker Process Framework API Reference](../../web-development-reference/native-code-api-reference/worker-process-framework-api-reference.md)
