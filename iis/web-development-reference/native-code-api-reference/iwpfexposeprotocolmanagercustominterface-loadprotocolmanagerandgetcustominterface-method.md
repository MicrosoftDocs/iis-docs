---
title: IWpfExposeProtocolManagerCustomInterface
description: The IWpfExposeProtocolManagerCustomInterface::LoadProtocolManagerAndGetCustomInterface method loads a specified protocol manager and retrieves an interface for that protocol manager.
TOCTitle: IWpfExposeProtocolManagerCustomInterface::LoadProtocolManagerAndGetCustomInterface Method
ms:assetid: 2e151498-c316-680f-71cf-84ab02245717
ms:mtpsurl: https://msdn.microsoft.com/library/ms690765(v=VS.90)
ms:contentKeyID: 6824802
ms.date: 03/09/2018
mtps_version: v=VS.90
dev_langs:
- "cpp"
---

# The LoadProtocolManagerAndGetCustomInterface Method

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

| Value | Description |
| --- | --- |
| S_OK | Indicates that the operation was successful. |
| ERROR_FILE_NOT_FOUND | Indicates that the protocol manager specified by pProtocolManagerDll does not exist, or that the DLL entry point specified by pProtocolManagerDllInitFunction is not valid. |
| ERROR_INVALID_PARAMETER | Indicates that the interface specified by dwCustomInterfaceId is not valid. |

## Remarks

The `LoadProtocolManagerAndGetCustomInterface` method allows one protocol manager to take advantage of functionality that is implemented in another protocol manager. You can load only a subset of protocol manager interfaces by using this method, because most interaction with protocol managers is completed through the worker process framework.

When you no longer need the interface, release it before you call the protocol manger's [IProtocolManager::Shutdown](iprotocolmanager-shutdown-method.md) method.

## Requirements

| Type | Description |
| --- | --- |
| Client | - IIS 7.0 on Windows Vista

- IIS 7.5 on Windows 7

- IIS 8.0 on Windows 8

- IIS 10.0 on Windows 10 |
| Server | - IIS 7.0 on Windows Server 2008

- IIS 7.5 on Windows Server 2008 R2

- IIS 8.0 on Windows Server 2012

- IIS 8.5 on Windows Server 2012 R2

- IIS 10.0 on Windows Server 2016 Technical Preview |
| Product | - IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0

- IIS Express 7.5, IIS Express 8.0, IIS Express 10.0 |
| Header | Wpframework.h |

## See Also

[IWpfExposeProtocolManagerCustomInterface Interface](iwpfexposeprotocolmanagercustominterface-interface.md)  
[Worker Process Framework API Reference](worker-process-framework-api-reference.md)
