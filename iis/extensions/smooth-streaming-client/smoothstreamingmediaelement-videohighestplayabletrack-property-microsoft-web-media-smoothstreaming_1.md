---
title: SmoothStreamingMediaElement.VideoHighestPlayableTrack Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: VideoHighestPlayableTrack Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoHighestPlayableTrack
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.videohighestplayabletrack(v=VS.95)
ms:contentKeyID: 46307856
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_VideoHighestPlayableTrack
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoHighestPlayableTrack
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_VideoHighestPlayableTrack
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoHighestPlayableTrack
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.VideoHighestPlayableTrack Property

Gets the track that has the highest available bandwidth.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property VideoHighestPlayableTrack As TrackInfo
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As TrackInfo

value = instance.VideoHighestPlayableTrack
```

```csharp
public TrackInfo VideoHighestPlayableTrack { get; }
```

```cpp
public:
property TrackInfo^ VideoHighestPlayableTrack {
    TrackInfo^ get ();
}
```

``` fsharp
member VideoHighestPlayableTrack : TrackInfo
```

```jscript
function get VideoHighestPlayableTrack () : TrackInfo
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)  
The track.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

