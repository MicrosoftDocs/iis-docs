---
title: IPlaylistEntryInfo::EntryType Property
description: This article contains information about arguments, return value, and requirements for the IPlaylistEntryInfo::EntryType property.
TOCTitle: IPlaylistEntryInfo::EntryType Property
ms:assetid: 2dedca8f-8189-45ed-b92b-1caa92122eda
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146260(v=VS.90)
ms:contentKeyID: 19132331
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistEntryInfo::EntryType Property

The **EntryType**property gets an enumeration describing the location type of the current [IPlaylistEntryInfo Interface](iplaylistentryinfo-interface.md) instance.

```cpp
HRESULT EntryType( [out,retval] ENTRY_TYPE* pType);
```

## Arguments

|Argument|Description|
|--- |--- |
|*pType*|An [IPlaylistEntryInfo::ENTRY_TYPE Enumeration](https://msdn.microsoft.com/library/dd146290) enumeration describing the location type of the entry.|

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Notes for Implementers

Implementers of the [IPlaylistEntryInfo Interface](iplaylistentryinfo-interface.md) interface must implement this property.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
