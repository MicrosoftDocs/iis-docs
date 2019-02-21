---
title: SmoothStreamingMediaElement.BufferingTime Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: BufferingTime Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.BufferingTime
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.bufferingtime(v=VS.90)
ms:contentKeyID: 23961170
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.BufferingTime
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_BufferingTime
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_BufferingTime
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.BufferingTime
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_BufferingTime
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_BufferingTime
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# BufferingTime Property

Gets or sets the duration of media content that will be buffered before playback can start or continue.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property BufferingTime As TimeSpan
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As TimeSpan

value = instance.BufferingTime

instance.BufferingTime = value
```

```csharp
  public TimeSpan BufferingTime { get; set; }
```

```cpp
  public:
property TimeSpan BufferingTime {
    TimeSpan get ();
    void set (TimeSpan value);
}
```

```jscript
  function get BufferingTime () : TimeSpan
function set BufferingTime (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577)  
The duration of media content that will be preloaded before streaming begins or continues.  

## Remarks

The following illustration shows the relationships between the [LivePlaybackOffset](smoothstreamingmediaelement-liveplaybackoffset-property-microsoft-web-media-smoothstreaming_1.md), BufferingTime, and [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md) properties.

![Smooth Streaming Offsets](images/Gg507677.SmoothStreamingOffsets(en-us,VS.90).png "Smooth Streaming Offsets")

The BufferingTime property specifies the duration of media content that will be downloaded before the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object begins to display any content. The [LivePlaybackOffset](smoothstreamingmediaelement-liveplaybackoffset-property-microsoft-web-media-smoothstreaming_1.md) property specifies the duration of media content backed off from the value of the [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md) property (that is, the current live position represented by the [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md) property) where downloading and playback begins. Setting the [LivePlaybackOffset](smoothstreamingmediaelement-liveplaybackoffset-property-microsoft-web-media-smoothstreaming_1.md) property enables faster startup through build-up of some or all of a startup buffer specified by BufferingTime as fast as bandwidth will support. It creates a buffer against network jitter but increases the end-to-end latency.

As a result, the end-to-end latency on the client side (that is, how close playback is to live content that is available on the server) is at least the value of [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md) plus the larger of BufferingTime or [LivePlaybackOffset](smoothstreamingmediaelement-liveplaybackoffset-property-microsoft-web-media-smoothstreaming_1.md) away from the live stream.

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

