---
title: Stream Type, Subtype, Other Attributes (IIS Smooth Streaming)
TOCTitle: Stream Type, Subtype, Other Attributes (IIS Smooth Streaming)
ms:assetid: eada3fe3-b0a0-4605-8b98-9c772c52e304
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ff728117(v=VS.90)
ms:contentKeyID: 31469137
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Stream Type, Subtype, Other Attributes (IIS Smooth Streaming)

The StreamIndex element of the client manifest specifies metadata for audio, video, or text used in Smooth Streaming applications.

## StreamIndex Attributes

In the Smooth Streaming object model and API, the StreamIndex element corresponds to the [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) class. The StreamIndex element defines metadata with the following attributes:

  - Type \[Required\] Specifies the type of track used by this stream. Must be "audio", "video" or "text".

  - TimeScale \[Optional\] Specifies the timescale for this track, as the number of units that pass in one second. The recommended value is 10,000,000 (10000000), which maps to increments of 100 nanoseconds. If this attribute is omitted, the track’s timescale is assumed to be the same as the TimeScale attribute of the SmoothStreamingMedia element.

  - Language. \[Optional\] Specifies the ISO 639-2/T code of the language used, if appropriate. If the language is unknown or to specify a neutral language, use Language="und".

  - Name. \[Optional\] Specifies the name of the track. This attribute is usually used to allow the client to discriminate between multiple tracks of the same type, such as multiple camera angles or alternate commentary.

  - ParentStreamIndex \[Optional\] Specifies the name of another StreamIndex object by which timing information of tracks in this StreamIndex instance is measured. If this ParentStreamIndex attribute is present, it indicates that the tracks in the stream are sparse (that is, there might be significant gaps between fragments, which are bridged by embedding timing information in the parent track).

  - ManifestOutput \[Optional\] Specifies whether data is cumulatively embedded in the manifest for tracks in this StreamIndex instance as base-64-encoded content in f elements.

Depending on the value of the Type attribute, the following additional attributes might apply:

|Attribute|Type="video"|Type="audio"|Type="text"|
|--- |--- |--- |--- |
|TimeScale|Optional|Optional|Optional|
|Language|Optional|Optional|Optional|
|Chunks|Required|Required|Required if "Content" not used for text track|
|QualityLevels|Required|Required|Optional|
|MaxWidth|Optional|Not supported|Not supported|
|MaxHeight|Optional|Not supported|Not supported|
|DisplayWidth|Optional|Not supported|Not supported|
|DisplayWidth|Optional|Not supported|Not supported|
|URL|Required|Required|Required if "Content" not used for text track|
|Name|Optional|Optional|Optional|
|Subtype|Optional|Not supported|Required|


### Other Constraints on Attributes

This section describes other constraints that might apply.

If the value assigned to the Type attribute is "video" or "audio", the following attributes are required:

  - Chunks \[Required\] Specifies the number of fragments in the track.

  - QualityLevels \[Required\] Specifies the number of distinct quality level and hardware profile choices that are available for this track.

  - URL \[Required\] Specifies how to generate URLs for this track or this group of tracks. Syntax and semantics for the URL attribute are specified later in this document.

If the value assigned to the Type attribute is "video", the following additional attributes are supported:

  - MaxWidth \[Optional\] Specifies the maximum coded width, in pixels, for all quality level choices.

  - MaxHeight \[Optional\] Specifies the maximum coded height, in pixels, for all quality level choices.

  - DisplayWidth \[Optional\] Specifies the recommended display width in pixels.

  - DisplayHeight \[Optional\] Specifies the recommended display height in pixels.

The encoder can use non-square pixels to code the video, subject to the following constraints:

  - The codec used must carry a Pixel Aspect Ratio (PAR) value of the stream.

  - The PAR must be the same for all fragments in the stream.

  - The following is true: PAR= DAR/SAR=(DisplayWidth\*MaxHeight)/(MaxWidth\*DisplayHeight).


> [!NOTE]  
> The DisplayWidth and DisplayHeight elements are informative, but clients may disregard these values. If DisplayWidth and DisplayHeight indicate a different aspect ratio than MaxWidth and MaxHeight, clients with decoders that are not PAR-aware should treat a difference in the DAR and SAR as a signal that coded pixels are not square and stretch the image by the PAR computed from DisplayWidth, DisplayHeight, MaxWidth, and MaxHeight.


When the StreamIndex element's Type attribute has the value "video", the Subtype attribute specifies that the track is binary data. Defined values are:

  - ZOET: Specifies Zoetrope film-strip view trick mode.

  - CHAP: Specifies chapter headings.

When the value of the StreamIndex element's Type attribute is "text", the Subtype attribute specifies the type of the text track. Defined values are:

  - SCMD Specifies script commands using name-value pairs.

  - CHAP Specifies markers or chapter headings.

  - CAPT Specifies captions, but differs from script commands in that there are no names for individual samples.

  - SUBT Specifies subtitles.

  - DESC Specifies media descriptions for the hard of hearing.

  - CTRL Specifies control events such as advertising insertion points.

  - DATA Specifies application-specific data such as play-by-play descriptions.

## See Also

#### Concepts

[QualityLevel, Attributes (IIS Smooth Streaming)](qualitylevel-attributes.md)

