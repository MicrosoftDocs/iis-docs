---
title: PublishingPoint Element
TOCTitle: PublishingPoint Element
ms:assetid: 863b8bf0-67ba-4d6c-b7c4-28059d5ef9c1
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547048(v=VS.90)
ms:contentKeyID: 37836889
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# PublishingPoint Element

The URL of a Live Smooth Streaming publishing point.

    <PublishingPoint credentialName="name">
      "publishingpointurl"
    </PublishingPoint>

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
<td><p>credentialName</p></td>
<td><p>Optional. The name of a credential on the server to use for connections to the publishing point.</p></td>
</tr>
</tbody>
</table>


### Child Elements

None.

### Parent Element

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="publishingpoints-element.md">PublishingPoints Element</a></p></td>
</tr>
</tbody>
</table>


## Remarks

The publishing point can be either a Pull or Push publishing point, depending on the parent element.

