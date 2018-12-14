---
title: IncomingBitRate Element
TOCTitle: IncomingBitRate Element
ms:assetid: d1ac089c-220b-474d-ab68-11911dc8736a
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547063(v=VS.90)
ms:contentKeyID: 37836904
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IncomingBitRate Element

Specifies the incoming bit rate setting of the track, in bits per second (bps).

    <IncomingBitRate>
      "rate"
    </IncomingBitRate>

### Child Elements

None.

### Parent Element

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="track-element.md">Track Element</a></p></td>
</tr>
</tbody>
</table>


## Remarks

This is the rate at which the live source sends the track data to the publishing point. The value varies slightly from the actual encoded bit rate due to network conditions.

