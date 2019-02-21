---
title: SmoothStreamingMediaElement.LiveBackOff Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LiveBackOff Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveBackOff
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.livebackoff(v=VS.90)
ms:contentKeyID: 33674272
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LiveBackOff
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveBackOff
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LiveBackOff
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LiveBackOff
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveBackOff
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LiveBackOff
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# LiveBackOff Property

Gets or sets the duration of content closest to live that cannot yet be downloaded.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property LiveBackOff As TimeSpan
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As TimeSpan

value = instance.LiveBackOff

instance.LiveBackOff = value
```

```csharp
  public TimeSpan LiveBackOff { get; set; }
```

```cpp
  public:
property TimeSpan LiveBackOff {
    TimeSpan get ();
    void set (TimeSpan value);
}
```

```jscript
  function get LiveBackOff () : TimeSpan
function set LiveBackOff (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577)  
The duration of content closest to live that cannot yet be downloaded.  

## Remarks

Setting this property is equivalent to stating how long to delay before asking for the latest fragment in a live presentation, which effectively adjusts the perceived live position backwards. Increasing this value causes the live download position to back off from the real live position. This is done to avoid the possibility of asking for a fragment before it is available for download. The default value of 6 seconds means that the latest live content available on the server can be requested at the earliest 6 seconds later. Changes that are made to this value after the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property has been set are disregarded.

The following diagram shows the stages of buffering and offsets.

![Smooth Streaming Offsets](images/Gg507677.SmoothStreamingOffsets(en-us,VS.90).png "Smooth Streaming Offsets")

The [BufferingTime](smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md) property specifies the duration of media content that will be downloaded before the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object begins to display any content. The [LivePlaybackOffset](smoothstreamingmediaelement-liveplaybackoffset-property-microsoft-web-media-smoothstreaming_1.md) property specifies the duration of media content backed off from the value of the LiveBackOff property (that is, the current live represented by the P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveBackOff property) where downloading and playback begins. Setting the [LivePlaybackOffset](smoothstreamingmediaelement-liveplaybackoffset-property-microsoft-web-media-smoothstreaming_1.md) property enables faster startup through build-up of a portion or all of startup buffer specified by [BufferingTime](smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md) as fast as bandwidth will support. It creates a buffer against network jitter but increases the end-to-end latency.

As a result, the end-to-end latency on the client side (that is, how close playback is to live content that is available on the server) is at least the LiveBackOff value plus the larger of [BufferingTime](smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md) or [LivePlaybackOffset](smoothstreamingmediaelement-liveplaybackoffset-property-microsoft-web-media-smoothstreaming_1.md) value away from the live stream.

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

