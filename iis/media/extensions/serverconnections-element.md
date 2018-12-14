---
title: ServerConnections Element
TOCTitle: ServerConnections Element
ms:assetid: be105438-17e3-4e1d-8af1-fb692c481f76
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547059(v=VS.90)
ms:contentKeyID: 37836900
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# ServerConnections Element

Enables the publishing point to return live streams when they are requested by publishing points on other Live Smooth Streaming servers in a distributed network.

    <ServerConnections enabled="true|false">
       <SendEndOfStreamOnStop />
    </ServerConnections>

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
<td><p>Required. true to enable server connections; otherwise, false.</p></td>
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
<td><p><a href="sendendofstreamonstop-element.md">SendEndOfStreamOnStop Element</a></p></td>
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

    <ServerConnections enabled="true">
      <SendEndOfStreamOnStop>true</SendEndOfStreamOnStop>
    </ServerConnections>

