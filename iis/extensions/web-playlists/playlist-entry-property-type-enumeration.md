---
title: PLAYLIST_ENTRY_PROPERTY_TYPE Enumeration
TOCTitle: PLAYLIST_ENTRY_PROPERTY_TYPE Enumeration
ms:assetid: 4a6b9b6c-42f9-4eb5-8dbf-0a7cc7bc1bf6
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146267(v=VS.90)
ms:contentKeyID: 19132338
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# PLAYLIST\_ENTRY\_PROPERTY\_TYPE Enumeration

An enumeration that describes the various properties of playlist entries.

    typedef [public, uuid(7EF2664D-05F9-4070-A13D-7FBDC0A0EA28) ]
    enum PLAYLIST_ENTRY_PROPERTY_TYPE
    {
    PlaylistEntryProperty_Title = 1,
    PlaylistEntryProperty_ExtraParam = 2,
    PlaylistEntryProperty_CanSeek = 3,
    PlaylistEntryProperty_CanSkipForward = 4,
    PlaylistEntryProperty_CanSkipBackward = 5
    } PLAYLIST_ ENTRY_PROPERTY_TYPE;

## Arguments

|||
|--- |--- |
|*PlaylistEntryProperty_Title*|The title of the playlist entry.|
|*PlaylistEntryProperty_ExtraParam*|Additional parameters that are playlist-format specific.|
|*PlaylistEntryProperty_CanSeek*|Property to control if the given entry in the playlist is seekable.|
|*PlaylistEntryProperty_CanSkipForward*|Property to control if clients can skip this entry to go to the next entry in the playlist.|
|*PlaylistEntryProperty_CanSkipBackward*|Property to control if clients can skip this entry to go to the previous entry in the playlist.|


## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

