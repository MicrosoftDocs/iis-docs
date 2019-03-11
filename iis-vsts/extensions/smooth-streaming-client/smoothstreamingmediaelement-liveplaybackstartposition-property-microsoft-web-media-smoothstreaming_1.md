---
title: SmoothStreamingMediaElement.LivePlaybackStartPosition Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LivePlaybackStartPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePlaybackStartPosition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.liveplaybackstartposition(v=VS.95)
ms:contentKeyID: 46307834
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePlaybackStartPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LivePlaybackStartPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LivePlaybackStartPosition
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LivePlaybackStartPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePlaybackStartPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LivePlaybackStartPosition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.LivePlaybackStartPosition Property

Gets or sets the starting position to use during live playback.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property LivePlaybackStartPosition As PlaybackStartPosition
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As PlaybackStartPosition

value = instance.LivePlaybackStartPosition

instance.LivePlaybackStartPosition = value
```

```csharp
public PlaybackStartPosition LivePlaybackStartPosition { get; set; }
```

```cpp
public:
property PlaybackStartPosition LivePlaybackStartPosition {
    PlaybackStartPosition get ();
    void set (PlaybackStartPosition value);
}
```

``` fsharp
member LivePlaybackStartPosition : PlaybackStartPosition with get, set
```

```jscript
function get LivePlaybackStartPosition () : PlaybackStartPosition
function set LivePlaybackStartPosition (value : PlaybackStartPosition)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.PlaybackStartPosition](playbackstartposition-enumeration-microsoft-web-media-smoothstreaming_1.md)  
The position as specified by a member of the [PlaybackStartPosition](playbackstartposition-enumeration-microsoft-web-media-smoothstreaming_1.md) enumeration.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

