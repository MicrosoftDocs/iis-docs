---
title: IPlaylistInfo::Entries Property
TOCTitle: IPlaylistInfo::Entries Property
description: IPlaylistInfo Entries Property shows how the Entries property  gets an IPlaylistEntryInfoCollection Interface instance to enumerate the entries in a playlist.
ms:assetid: 9989c76c-82c1-4217-a544-5bb7787518be
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146281(v=VS.90)
ms:contentKeyID: 19132352
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistInfo::Entries Property

The **Entries** property gets an [IPlaylistEntryInfoCollection Interface](iplaylistentryinfocollection-interface.md) instance to enumerate the entries in a playlist.

```cpp
HRESULT
Entries(
    [out, retval] IPlaylistEntryInfoCollection  **ppPlaylistEntries
);
```

## Arguments

|Argument|Description|
|--- |--- |
|*ppPlaylistEntries*|The returned [IPlaylistEntryInfoCollection Interface](https://msdn.microsoft.com/library/dd146264) instance.|

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Notes for Implementers

Implementers should return an instance of an [IPlaylistEntryInfoCollection Interface](iplaylistentryinfocollection-interface.md) that contains the collection of entries.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
