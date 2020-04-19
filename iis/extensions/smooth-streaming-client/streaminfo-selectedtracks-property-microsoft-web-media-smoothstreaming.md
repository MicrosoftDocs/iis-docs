---
title: StreamInfo.SelectedTracks Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SelectedTracks Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.SelectedTracks
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.selectedtracks(v=VS.90)
ms:contentKeyID: 23961114
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.SelectedTracks
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_SelectedTracks
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_SelectedTracks
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.SelectedTracks
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SelectedTracks Property

Gets or sets the SelectedTracks property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property SelectedTracks As IList(Of TrackInfo)
'Usage

  Dim instance As StreamInfo
Dim value As IList(Of TrackInfo)

value = instance.SelectedTracks
```

```csharp
  public IList<TrackInfo> SelectedTracks { get; }
```

```cpp
  public:
property IList<TrackInfo^>^ SelectedTracks {
    IList<TrackInfo^>^ get ();
}
```

```jscript
  function get SelectedTracks () : IList<TrackInfo>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\< (Of \< ( \<'[TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
A generic list of [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) objects.  

## Remarks

For more information and an example that parses [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md) under the heading "Extract Timeline Events and Assign Markers."

## Examples

The following example shows how to select tracks from [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) and [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects.

``` 
    void SmoothPlayer_ManifestReady(object sender, EventArgs e)
    {
        if (!PremiumAccount)
        {
            foreach (SegmentInfo segment in SmoothPlayer.ManifestInfo.Segments)
            {
                IList<StreamInfo> streamInfoList = segment.AvailableStreams;
                foreach (StreamInfo stream in streamInfoList)
                {
                    if (stream.Type == MediaStreamType.Video)
                    {
                        // Limit bit-rate to 866000.
                        ulong highRate = 866000 + 1;
                        List<TrackInfo> tracks = new List<TrackInfo>();

                        tracks = stream.AvailableTracks.ToList<TrackInfo>();
                        IList<TrackInfo> allowedTracks = tracks.Where((ti) => ti.Bitrate < highRate).ToList();
                        stream.SelectTracks(allowedTracks, false);
                    }
                }
            }
        }
    }
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

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
