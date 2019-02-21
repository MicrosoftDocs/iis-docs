---
title: SmoothStreamingMediaElement.VideoDownloadTrack Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: VideoDownloadTrack Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoDownloadTrack
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.videodownloadtrack(v=VS.95)
ms:contentKeyID: 46307853
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoDownloadTrack
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_VideoDownloadTrack
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_VideoDownloadTrack
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoDownloadTrack
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.VideoDownloadTrack Property

Gets the video download track.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property VideoDownloadTrack As TrackInfo
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As TrackInfo

value = instance.VideoDownloadTrack
```

```csharp
public TrackInfo VideoDownloadTrack { get; }
```

```cpp
public:
property TrackInfo^ VideoDownloadTrack {
    TrackInfo^ get ();
}
```

``` fsharp
member VideoDownloadTrack : TrackInfo
```

```jscript
function get VideoDownloadTrack () : TrackInfo
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)  
The video download track.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

