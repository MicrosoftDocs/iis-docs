---
title: SmoothStreamingMediaElement.LivePlaybackOffset Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LivePlaybackOffset Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePlaybackOffset
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.liveplaybackoffset(v=VS.95)
ms:contentKeyID: 46307829
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LivePlaybackOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePlaybackOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LivePlaybackOffset
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LivePlaybackOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePlaybackOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LivePlaybackOffset
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.LivePlaybackOffset Property

Gets or sets how far back from the live position, excluding [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md), to start playback when joining a live presentation.  Increasing this value allows the pre-roll buffer to fill faster than real time and creates a buffer against network jitter, but increases the end-to-end latency of the presentation. The default value is 7 seconds. Changes that are made to this value after the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property has been set are disregarded.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property LivePlaybackOffset As TimeSpan
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As TimeSpan

value = instance.LivePlaybackOffset

instance.LivePlaybackOffset = value
```

```csharp
public TimeSpan LivePlaybackOffset { get; set; }
```

```cpp
public:
property TimeSpan LivePlaybackOffset {
    TimeSpan get ();
    void set (TimeSpan value);
}
```

``` fsharp
member LivePlaybackOffset : TimeSpan with get, set
```

```jscript
function get LivePlaybackOffset () : TimeSpan
function set LivePlaybackOffset (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
The duration away from the live position, excluding [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md), to start playback when joining a live presentation.

## Remarks

The following diagram shows the stages of buffering and offsets.

![Smooth Streaming Offsets](images/Gg507677.SmoothStreamingOffsets(en-us,VS.90).png "Smooth Streaming Offsets")

The [BufferingTime](smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md) property specifies the duration of media content that will be downloaded before the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object begins to display any content. The LivePlaybackOffset property specifies the duration of media content backed off from the value of the [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md) property (that is, the current live represented by the P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveBackOff property) where downloading and playback begins. Setting the LivePlaybackOffset property enables faster startup through build-up of a portion or all of startup buffer specified by [BufferingTime](smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md) as fast as bandwidth will support. It creates a buffer against network jitter but increases the end-to-end latency.

As a result, the end-to-end latency on the client side (that is, how close playback is to live content that is available on the server) is at least the [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md) value plus the larger of [BufferingTime](smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md) or LivePlaybackOffset value away from the live stream.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
