---
title: IIS Smooth Streaming Server Manifest (Live) - video param Element
TOCTitle: <param>
ms:assetid: d31cadf9-35f1-404a-b41f-9f501888657a
ms:mtpsurl: https://msdn.microsoft.com/library/Ee673441(v=VS.90)
ms:contentKeyID: 26179484
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (Live) - video param Element

The video param element specifies a single parameter for the video.

[IIS Smooth Streaming Server Manifest (Live) - video param Element](iis-smooth-streaming-server-manifest-live-video-param-element.md)  

    <param name="parameter name" value="value" valuetype="data type" />

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|--- |--- |
|**name**|Specifies the name of the parameter. This attribute is required.|
|**value**|Specifies the value of the parameter. The valid range and semantic meaning of the value is dependent upon the name of the attribute. See remarks for details. This attribute is required.|

### Child Elements

|Element|Description|
|--- |--- |
|**None**|The video param element has no child elements.|

### Parent Elements

|Element|Description|
|--- |--- |
|**textstream**|The video element specifies a single track of video data.|

## Remarks

Text tracks are commonly used for closed captioning, script streaming, and chapter markers. Smooth Streaming also gives content producers the option of representing text data in a content element of the [IIS Smooth Streaming Client Manifest](iis-smooth-streaming-client-manifest.md) instead of encoding the text data as a text track.

The following list describes the details of the relationship between the name and value attributes of this element:

  - \<param name = "trackID"\> –The value attribute specifies the ID of the track the containing textstream element describes. This value correlates to the track\_ID field in the tfhd and trak boxes for the track. This parameter is required.

  - \<param name = "trackName"\> – Specifies the client-facing name of the track, and appears in the Fragments() noun as part of the URL. All tracks that have the same value for systemBitrate and attributes must have distinct track names. This parameter is optional. If this parameter is omitted, the following default track names are assigned by IIS:

  - For video tracks – value="video"

  - \<param name = "hardwareProfile"\> –Specifies a number that indicates the decoding capabilities needed to render the stream. This parameter is optional. This should be used only if creating multiple streams at the same bitrate, targeting different decoder capabilities. It is recommended that implementers exercise case in referencing on the URL to avoid duplicate caching, which will adversely affect the scalability of the solution.Numerical value calculated as (integer division – the result of the expression is rounded down):((((DisplayWidth\*DisplayHeight)/(4096\*2048))\*100)\*1000)+CodecComplexityThe maximum value is 100000CodecComplexity is a value between 1 and 999 (inclusive) used to distinguish codec versions and encoding profiles.

  - \<param name = "manifestOutput"\> - Specifies that the track is control track – which indicates that any data show be made available immediately to the client, and that all data for this track is accumulated into the manifest. Valid range is 1 (the track is a control track) or 0 (the track is not a control track). This parameter is optional. Omitting this parameter indicates that the track is not a control track.

  - \<param name = "parentTrackName"\> – Specifies that the track is sparse, the name of the track to which the last fragment position for this position is attached. If this track is a control track, its data is downloaded transparently with the data from the parent track. Valid values for this parameter are trackName parameters for other tracks in the presentation. The tracks referenced by parentTrackName must not be control tracks, and must not be sparse. This parameter is optional

  - \<param name = "{namepace}\_{custom attribute}"\> – Specifies additional extended attributes for the track that can be used to discriminate between tracks having the same track name and bit rate. Defining a unique value for {namespace} is strongly recommended to prevent collisions between custom extensions and future additions to the Server Manifest format. This parameter is optional.

  - \<param name = "timescale"\> – Specifies the timescale for this track, as the number of units that pass in one second. If this parameter is not present, the default value used is 10,000,000, which maps to increments of 100ns. This parameter is optional.

## See Also

### Reference

[IIS Smooth Streaming Server Manifest (Live) - video param Element](iis-smooth-streaming-server-manifest-live-video-param-element.md)
