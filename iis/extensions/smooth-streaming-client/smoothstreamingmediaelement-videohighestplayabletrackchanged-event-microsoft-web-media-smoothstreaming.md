---
title: SmoothStreamingMediaElement.VideoHighestPlayableTrackChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: VideoHighestPlayableTrackChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoHighestPlayableTrackChanged
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.videohighestplayabletrackchanged(v=VS.90)
ms:contentKeyID: 31469252
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoHighestPlayableTrackChanged
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_VideoHighestPlayableTrackChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_VideoHighestPlayableTrackChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoHighestPlayableTrackChanged
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# VideoHighestPlayableTrackChanged Event

Occurs when the playback rate changes to the highest available rate.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Event VideoHighestPlayableTrackChanged As EventHandler(Of TrackChangedEventArgs)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of TrackChangedEventArgs)

AddHandler instance.VideoHighestPlayableTrackChanged, handler
```

```csharp
  public event EventHandler<TrackChangedEventArgs> VideoHighestPlayableTrackChanged
```

```cpp
  public:
 event EventHandler<TrackChangedEventArgs^>^ VideoHighestPlayableTrackChanged {
    void add (EventHandler<TrackChangedEventArgs^>^ value);
    void remove (EventHandler<TrackChangedEventArgs^>^ value);
}
```

```jscript
  JScript does not support events.
```

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

