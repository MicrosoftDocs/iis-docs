---
title: AdaptiveSourceStatusUpdateType Enumeration
TOCTitle: AdaptiveSourceStatusUpdateType Enumeration
ms:assetid: 7a1b0efb-ec4a-4b6a-a060-182bf76ca004
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822762(v=VS.90)
ms:contentKeyID: 50079517
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# AdaptiveSourceStatusUpdateType Enumeration

**Applies to:** Windows Store apps only

Adaptive source update type enumeration.

## Syntax

``` csharp
[VersionAttribute()]
public enum AdaptiveSourceStatusUpdateType
```

``` c++
[VersionAttribute()]
public enum class AdaptiveSourceStatusUpdateType
```

``` jscript
public enum AdaptiveSourceStatusUpdateType
```

## Enumeration Values

<table>
<colgroup>
<col style="width: 33%" />
<col style="width: 33%" />
<col style="width: 33%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Name</p></th>
<th><p>Value</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Unknown</p></td>
<td><p>0</p></td>
<td><p>Generic error.</p></td>
</tr>
<tr class="even">
<td><p>Underrun</p></td>
<td><p>1</p></td>
<td><p>There was an underrun event.</p></td>
</tr>
<tr class="odd">
<td><p>Rebuffer</p></td>
<td><p>2</p></td>
<td><p>There was a rebuffering event.</p></td>
</tr>
<tr class="even">
<td><p>StartEndTime</p></td>
<td><p>3</p></td>
<td><p>The start/end time changed.</p></td>
</tr>
<tr class="odd">
<td><p>BitrateChanged</p></td>
<td><p>4</p></td>
<td><p>The bitrate changed.</p></td>
</tr>
<tr class="even">
<td><p>ChunkConnectHttpInvalid</p></td>
<td><p>5</p></td>
<td><p>http &lt;200 or &gt;=400 response on connect</p></td>
</tr>
<tr class="odd">
<td><p>NextChunkHttpInvalid</p></td>
<td><p>6</p></td>
<td><p>http &lt;200 or &gt;=400 response on next chunk</p></td>
</tr>
<tr class="even">
<td><p>ChunkHdrHttpInvalid</p></td>
<td><p>7</p></td>
<td><p>http &lt;200 or &gt;=400 reponse on chunk hdr</p></td>
</tr>
<tr class="odd">
<td><p>ChunkHdrError</p></td>
<td><p>8</p></td>
<td><p>Chunk header parser error.</p></td>
</tr>
<tr class="even">
<td><p>EndOfLive</p></td>
<td><p>9</p></td>
<td><p>Live presentation is no longer live</p></td>
</tr>
<tr class="odd">
<td><p>OutsideWindowEdge</p></td>
<td><p>10</p></td>
<td><p>Playable position is outside of DVR window, app should seek and/or change play rate.</p></td>
</tr>
<tr class="even">
<td><p>SegmentManifestError</p></td>
<td><p>11</p></td>
<td><p>Error while getting a segment manifest.</p></td>
</tr>
<tr class="odd">
<td><p>ChunkDownloaded</p></td>
<td><p>12</p></td>
<td><p>Additional info on every chunk downloaded.</p></td>
</tr>
</tbody>
</table>


## Requirements

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><strong>Minimum supported client</strong></p></td>
<td><p>Windows 8</p></td>
</tr>
<tr class="even">
<td><p><strong>Minimum supported server</strong></p></td>
<td><p>Not Supported</p></td>
</tr>
<tr class="odd">
<td><p><strong>Metadata</strong></p></td>
<td><p>Microsoft.Media.AdaptiveStreaming.winmd</p></td>
</tr>
</tbody>
</table>

