---
title: IPlaylistFileInfo::FileSize Property
TOCTitle: IPlaylistFileInfo::FileSize Property
ms:assetid: 68be47e6-6405-4f61-9747-60dfc046a0b4
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146273(v=VS.90)
ms:contentKeyID: 19132344
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistFileInfo::FileSize Property

The **FileSize** property gets the size of the physical file that contains the playlist.

    RESULT FileSize( [out, retval] ULONGLONG *pllFileSize);

## Arguments

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>pllFileSize</p></td>
<td><p>The ULONGLONG that contains the size of the physical file.</p></td>
</tr>
</tbody>
</table>


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

