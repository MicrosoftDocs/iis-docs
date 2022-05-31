---
title: SmoothStreamingMediaElement.VideoPlaybackTrack Property (Microsoft.Web.Media.SmoothStreaming)
description: This article contains syntax and version information for the SmoothStreamingMediaElement.VideoPlaybackTrack property.
TOCTitle: VideoPlaybackTrack Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoPlaybackTrack
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.videoplaybacktrack(v=VS.95)
ms:contentKeyID: 46307857
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoPlaybackTrack
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_VideoPlaybackTrack
dev_langs:
- csharp
- jscript
- vb
- FSharp
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

# SmoothStreamingMediaElement.VideoPlaybackTrack Property

Gets the video playback track.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property VideoPlaybackTrack As TrackInfo
    Get
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

``` fsharp
member VideoPlaybackTrack : TrackInfo
```

```jscript
function get VideoPlaybackTrack () : TrackInfo
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)  
The video playback track.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
