---
title: InputStream Element
TOCTitle: InputStream Element
ms:assetid: 8c8fdfa3-cb65-4c5c-ae53-e86c981ca857
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547050(v=VS.90)
ms:contentKeyID: 37836891
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# InputStream Element

Provides summary information about a Smooth Stream input stream.

    <InputStream id=identifier>
      <State />
      <ArchiveFileName />
      <Sources>
        <Source>
          <Properties>
            <Property />
          </Properties>
        </Source>
      </Sources>
      <Sinks>
        <Sink>
          <Properties>
            <Property />
          </Properties>
        </Sink>
      </Sinks>
      <Tracks>
        <Track>
          <Name />
          <EncodedBitRate />
          <IncomingBitRate />
          <IncomingFragmentWaitTime />
          <IncomingFragmentTimeStamp />
          <IncomingFragmentDuration />
          <RequestRate />
        </Track>
      </Tracks>
    </InputStream>

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
<td><p>Required. Specifies an identifier for the input stream.</p></td>
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
<td><p><a href="state-element-inputstream.md">State Element (InputStream)</a></p></td>
</tr>
<tr class="even">
<td><p><a href="archivefilename-element.md">ArchiveFileName Element</a></p></td>
</tr>
<tr class="odd">
<td><p><a href="sources-element-sources.md">Sources Element (Sources)</a></p></td>
</tr>
<tr class="even">
<td><p><a href="sinks-element.md">Sinks Element</a></p></td>
</tr>
<tr class="odd">
<td><p><a href="tracks-element.md">Tracks Element</a></p></td>
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
<td><p><a href="inputstreams-element.md">InputStreams Element</a></p></td>
</tr>
</tbody>
</table>

