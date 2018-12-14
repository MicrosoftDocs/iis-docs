---
title: IPlaylistInfo::GetProperty Method
TOCTitle: IPlaylistInfo::GetProperty Method
ms:assetid: 9e7ad995-bc59-4cff-9047-c10c81d8e7ce
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146283(v=VS.90)
ms:contentKeyID: 19132354
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistInfo::GetProperty Method

The **GetProperty** method gets the value of the requested property for this entry.

    HRESULT
    GetProperty(
        [in]          PLAYLIST_PROPERTY_TYPE propertyName,
        [out, retval] VARIANT                *pVariantValue
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
<td><p>A requested property from the <a href="playlist-property-type-enumeration.md">PLAYLIST_PROPERTY_TYPE Enumeration</a> enumeration.</p></td>
</tr>
<tr class="even">
<td><p>pVariantValue</p></td>
<td><p>The returned property value.</p></td>
</tr>
</tbody>
</table>


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Notes for Implementers

Implementers of the [IPlaylistInfo Interface](iplaylistinfo-interface.md) interface must implement this method. Implementers of this method should return a value that represents the results of the request in pVariantValue.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

