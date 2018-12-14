---
title: IPlaylistFileInfo::GetStream Method
TOCTitle: IPlaylistFileInfo::GetStream Method
ms:assetid: 164b2ebd-d2b4-4990-b10e-f9e65db1e9a1
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146258(v=VS.90)
ms:contentKeyID: 19132329
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistFileInfo::GetStream Method

The **GetStream** method gets the **IsSequentialStream** instance that provides sequential access to the file contents.

    RESULT GetStream( [out, retval] IsSequentialStream *ppStream);

## Arguments

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>ppStream</p></td>
<td><p>An <strong>IsSequentialStream</strong> instance.</p></td>
</tr>
</tbody>
</table>


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

