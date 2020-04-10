---
title: IPlaylistEntryInfo::ENTRY_TYPE Enumeration
TOCTitle: IPlaylistEntryInfo::ENTRY_TYPE Enumeration
ms:assetid: c0881e6d-daac-4f14-a61a-9c587c347cc9
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146290(v=VS.90)
ms:contentKeyID: 19132361
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistEntryInfo::ENTRY\_TYPE Enumeration

The [IPlaylistEntryInfo::ENTRY\_TYPE Enumeration](iplaylistentryinfo-entry-type-enumeration.md) enumeration describes the location of the playlist entry information.

    typedef [public, uuid(85D43118-02EF-4093-98DD-5A15E3BE3F88)] 
    enum ENTRY_TYPE
    {
        EntryTypePhysicalFile,
        EntryTypeRelativeURI, 
        EntryTypeRemoteURL,
    } ENTRY_TYPE;);

## Arguments

|||
|--- |--- |
|*EntryTypePhysicalFile*|The path of the entry is a physical file path.|
|*EntryTypeRelativeURI*|The path of the entry relative to the playlist URL.|
|*EntryTypeRemoteURL*|The path of the entry as a remote URL.|

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
