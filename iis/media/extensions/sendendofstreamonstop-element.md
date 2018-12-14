---
title: SendEndOfStreamOnStop Element
TOCTitle: SendEndOfStreamOnStop Element
ms:assetid: 57f0a58f-ffa6-43a9-896c-1c7ca48c9640
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547040(v=VS.90)
ms:contentKeyID: 37836881
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# SendEndOfStreamOnStop Element

Specifies whether the publishing point sends an end-of-stream (EOS) signal to downstream publishing points when a publishing point stops.

    <SendEndOfStreamOnStop>
      "true|false"
    </SendEndOfStreamOnStop>

## Child Elements

None.

## Parent Element

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="serverconnections-element.md">ServerConnections Element</a></p></td>
</tr>
</tbody>
</table>


## Remarks

Sending an EOS signal causes downstream publishing points to go into a Stopped state. Setting SendEndOfStreamOnStop to false is useful during server maintenance on upstream servers when stopping downstream publishing points is not desirable. Downstream publishing points can be configured to automatically roll over to a backup server to continue streaming.

