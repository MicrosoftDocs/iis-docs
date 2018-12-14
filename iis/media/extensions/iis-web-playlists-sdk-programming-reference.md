---
title: IIS Web Playlists SDK Programming Reference
TOCTitle: Programming Reference
ms:assetid: b90dbdd2-a0e5-4675-8924-6507c1e2b66a
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146287(v=VS.90)
ms:contentKeyID: 19132358
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Web Playlists SDK Programming Reference

The IIS Web Playlists SDK allows developers to extend the default behavior through the development of custom providers. The SDK provides a COM interface that supports implementation in either .NET or native code providers.

## Interfaces

The following table represents the interfaces used to develop custom playlist programming references.

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Interface</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="iplaylistprovider-interface.md">IPlaylistProvider Interface</a></p></td>
<td><p>Serves as the root interface for a custom playlist provider. This interface provides access to initialization and shutdown routines for a provider.</p></td>
</tr>
<tr class="even">
<td><p><a href="iplaylistrequestinfo-interface.md">IPlaylistRequestInfo Interface</a></p></td>
<td><p>Represents the current playlist request. Enables custom providers to get and set server variables, the URI of the request, and playlist file information if the playlist is file-based.</p></td>
</tr>
<tr class="odd">
<td><p><a href="iplaylistinfo-interface.md">IPlaylistInfo Interface</a></p></td>
<td><p>Defines an empty playlist that contains a collection of playlist entries in the form of an <a href="iplaylistentryinfocollection-interface.md">IPlaylistEntryInfoCollection Interface</a>.</p></td>
</tr>
<tr class="even">
<td><p><a href="iplaylistentryinfo-interface.md">IPlaylistEntryInfo Interface</a></p></td>
<td><p>Represents individual entries in a playlist.</p></td>
</tr>
<tr class="odd">
<td><p><a href="iplaylistentryinfocollection-interface.md">IPlaylistEntryInfoCollection Interface</a></p></td>
<td><p>Allows a custom provider to traverse a list of playlist entries in the form of <a href="iplaylistentryinfo-interface.md">IPlaylistEntryInfo Interface</a> info objects.</p></td>
</tr>
<tr class="even">
<td><p><a href="iplaylistfileinfo-interface.md">IPlaylistFileInfo Interface</a></p></td>
<td><p>Provides access to properties of file-based playlists.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Concepts

[IIS Web Playlists](iis-web-playlists.md)

