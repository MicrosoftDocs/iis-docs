---
title: PLAYLIST_PROPERTY_TYPE Enumeration
TOCTitle: PLAYLIST_PROPERTY_TYPE Enumeration
ms:assetid: be911916-f647-4a13-9732-e78e53c05bbf
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146289(v=VS.90)
ms:contentKeyID: 19132360
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# PLAYLIST\_PROPERTY\_TYPE Enumeration

An enumeration provides a list of properties of a playlist.

```cpp
typedef [public, uuid(04D0A43E-6B8B-4e4e-9005-C5B00DBF388A) ]
enum PLAYLIST_PROPERTY_TYPE
{
PlaylistProperty_Title = 1,
PlaylistProperty_ExtraParam = 2,
PlaylistProperty_InactivityTimeout = 3,
PlaylistProperty_TimeToLive = 4,
PlaylistProperty_LastModifiedTime = 5
} PLAYLIST_PROPERTY_TYPE;
```

## Arguments

|||
|--- |--- |
|*PlaylistProperty_Title*|The title of the playlist entry.|
|*PlaylistProperty_ExtraParam*|Additional parameters that are specific to the playlist format.|
|*PlaylistProperty_InactivityTimeout*|The amount of time allowed between requests for the playlist in minutes.|
|*PlaylistProperty_TimeToLive*|The absolute time, in minutes, before the playlist is live.|
|*PlaylistProperty_LastModifiedTime*|The last modified **FILETIME** for the playlist.|

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
