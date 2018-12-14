---
title: SmoothStreamingMediaElement.VideoHighestPlayableTrack Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: VideoHighestPlayableTrack Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoHighestPlayableTrack
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.videohighestplayabletrack(v=VS.90)
ms:contentKeyID: 31469193
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_VideoHighestPlayableTrack
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoHighestPlayableTrack
dev_langs:
- CSharp
- JScript
- VB
- c++
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
ROBOTS: INDEX,FOLLOW
---

# VideoHighestPlayableTrack Property

Gets the track that has the highest available bandwidth.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyVideoHighestPlayableTrackAsTrackInfo
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsTrackInfovalue = instance.VideoHighestPlayableTrack
```

``` csharp
publicTrackInfoVideoHighestPlayableTrack { get; }
```

``` c++
public:
propertyTrackInfo^ VideoHighestPlayableTrack {
    TrackInfo^ get ();
}
```

``` jscript
function getVideoHighestPlayableTrack () : TrackInfo
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)  
The track.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

