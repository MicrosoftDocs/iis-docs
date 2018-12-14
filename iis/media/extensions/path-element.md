---
title: Path Element
TOCTitle: Path Element
ms:assetid: 6614def7-9f48-4b36-a478-7481e436a74f
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547044(v=VS.90)
ms:contentKeyID: 37836885
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Path Element

Specifies a path that overwrites the default archive path that is set in the server configuration.

    <Path useEventIdOnPath="true|false"> 
      "path"
    </Path>

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
<td><p>useEventIdOnPath</p></td>
<td><p>Optional. true to use the event ID on the path instead of the auto-generated timestamp value; otherwise, false. The default value is false.</p></td>
</tr>
</tbody>
</table>


## Child Elements

None.

## Parent Element

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="archive-element.md">Archive Element</a></p></td>
</tr>
</tbody>
</table>


## Example

    <Archive enabled="true">
      <Path useEventIdOnPath="false">%systemdrive%\inetpub\media\archives</Path>
    </Archive>

