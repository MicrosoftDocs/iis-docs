---
title: ClientConnections Element
TOCTitle: ClientConnections Element
ms:assetid: d106d15a-9b41-4d62-b52d-5fcec1c54558
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547062(v=VS.90)
ms:contentKeyID: 37836903
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# ClientConnections Element

Enables the publishing point to return live streams when they are requested by clients.

    <ClientConnections enabled="true|false">
      <WindowLength />
      <LiveCacheLength />
      <ClientManifestVersion />
    </ClientConnections>

### Attributes

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Attribute</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>enabled</p></td>
<td><p>Required. true to enable the publishing point to return live streams; otherwise, false.</p></td>
</tr>
</tbody>
</table>


### Child Elements

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="windowlength-element.md">WindowLength Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="livecachelength-element.md">LiveCacheLength Element</a></p></td>
</tr>
<tr class="odd">
<td><p><a href="clientmanifestversion-element.md">ClientManifestVersion Element</a></p></td>
</tr>
</tbody>
</table>


### Parent Element

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="settings-element.md">Settings Element</a></p></td>
</tr>
</tbody>
</table>


### Example

    <ClientConnections enabled="true">
      <ClientManifestVersion>2.0</ClientManifestVersion>
    </ClientConnections>

