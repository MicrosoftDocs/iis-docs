---
title: IPlaylistProvider Interface
TOCTitle: IPlaylistProvider Interface
ms:assetid: b4baeec6-a0f6-4a22-9278-0611b29818e9
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146285(v=VS.90)
ms:contentKeyID: 19132356
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistProvider Interface

The **IPlaylistProvider** interface is the root interface of a playlist provider.

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
<td><p><a href="iplaylistprovider-initialize-method.md">IPlaylistProvider::Initialize Method</a></p></td>
<td><p>Called once after a playlist provider is instantiated.</p></td>
</tr>
<tr class="even">
<td><p><a href="iplaylistprovider-shutdown-method.md">IPlaylistProvider::Shutdown Method</a></p></td>
<td><p>Called before a playlist provider is released.</p></td>
</tr>
<tr class="odd">
<td><p><a href="iplaylistprovider-getplaylistinfo-method.md">IPlaylistProvider::GetPlaylistInfo Method</a></p></td>
<td><p>Gets an <a href="iplaylistinfo-interface.md">IPlaylistInfo Interface</a> object for the given request.</p></td>
</tr>
</tbody>
</table>


## Notes for Implementers

Implementers may use this interface to control initialization and shut down of a custom playlist provider.

