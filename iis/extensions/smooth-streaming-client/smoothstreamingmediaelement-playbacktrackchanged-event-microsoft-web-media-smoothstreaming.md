---
title: SmoothStreamingMediaElement.PlaybackTrackChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PlaybackTrackChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackTrackChanged
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.playbacktrackchanged(v=VS.90)
ms:contentKeyID: 23961154
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackTrackChanged
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_PlaybackTrackChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackTrackChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_PlaybackTrackChanged
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PlaybackTrackChanged Event

Occurs when the currently playing track changes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Event PlaybackTrackChanged As EventHandler(Of TrackChangedEventArgs)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of TrackChangedEventArgs)

AddHandler instance.PlaybackTrackChanged, handler
```

``` csharp
  public event EventHandler<TrackChangedEventArgs> PlaybackTrackChanged
```

``` c++
  public:
 event EventHandler<TrackChangedEventArgs^>^ PlaybackTrackChanged {
    void add (EventHandler<TrackChangedEventArgs^>^ value);
    void remove (EventHandler<TrackChangedEventArgs^>^ value);
}
```

``` jscript
  JScript does not support events.
```

## Remarks

For more information, see [Select and Monitor Bit Rate (IIS Smooth Streaming)](select-and-monitor-bitrate.md) and [Events (IIS Smooth Streaming)](events.md).

## Examples

Bit-rate changes invoke the PlaybackTrackChanged event. Applications can monitor the bit rate in the delegate that handles the event. The following example shows how to read the new bit rate from the [TrackChangedEventArgs](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md) parameter and display it using a text block.

``` 
    void SmoothPlayer_PlaybackTrackChanged(object sender, TrackChangedEventArgs e)
    {
        OutputText.Text = "Current bit rate: " + e.Track.Bitrate.ToString();
    }
```

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

