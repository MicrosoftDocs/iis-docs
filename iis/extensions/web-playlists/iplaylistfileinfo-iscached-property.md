---
title: IPlaylistFileInfo::IsCached Property
TOCTitle: IPlaylistFileInfo::IsCached Property
ms:assetid: 1615b2e9-15ee-4405-b89d-a4d39f2357cc
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146257(v=VS.90)
ms:contentKeyID: 19132328
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistFileInfo::IsCached Property

The **IsCached** property gets the value indicating whether the file is cached by IIS 7.

```cpp
RESULT IsCached( [out, retval] VARIANT_BOOL *fCached);
```

## Arguments

|||
|--- |--- |
|*fCached*|TRUE, if the file is cached by IIS 7; otherwise, **FALSE**.|

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
