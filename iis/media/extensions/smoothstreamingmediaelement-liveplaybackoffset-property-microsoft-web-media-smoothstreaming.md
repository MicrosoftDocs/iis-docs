---
title: SmoothStreamingMediaElement.LivePlaybackOffset Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LivePlaybackOffset Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePlaybackOffset
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.liveplaybackoffset(v=VS.90)
ms:contentKeyID: 33674271
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LivePlaybackOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePlaybackOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LivePlaybackOffset
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LivePlaybackOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePlaybackOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LivePlaybackOffset
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LivePlaybackOffset Property

Gets or sets how far back from the live position, excluding [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md), to start playback when joining a live presentation.  Increasing this value allows the pre-roll buffer to fill faster than real time and creates a buffer against network jitter, but increases the end-to-end latency of the presentation. The default value is 7 seconds. Changes that are made to this value after the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property has been set are disregarded.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyLivePlaybackOffsetAsTimeSpan
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsTimeSpanvalue = instance.LivePlaybackOffset

instance.LivePlaybackOffset = value
```

``` csharp
publicTimeSpanLivePlaybackOffset { get; set; }
```

``` c++
public:
propertyTimeSpanLivePlaybackOffset {
    TimeSpanget ();
    voidset (TimeSpanvalue);
}
```

``` jscript
function getLivePlaybackOffset () : TimeSpanfunction setLivePlaybackOffset (value : TimeSpan)
```

#### Property Value

Type: [System. . :: . .TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\))  
The duration away from the live position, excluding [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md), to start playback when joining a live presentation.  

## Remarks

The following diagram shows the stages of buffering and offsets.

![Smooth Streaming Offsets](images/Ee532750.SmoothStreamingOffsets(en-us,VS.90).png "Smooth Streaming Offsets")

The [BufferingTime](smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md) property specifies the duration of media content that will be downloaded before the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object begins to display any content. The LivePlaybackOffset property specifies the duration of media content backed off from the value of the [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md) property (that is, the current live represented by the P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveBackOff property) where downloading and playback begins. Setting the LivePlaybackOffset property enables faster startup through build-up of a portion or all of startup buffer specified by [BufferingTime](smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md) as fast as bandwidth will support. It creates a buffer against network jitter but increases the end-to-end latency.

As a result, the end-to-end latency on the client side (that is, how close playback is to live content that is available on the server) is at least the [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md) value plus the larger of [BufferingTime](smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md) or LivePlaybackOffset value away from the live stream.

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

