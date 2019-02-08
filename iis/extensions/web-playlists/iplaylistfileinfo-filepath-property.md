---
title: IPlaylistFileInfo::FilePath Property
TOCTitle: IPlaylistFileInfo::FilePath Property
ms:assetid: 8a63407d-1b30-4365-9089-5cbe30720a80
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146280(v=VS.90)
ms:contentKeyID: 19132351
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistFileInfo::FilePath Property

The **FilePath** property gets the canonical physical file path.

    RESULT FilePath( [out, retval] BSTR* pbstrPath);

## Arguments

|||
|--- |--- |
|*pbstrName*|The canonical path of the physical playlist file.|


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

