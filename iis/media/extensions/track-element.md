---
title: Track Element
TOCTitle: Track Element
ms:assetid: dfb6118c-e5ab-44ec-8f49-b95cd848e3a8
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547067(v=VS.90)
ms:contentKeyID: 37836908
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Track Element

Provides information about a track within the live streams that are received by the publishing point.

    <Track id="identifier">
      <Name />
      <EncodedBitRate />
      <IncomingBitRate />
      <IncomingFragmentWaitTime />
      <IncomingFragmentTimeStamp />
      <IncomingFragmentDuration />
      <RequestRate />
    </Track>

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
<td><p>id</p></td>
<td><p>Required. Specifies an identifier for the track.</p></td>
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
<td><p><a href="name-element.md">Name Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="encodedbitrate-element.md">EncodedBitRate Element</a></p></td>
</tr>
<tr class="odd">
<td><p><a href="incomingbitrate-element.md">IncomingBitRate Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="incomingfragmentwaittime-element.md">IncomingFragmentWaitTime Element</a></p></td>
</tr>
<tr class="odd">
<td><p><a href="incomingfragmenttimestamp-element.md">IncomingFragmentTimeStamp Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="incomingfragmentduration-element.md">IncomingFragmentDuration Element</a></p></td>
</tr>
<tr class="odd">
<td><p><a href="requestrate-element.md">RequestRate Element</a></p></td>
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
<td><p><a href="tracks-element.md">Tracks Element</a></p></td>
</tr>
</tbody>
</table>

