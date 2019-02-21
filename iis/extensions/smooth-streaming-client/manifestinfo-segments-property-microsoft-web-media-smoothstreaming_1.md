---
title: ManifestInfo.Segments Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Segments Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ManifestInfo.Segments
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.manifestinfo.segments(v=VS.95)
ms:contentKeyID: 46307778
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.get_Segments
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.Segments
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.set_Segments
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.get_Segments
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.set_Segments
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.Segments
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ManifestInfo.Segments Property

List of [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) objects. There is a SegmentInfo for each \<Clip\> element in the manifest.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Segments As IList(Of SegmentInfo)
    Get
    Private Set
'Usage

Dim instance As ManifestInfo
Dim value As IList(Of SegmentInfo)

value = instance.Segments
```

```csharp
public IList<SegmentInfo> Segments { get; private set; }
```

```cpp
public:
property IList<SegmentInfo^>^ Segments {
    IList<SegmentInfo^>^ get ();
    private: void set (IList<SegmentInfo^>^ value);
}
```

``` fsharp
member Segments : IList<SegmentInfo> with get, private set
```

```jscript
function get Segments () : IList<SegmentInfo>
private function set Segments (value : IList<SegmentInfo>)
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)\>  
Generic list of [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) objects.

## Remarks

The [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) property of the [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) object contains a collection of [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects. The [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property must include exactly one video stream and one audio stream. Non-audio/video streams do not have this restriction and can be multiply selected and deselected. The streams in the list must be members of the current segment’s [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) or [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property. To generate the lists of available streams or selected streams use a [List\<T\>.CopyTo](http://msdn.microsoft.com/en-us/library/t69dktcd\(v=vs.100\).aspx) constructor of type [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) to copy either the [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) or the [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property. Add or remove streams until you have the desired list.

You will get notifications for de-selection of current streams followed by selection of new ones. All de-selection notifications will arrive before selection notifications on a per-segment basis. This allows you to clean up any state associated with the deselected stream before adding state associated with the new stream. However, due to the possibility of multiple segments, it is preferable to use the [UniqueId](streaminfo-uniqueid-property-microsoft-web-media-smoothstreaming_1.md) property to identify any objects that are associated with a stream.

## Examples

The following example shows how to get [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) and [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects from the [ManifestInfo](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md) object.

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

[ManifestInfo Class](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

