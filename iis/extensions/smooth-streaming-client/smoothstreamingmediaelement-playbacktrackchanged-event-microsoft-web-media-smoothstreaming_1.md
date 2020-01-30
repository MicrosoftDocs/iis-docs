---
title: SmoothStreamingMediaElement.PlaybackTrackChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PlaybackTrackChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackTrackChanged
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.playbacktrackchanged(v=VS.95)
ms:contentKeyID: 46307504
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackTrackChanged
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_PlaybackTrackChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackTrackChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_PlaybackTrackChanged
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.PlaybackTrackChanged Event

Occurs when the currently playing track changes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event PlaybackTrackChanged As EventHandler(Of TrackChangedEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of TrackChangedEventArgs)

AddHandler instance.PlaybackTrackChanged, handler
```

```csharp
public event EventHandler<TrackChangedEventArgs> PlaybackTrackChanged
```

```cpp
public:
 event EventHandler<TrackChangedEventArgs^>^ PlaybackTrackChanged {
    void add (EventHandler<TrackChangedEventArgs^>^ value);
    void remove (EventHandler<TrackChangedEventArgs^>^ value);
}
```

``` fsharp
member PlaybackTrackChanged : <EventHandler<TrackChangedEventArgs>,
    TrackChangedEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

For more information, see [Select and Monitor Bitrate](select-and-monitor-bitrate.md) and [Events](events.md).

## Examples

Bit-rate changes invoke the PlaybackTrackChanged event. Applications can monitor the bitrate in the delegate that handles the event. The following example shows how to read the new bitrate from the [TrackChangedEventArgs](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md) parameter and display it using a text block.

``` 
    void SmoothPlayer_PlaybackTrackChanged(object sender, TrackChangedEventArgs e)
    {
        OutputText.Text = "Current bitrate: " + e.Track.Bitrate.ToString();
    }
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

