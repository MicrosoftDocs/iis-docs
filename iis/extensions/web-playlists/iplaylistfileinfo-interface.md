---
title: IPlaylistFileInfo Interface
TOCTitle: IPlaylistFileInfo Interface
ms:assetid: 7f19692b-8360-4493-84c0-63754d7982ef
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146277(v=VS.90)
ms:contentKeyID: 19132348
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistFileInfo Interface

The **IPlaylistFileInfo** interface represents a playlist in a physical file.

## Members

|Interface|Description|
|--- |--- |
|[IPlaylistFileInfo::FilePath Property](iplaylistfileinfo-filepath-property.md)|Gets the canonical physical file path.|
|[IPlaylistFileInfo::IsCached Property](iplaylistfileinfo-iscached-property.md)|Gets the value indicating whether the file is cached by IIS 7.|
|[IPlaylistFileInfo::FileSize Property](iplaylistfileinfo-filesize-property.md)|Gets the size of the physical file that contains the playlist.|
|[IPlaylistFileInfo::Attributes Property](iplaylistfileinfo-attributes-property.md)|Gets the file attributes that are returned by the GetFileAttributes Win32 API system call.|
|[IPlaylistFileInfo::LastModifiedTime Property](iplaylistfileinfo-lastmodifiedtime-property.md)|Gets the last modified time stamp of the file that contains the playlist.|
|[IPlaylistFileInfo::GetStream Method](iplaylistfileinfo-getstream-method.md)|Gets an **IsSequentialStream** instance that provides sequential access of the file contents.|

