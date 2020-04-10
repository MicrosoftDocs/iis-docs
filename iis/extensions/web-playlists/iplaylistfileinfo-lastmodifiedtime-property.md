---
title: IPlaylistFileInfo::LastModifiedTime Property
TOCTitle: IPlaylistFileInfo::LastModifiedTime Property
ms:assetid: 36887ce1-2e87-4cde-956c-e98464345e7d
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146261(v=VS.90)
ms:contentKeyID: 19132332
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistFileInfo::LastModifiedTime Property

The **LastModifiedTime** property gets the last modified time stamp of the file that contains the playlist.

    RESULT LastModifiedTime( [out, retval] FILETIME* pFileTime);

## Arguments

|||
|--- |--- |
|*pFileTime*|A **FILETIME** that contains the last modified time stamp of the physical file.|

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
