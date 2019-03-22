---
title: IIS Smooth Streaming Server Manifest (Live) - video Element
TOCTitle: <video>
ms:assetid: 7ab74423-2660-445f-9a05-bbb4f2d52444
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee673435(v=VS.90)
ms:contentKeyID: 26179478
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (Live) - video Element

The video element specifies a single track of video data.

[IIS Smooth Streaming Server Manifest (Live) - switch Element](iis-smooth-streaming-server-manifest-live-switch-element.md)  
  [IIS Smooth Streaming Server Manifest (Live) - video param Element](iis-smooth-streaming-server-manifest-live-video-param-element.md)  

    <video src="path" systemBitrate="bitrate number" >   <param name="parameter name" value="value" valuetype="data type" />
    </video>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|--- |--- |
|**src**|Specifies the location in which the track resides. This location may be a URL relative to the encoder URL from which the Live Server Manifest was retrieved, or an absolute URL if an absolute url is specified. The value of the src attribute must be same for all tracks in the manifest. This attribute is required.|
|**systemBitrate**|Specifies the bit rate of the track. This value is matched to the argument of the **QualityLevels()** noun on the URL.This attribute is required.|
|**systemLanguage**|Specifies the language of the track using an RFC-1766 identifier. This is an informative tagging scheme and distinct track names are still required in order to discriminate between tracks at the same bit rate in different languages. This attribute is optional.|


### Child Elements

|Element|Description|
|--- |--- |
|**param**|The param element specifies a single parameter for a video element.|

### Parent Elements

|Element|Description|
|--- |--- |
|**switch**|The switch element is a container for track information.|

## Remarks

Additional parameters support the same name and semantics as corresponding attributes for the QualityLevels() element in the Client Manifest. These are:

  - CodecPrivateData (WaveFormatEx is interpreted as CodecPrivateData for audio tracks if received by the server)

  - MaxHeight (height is interpreted as MaxHeight if received by the server)

  - MaxWidth (with is interprested as MaxWidth if received by the server)

  - SamplingRate

  - Channels

  - BitsPerSample

  - PackSize

  - AudioTag

  - FourCC

For example, if an audio track has an element:

\<param name="BitsPerSample" value="16" valuetype="data" /\>

This would have the same semantic meaning adding the attribute BitsPerSample="16" to the corresponding QualityLevel element.

## See Also

### Reference

[IIS Smooth Streaming Server Manifest (Live) - switch Element](iis-smooth-streaming-server-manifest-live-switch-element.md)

[IIS Smooth Streaming Server Manifest (Live) - video param Element](iis-smooth-streaming-server-manifest-live-video-param-element.md)

