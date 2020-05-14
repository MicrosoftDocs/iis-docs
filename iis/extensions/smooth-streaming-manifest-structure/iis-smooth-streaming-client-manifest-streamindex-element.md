---
title: IIS Smooth Streaming Client Manifest - StreamIndex Element
TOCTitle: <StreamIndex>
ms:assetid: d4c9c38f-5f43-4e9e-aba7-82c13983c594
ms:mtpsurl: https://msdn.microsoft.com/library/Ee673442(v=VS.90)
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

### Attributes

|Element|Description|
|--- |--- |
|**Type**|Specifies the track type, and MUST be "audio", "video" or "text".|
|**Chunks**|Specifies the number of data chunks in the stream.|
|**QualityLevels**|Specifies the number of tracks for variable bit rates.|
|**MaxWidth**|The maximum width for video display.|
|**MaxHeight**|The maximum height for the video display.|
|**DisplayWidth**|The recorded width of video display.|
|**DisplayHeight**|The recorded width of video display.|
|**Url*|Specifies the format of **QualityLevel** (track) identifiers.|

### Child Elements

|Element|Description|
|--- |--- |
|**QualityLevel**|A track for one of several bit-rates needed for IIS Smooth Streaming media.|
|**c**|Chunk identifier for segment of data.|

### Parent Elements

|Element|Description|
|--- |--- |
|**SmoothStreamingMedia**|Specifies metadata for this Smooth Streaming media presentation.|

## See Also

### Reference

[IIS Smooth Streaming Client Manifest - SmoothStreamingMedia Element](iis-smooth-streaming-client-manifest-smoothstreamingmedia-element.md)
