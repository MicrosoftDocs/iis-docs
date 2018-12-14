---
title: IIS Smooth Streaming Client Manifest - StreamIndex Element
TOCTitle: <StreamIndex>
ms:assetid: d4c9c38f-5f43-4e9e-aba7-82c13983c594
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee673442(v=VS.90)
ms:contentKeyID: 26179485
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Client Manifest - StreamIndex Element

The StreamIndex element specifies the metadata for one type of track (audio, video, or text).

[IIS Smooth Streaming Client Manifest - SmoothStreamingMedia Element](iis-smooth-streaming-client-manifest-smoothstreamingmedia-element.md)  

``` 
  <StreamIndex
    Type="video"
    Chunks="88"
    QualityLevels="8"
    MaxWidth="848"
    MaxHeight="476"
    DisplayWidth="848"
    DisplayHeight="476"
    Url="QualityLevels({bitrate})/Fragments(video={start time})">
  </StreamIndex>
```

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

#### Attributes

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Element</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Type</p></td>
<td><p>Specifies the track type, and MUST be &quot;audio&quot;, &quot;video&quot; or &quot;text&quot;.</p></td>
</tr>
<tr class="even">
<td><p>Chunks</p></td>
<td><p>Specifies the number of data chunks in the stream.</p></td>
</tr>
<tr class="odd">
<td><p>QualityLevels</p></td>
<td><p>Specifies the number of tracks for variable bit rates.</p></td>
</tr>
<tr class="even">
<td><p>MaxWidth</p></td>
<td><p>The maximum width for video display.</p></td>
</tr>
<tr class="odd">
<td><p>MaxHeight</p></td>
<td><p>The maximum height for the video display.</p></td>
</tr>
<tr class="even">
<td><p>DisplayWidth</p></td>
<td><p>The recorded width of video display.</p></td>
</tr>
<tr class="odd">
<td><p>DisplayHeight</p></td>
<td><p>The recorded width of video display.</p></td>
</tr>
<tr class="even">
<td><p>Url</p></td>
<td><p>Specifies the format of QualityLevel (track) identifiers.</p></td>
</tr>
</tbody>
</table>


#### Child Elements

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Element</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>QualityLevel</p></td>
<td><p>A track for one of several bit-rates needed for IIS Smooth Streaming media.</p></td>
</tr>
<tr class="even">
<td><p>c</p></td>
<td><p>Chunk identifier for segment of data.</p></td>
</tr>
</tbody>
</table>


#### Parent Elements

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Element</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>SmoothStreamingMedia</p></td>
<td><p>Specifies metadata for this Smooth Streaming media presentation.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[IIS Smooth Streaming Client Manifest - SmoothStreamingMedia Element](iis-smooth-streaming-client-manifest-smoothstreamingmedia-element.md)

