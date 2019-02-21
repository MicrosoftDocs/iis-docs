---
title: StreamInfo.SelectTracks Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SelectTracks Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.StreamInfo.SelectTracks(System.Collections.Generic.IList{Microsoft.Web.Media.SmoothStreaming.TrackInfo},System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.selecttracks(v=VS.95)
ms:contentKeyID: 46307697
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.SelectTracks
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.SelectTracks
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# StreamInfo.SelectTracks Method

Selects [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) objects for this stream. For more information see [Select and Monitor Bitrate](select-and-monitor-bitrate.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Function SelectTracks ( _
    selectedTracks As IList(Of TrackInfo), _
    flushBuffer As Boolean _
) As Boolean
'Usage

Dim instance As StreamInfo
Dim selectedTracks As IList(Of TrackInfo)
Dim flushBuffer As Boolean
Dim returnValue As Boolean

returnValue = instance.SelectTracks(selectedTracks, _
    flushBuffer)
```

```csharp
public bool SelectTracks(
    IList<TrackInfo> selectedTracks,
    bool flushBuffer
)
```

```cpp
public:
bool SelectTracks(
    IList<TrackInfo^>^ selectedTracks, 
    bool flushBuffer
)
```

``` fsharp
member SelectTracks : 
        selectedTracks:IList<TrackInfo> * 
        flushBuffer:bool -> bool 
```

```jscript
public function SelectTracks(
    selectedTracks : IList<TrackInfo>, 
    flushBuffer : boolean
) : boolean
```

### Parameters

  - selectedTracks  
    Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)\>  
    The [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) objects for this stream.

<!-- end list -->

  - flushBuffer  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
    A Boolean value that specifies whether to flush buffers.

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
A Boolean value, true if the method succeeds, otherwise false.

## Remarks

When SelectTracks(IList\<TrackInfo\>, Boolean) is called during the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event, [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) is restricted to the new set of selected tracks. This allows an application to lock the set of video tracks to those which all have the same resolution. This is useful in Windows Phone applications because Windows Phone cannot decode multi-resolution video content. SelectTracks(IList\<TrackInfo\>, Boolean) must not be called more than once.

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

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

