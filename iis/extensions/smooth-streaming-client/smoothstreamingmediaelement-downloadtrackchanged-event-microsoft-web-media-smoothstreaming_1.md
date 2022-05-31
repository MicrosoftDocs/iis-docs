---
title: SmoothStreamingMediaElement.DownloadTrackChanged Event (Microsoft.Web.Media.SmoothStreaming)
description: 
TOCTitle: DownloadTrackChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadTrackChanged
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.downloadtrackchanged(v=VS.95)
ms:contentKeyID: 46307494
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadTrackChanged
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_DownloadTrackChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadTrackChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_DownloadTrackChanged
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.DownloadTrackChanged Event

Occurs when the track selected for download differs from the previously selected track.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event DownloadTrackChanged As EventHandler(Of TrackChangedEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of TrackChangedEventArgs)

AddHandler instance.DownloadTrackChanged, handler
```

```csharp
public event EventHandler<TrackChangedEventArgs> DownloadTrackChanged
```

```cpp
public:
 event EventHandler<TrackChangedEventArgs^>^ DownloadTrackChanged {
    void add (EventHandler<TrackChangedEventArgs^>^ value);
    void remove (EventHandler<TrackChangedEventArgs^>^ value);
}
```

``` fsharp
member DownloadTrackChanged : <EventHandler<TrackChangedEventArgs>,
    TrackChangedEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

For more information, see [Events](events.md).

## Examples

The following example shows a delegate that handles the DownloadTrackChanged event.

``` 
  SmoothPlayer.DownloadTrackChanged += 
    new EventHandler<TrackChangedEventArgs>(SmoothPlayer_DownloadTrackChanged);
```

The following example shows how to display the information that can be obtained from the [TrackChangedEventArgs](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md) object.

``` 
  void SmoothPlayer_DownloadTrackChanged(object sender, TrackChangedEventArgs e)
  {
      MessageBox.Show("StreamType: " + e.StreamType + " Timestamp: " +
         e.Timestamp + " Track: " + e.Track);
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
