---
title: SmoothStreamingMediaElement.DownloadTrackChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: DownloadTrackChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadTrackChanged
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.downloadtrackchanged(v=VS.90)
ms:contentKeyID: 23961129
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadTrackChanged
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_DownloadTrackChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadTrackChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_DownloadTrackChanged
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DownloadTrackChanged Event

Occurs when the track selected for download differs from the previously selected track.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
Public Event DownloadTrackChangedAsEventHandler(OfTrackChangedEventArgs)
'Usage
DiminstanceAsSmoothStreamingMediaElementDimhandlerAsEventHandler(OfTrackChangedEventArgs)

AddHandler instance.DownloadTrackChanged, handler
```

``` csharp
public event EventHandler<TrackChangedEventArgs> DownloadTrackChanged
```

``` c++
public:
 eventEventHandler<TrackChangedEventArgs^>^ DownloadTrackChanged {
    voidadd (EventHandler<TrackChangedEventArgs^>^ value);
    voidremove (EventHandler<TrackChangedEventArgs^>^ value);
}
```

``` jscript
JScript does not support events.
```

## Remarks

For more information, see [Events (IIS Smooth Streaming)](events.md).

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

