---
title: Archive Element
TOCTitle: Archive Element
ms:assetid: af2f9adb-07d8-4c60-9bc4-036dbbe08577
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547057(v=VS.90)
ms:contentKeyID: 37836898
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Archive Element

Enables archiving of live streams to on-demand Smooth Streaming presentations.

    <Archive enabled="true|false">
      <SegmentLength />
      <Path />
    </Archive>

## Attributes

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
<td><p>Required. true to enable archiving of live streams to on-demand Smooth Streaming presentations; otherwise, false.</p></td>
</tr>
</tbody>
</table>


## Child Elements

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="segmentlength-element.md">SegmentLength Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="path-element.md">Path Element</a></p></td>
</tr>
</tbody>
</table>


## Parent Element

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


## Example

    <Archive enabled="true">
      <Path useEventIdOnPath="false" />
    </Archive>

