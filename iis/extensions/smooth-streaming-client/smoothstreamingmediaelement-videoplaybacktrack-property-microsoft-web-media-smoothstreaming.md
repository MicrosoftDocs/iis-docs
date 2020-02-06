---
title: SmoothStreamingMediaElement.VideoPlaybackTrack Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: VideoPlaybackTrack Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoPlaybackTrack
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.videoplaybacktrack(v=VS.90)
ms:contentKeyID: 28440988
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoPlaybackTrack
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_VideoPlaybackTrack
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_VideoPlaybackTrack
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoPlaybackTrack
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# VideoPlaybackTrack Property

Gets the video playback track.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property VideoPlaybackTrack As TrackInfo
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As TrackInfo

value = instance.VideoPlaybackTrack
```

```csharp
  public TrackInfo VideoPlaybackTrack { get; }
```

```cpp
  public:
property TrackInfo^ VideoPlaybackTrack {
    TrackInfo^ get ();
}
```

```jscript
  function get VideoPlaybackTrack () : TrackInfo
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)  
The video playback track.  

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

