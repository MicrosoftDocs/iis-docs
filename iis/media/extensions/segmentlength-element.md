---
title: SegmentLength Element
TOCTitle: SegmentLength Element
ms:assetid: 04d892cd-8e33-4896-a29a-3fc07831a40f
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547023(v=VS.90)
ms:contentKeyID: 37836864
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# SegmentLength Element

An xs:duration value that specifies the archive segment length.

    <SegmentLength>
      "length"
    </SegmentLength>

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


## Remarks

The duration is specified in a format like "PT1H15M30.5S". The default value (0) generates a single Smooth Streaming presentation for the entire live broadcast.

