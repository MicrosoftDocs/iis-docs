---
title: IIS Smooth Streaming Server Manifest (Live) - switch Element
TOCTitle: <switch>
ms:assetid: 09c33157-d875-4afa-ac0d-5e74e5ddcd0d
ms:mtpsurl: https://msdn.microsoft.com/library/Ee673427(v=VS.90)
ms:contentKeyID: 26179471
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (Live) - switch Element

The switch element is a container for track information.

[IIS Smooth Streaming Server Manifest (Live) - body Element](iis-smooth-streaming-server-manifest-live-body-element.md)  
  [IIS Smooth Streaming Server Manifest (Live) - video Element](iis-smooth-streaming-server-manifest-live-video-element.md)  
    [IIS Smooth Streaming Server Manifest (Live) - audio Element](iis-smooth-streaming-server-manifest-live-audio-element.md)  
      [IIS Smooth Streaming Server Manifest (Live) - textstream Element](iis-smooth-streaming-server-manifest-live-textstream-element.md)  

```xml
<switch>
</switch>
```

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

### Attributes

None

### Child Elements

|Element|Description|
|--- |--- |
|**video**|The video element specifies a single track of video data.|
|**audio**|The audio element specifies a single track of audio data.|
|**textstream**|The textstream element specifies a single track of textstream data. Text tracks are commonly used for closed captioning, script streaming and chapter markers.|

### Parent Elements

|Element|Description|
|--- |--- |
|**body**|The body element is a container for track information and references to other media.|

## Remarks

A Smooth Streaming presentation must contain one or more tracks (specified by [IIS Smooth Streaming Server Manifest (Live) - video Element](iis-smooth-streaming-server-manifest-live-video-element.md), [IIS Smooth Streaming Server Manifest (Live) - audio Element](iis-smooth-streaming-server-manifest-live-audio-element.md), and [IIS Smooth Streaming Server Manifest (Live) - textstream Element](iis-smooth-streaming-server-manifest-live-textstream-element.md) elements).

## See Also

### Reference

[IIS Smooth Streaming Server Manifest (Live) - body Element](iis-smooth-streaming-server-manifest-live-body-element.md)

[IIS Smooth Streaming Server Manifest (Live) - video Element](iis-smooth-streaming-server-manifest-live-video-element.md)

[IIS Smooth Streaming Server Manifest (Live) - audio Element](iis-smooth-streaming-server-manifest-live-audio-element.md)

[IIS Smooth Streaming Server Manifest (Live) - textstream Element](iis-smooth-streaming-server-manifest-live-textstream-element.md)
