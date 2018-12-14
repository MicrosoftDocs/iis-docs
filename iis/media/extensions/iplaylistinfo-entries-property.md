---
title: IPlaylistInfo::Entries Property
TOCTitle: IPlaylistInfo::Entries Property
ms:assetid: 9989c76c-82c1-4217-a544-5bb7787518be
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146281(v=VS.90)
ms:contentKeyID: 19132352
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistInfo::Entries Property

The **Entries** property gets an [IPlaylistEntryInfoCollection Interface](iplaylistentryinfocollection-interface.md) instance to enumerate the entries in a playlist.

    HRESULT 
    Entries(
        [out, retval] IPlaylistEntryInfoCollection  **ppPlaylistEntries
    );

## Arguments

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>ppPlaylistEntries</p></td>
<td><p>The returned <a href="iplaylistentryinfocollection-interface.md">IPlaylistEntryInfoCollection Interface</a> instance.</p></td>
</tr>
</tbody>
</table>


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Notes for Implementers

Implementers should return an instance of an [IPlaylistEntryInfoCollection Interface](iplaylistentryinfocollection-interface.md) that contains the collection of entries.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

