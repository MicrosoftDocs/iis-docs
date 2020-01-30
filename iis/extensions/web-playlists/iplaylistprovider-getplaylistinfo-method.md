---
title: IPlaylistProvider::GetPlaylistInfo Method
TOCTitle: IPlaylistProvider::GetPlaylistInfo Method
ms:assetid: d702aa1e-2df9-489c-903f-f678982bdd53
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146292(v=VS.90)
ms:contentKeyID: 19132363
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistProvider::GetPlaylistInfo Method

The **GetPlaylistInfo** method retrieves an [IPlaylistInfo Interface](iplaylistinfo-interface.md) object for the given request.

    HRESULT
    GetPlaylistInfo(
        [in] IPlaylistRequestInfo         *pRequestInfo,
        [out, retval] IPlaylistInfo      **ppPlaylistInfo
    );

## Arguments

|||
|--- |--- |
|pRequestInfo|An [IPlaylistRequestInfo Interface](iplaylistrequestinfo-interface.md) instance that represents the current playlist request.|
|ppPlaylistInfo|The returned [IPlaylistInfo Interface](iplaylistinfo-interface.md) instance.|

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Notes for Implementers

Implementers should return an instance of an [IPlaylistInfo Interface](iplaylistinfo-interface.md) that represents the results of the request in \*pRequestInfo.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

