---
title: PLAYLIST_PROPERTY_TYPE Enumeration
TOCTitle: PLAYLIST_PROPERTY_TYPE Enumeration
ms:assetid: be911916-f647-4a13-9732-e78e53c05bbf
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146289(v=VS.90)
ms:contentKeyID: 19132360
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# PLAYLIST\_PROPERTY\_TYPE Enumeration

An enumeration provides a list of properties of a playlist.

    typedef [public, uuid(04D0A43E-6B8B-4e4e-9005-C5B00DBF388A) ]
    enum PLAYLIST_PROPERTY_TYPE
    {
    PlaylistProperty_Title = 1,
    PlaylistProperty_ExtraParam = 2,
    PlaylistProperty_InactivityTimeout = 3,
    PlaylistProperty_TimeToLive = 4,
    PlaylistProperty_LastModifiedTime = 5
    } PLAYLIST_PROPERTY_TYPE;

## Arguments

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>PlaylistProperty_Title</p></td>
<td><p>The title of the playlist entry.</p></td>
</tr>
<tr class="even">
<td><p>PlaylistProperty_ExtraParam</p></td>
<td><p>Additional parameters that are specific to the playlist format.</p></td>
</tr>
<tr class="odd">
<td><p>PlaylistProperty_InactivityTimeout</p></td>
<td><p>The amount of time allowed between requests for the playlist in minutes.</p></td>
</tr>
<tr class="even">
<td><p>PlaylistProperty_TimeToLive</p></td>
<td><p>The absolute time, in minutes, before the playlist is live.</p></td>
</tr>
<tr class="odd">
<td><p>PlaylistProperty_LastModifiedTime</p></td>
<td><p>The last modified FILETIME for the playlist.</p></td>
</tr>
</tbody>
</table>


## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

