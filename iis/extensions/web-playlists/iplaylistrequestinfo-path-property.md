---
title: IPlaylistRequestInfo::Path Property
TOCTitle: IPlaylistRequestInfo::Path Property
ms:assetid: 45b48164-8ac8-4a1d-bd18-e09941f2a1be
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146266(v=VS.90)
ms:contentKeyID: 19132337
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistRequestInfo::Path Property

The **Path** property gets the physical path of the requested playlist file.

    RESULT Path( [out, retval] BSTR* pbstrPath);

## Arguments

|||
|--- |--- |
|*pbstrName*|The physical path of the [IPlaylistRequestInfo Interface](https://msdn.microsoft.com/library/dd146293) instance.|


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Remarks

> [!NOTE]  
> A physical playlist file is not required to implement a playlist provider.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

