---
title: SmoothStreamingMediaElement.VideoHighestPlayableTrackChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: VideoHighestPlayableTrackChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoHighestPlayableTrackChanged
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.videohighestplayabletrackchanged(v=VS.95)
ms:contentKeyID: 46307505
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.VideoHighestPlayableTrackChanged
dev_langs:
- csharp
- jscript
- vb
- FSharp
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

# SmoothStreamingMediaElement.VideoHighestPlayableTrackChanged Event

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

``` fsharp
member VideoHighestPlayableTrackChanged : <EventHandler<TrackChangedEventArgs>,
    TrackChangedEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

