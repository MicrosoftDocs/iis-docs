---
title: IPlaylistEntryInfoCollection::Item Property
TOCTitle: IPlaylistEntryInfoCollection::Item Property
ms:assetid: 148e132c-8086-4154-8fdd-c3e507a81dde
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146256(v=VS.90)
ms:contentKeyID: 19132327
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistEntryInfoCollection::Item Property

The **Item** property gets an [IPlaylistEntryInfo Interface](iplaylistentryinfo-interface.md) instance from the current playlist.

    HRESULT
    Item(
        [in] DWORD                        dwEntryIndex,
        [out, retval] IPlaylistEntryInfo  **ppPlaylistEntry
    );

## Arguments

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>dwEntryIndex</p></td>
<td><p>A DWORD that contains the index of the requested item in the collection.</p></td>
</tr>
<tr class="even">
<td><p>ppPlaylistEntry</p></td>
<td><p>The returned <a href="iplaylistentryinfo-interface.md">IPlaylistEntryInfo Interface</a> instance.</p></td>
</tr>
</tbody>
</table>


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Notes for Implementers

Implementers should return an instance of an [IPlaylistEntryInfo Interface](iplaylistentryinfo-interface.md) that represents the results of the request in dwEntryIndex.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

