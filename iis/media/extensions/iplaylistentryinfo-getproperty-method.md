---
title: IPlaylistEntryInfo::GetProperty Method
TOCTitle: IPlaylistEntryInfo::GetProperty Method
ms:assetid: a36f33d1-e59d-457e-bb5f-5b1fda770d45
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146284(v=VS.90)
ms:contentKeyID: 19132355
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistEntryInfo::GetProperty Method

The **GetProperty** method gets the value of the requested property for this entry.

    HRESULT
    GetProperty(
        [in]            PLAYLIST_ENTRY_PROPERTY_TYPE   propertyName,
        [out, retval]   VARIANT *pVariantValue
    );

## Arguments

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>propertyName</p></td>
<td><p>A <a href="playlist-entry-property-type-enumeration.md">PLAYLIST_ENTRY_PROPERTY_TYPE Enumeration</a> enumeration describing the location type of the entry.</p></td>
</tr>
<tr class="even">
<td><p>pVariantValue</p></td>
<td><p>The returned property value. Implementers should return a value that represents the results of the request in propertyName.</p></td>
</tr>
</tbody>
</table>


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Notes for Implementers

Implementers of the [IPlaylistEntryInfo Interface](iplaylistentryinfo-interface.md) interface must implement this method.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

