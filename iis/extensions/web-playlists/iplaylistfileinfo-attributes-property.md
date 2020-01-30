---
title: IPlaylistFileInfo::Attributes Property
TOCTitle: IPlaylistFileInfo::Attributes Property
ms:assetid: 39fc629a-7acd-410b-9f9d-b048ffa2b639
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146263(v=VS.90)
ms:contentKeyID: 19132334
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistFileInfo::Attributes Property

The **Attributes** property gets the attributes of the physical playlist file.

    RESULT Attributes( [out, retval] DWORD *pdwAttributes);

## Arguments

|||
|--- |--- |
|*pdwAttributes*|The **DWORD** that contains the attributes of the physical file.|


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

