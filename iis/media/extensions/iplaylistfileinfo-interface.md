---
title: IPlaylistFileInfo Interface
TOCTitle: IPlaylistFileInfo Interface
ms:assetid: 7f19692b-8360-4493-84c0-63754d7982ef
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146277(v=VS.90)
ms:contentKeyID: 19132348
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistFileInfo Interface

The **IPlaylistFileInfo** interface represents a playlist in a physical file.

## Members

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Member</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="iplaylistfileinfo-filepath-property.md">IPlaylistFileInfo::FilePath Property</a></p></td>
<td><p>Gets the canonical physical file path.</p></td>
</tr>
<tr class="even">
<td><p><a href="iplaylistfileinfo-iscached-property.md">IPlaylistFileInfo::IsCached Property</a></p></td>
<td><p>Gets the value indicating whether the file is cached by IIS 7.</p></td>
</tr>
<tr class="odd">
<td><p><a href="iplaylistfileinfo-filesize-property.md">IPlaylistFileInfo::FileSize Property</a></p></td>
<td><p>Gets the size of the physical file that contains the playlist.</p></td>
</tr>
<tr class="even">
<td><p><a href="iplaylistfileinfo-attributes-property.md">IPlaylistFileInfo::Attributes Property</a></p></td>
<td><p>Gets the file attributes that are returned by the GetFileAttributes Win32 API system call.</p></td>
</tr>
<tr class="odd">
<td><p><a href="iplaylistfileinfo-lastmodifiedtime-property.md">IPlaylistFileInfo::LastModifiedTime Property</a></p></td>
<td><p>Gets the last modified time stamp of the file that contains the playlist.</p></td>
</tr>
<tr class="even">
<td><p><a href="iplaylistfileinfo-getstream-method.md">IPlaylistFileInfo::GetStream Method</a></p></td>
<td><p>Gets an <strong>IsSequentialStream</strong> instance that provides sequential access of the file contents.</p></td>
</tr>
</tbody>
</table>

