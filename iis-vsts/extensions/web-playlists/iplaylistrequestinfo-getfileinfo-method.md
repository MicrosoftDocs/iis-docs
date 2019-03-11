---
title: IPlaylistRequestInfo::GetFileInfo Method
TOCTitle: IPlaylistRequestInfo::GetFileInfo Method
ms:assetid: 4ea9459e-0727-454b-9287-06e087b47622
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146270(v=VS.90)
ms:contentKeyID: 19132341
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistRequestInfo::GetFileInfo Method

The **GetFileInfo** method returns information about the playlist file in file-based implementations of the interface.

    HRESULT
    GetFileInfo (
        [out,retval] IPlaylistFileInfo           **ppPlaylistFileInfo
    );

## Arguments

|||
|--- |--- |
|*ppPlaylistFileInfo*|The returned [IPlaylistFileInfo Interface](https://msdn.microsoft.com/library/dd146277) instance.|


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Remarks

> [!NOTE]  
> The information returned by this method is only useful when the playlist is implemented as a physical file on a disk.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

