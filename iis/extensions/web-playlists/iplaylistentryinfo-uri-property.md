---
title: IPlaylistEntryInfo::Uri Property
TOCTitle: IPlaylistEntryInfo::Uri Property
ms:assetid: b7796e5a-4204-4876-8c4c-11859a0bce55
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146286(v=VS.90)
ms:contentKeyID: 19132357
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistEntryInfo::Uri Property

The **Uri** property gets the URI for the location of the current [IPlaylistEntryInfo Interface](iplaylistentryinfo-interface.md) instance.

```cpp
HRESULT
Uri(
    [out, retval] BSTR *pbstrUri
);
```

## Arguments

|Argument|Description|
|--- |--- |
|*pbstrUri*|The returned URI for the playlist location. Implementers are required to return a valid value.|

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Notes for Implementers

Implementers of the [IPlaylistEntryInfo Interface](iplaylistentryinfo-interface.md) interface must implement this property.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
