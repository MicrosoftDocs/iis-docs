---
title: ManifestInfo Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ManifestInfo Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ManifestInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.manifestinfo(v=VS.95)
ms:contentKeyID: 46307943
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ManifestInfo Class

Represents the manifest in application code. This class corresponds to the \<SmoothStreamingMedia\> element in the client manifest and to the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md).

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  Microsoft.Web.Media.SmoothStreaming.ManifestInfo  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class ManifestInfo
'Usage

Dim instance As ManifestInfo
```

```csharp
public class ManifestInfo
```

```cpp
public ref class ManifestInfo
```

``` fsharp
type ManifestInfo =  class end
```

```jscript
public class ManifestInfo
```

The ManifestInfo type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Attributes](manifestinfo-attributes-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets attributes.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[LogUris](manifestinfo-loguris-property-microsoft-web-media-smoothstreaming_1.md)|Gets the list of logging Uri objects.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ManifestType](manifestinfo-manifesttype-property-microsoft-web-media-smoothstreaming.md)||
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ProtectionInfo](manifestinfo-protectioninfo-property-microsoft-web-media-smoothstreaming_1.md)|Contains information specified in the protection element inside the manifest.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Segments](manifestinfo-segments-property-microsoft-web-media-smoothstreaming_1.md)|List of [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) objects. There is a SegmentInfo for each <Clip> element in the manifest.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Ff728153.static(en-us,VS.90).gif "Static member")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ParseManifest](manifestinfo-parsemanifest-method-microsoft-web-media-smoothstreaming_1.md)|Parses the Smooth Streaming manifest.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|


## Events

||Name|Description|
|--- |--- |--- |
|![Public event](images/Ff728262.pubevent(en-us,VS.90).gif "Public event")|[ChunkListChanged](manifestinfo-chunklistchanged-event-microsoft-web-media-smoothstreaming_1.md)|Event activated when the fragment info of a new text/binary chunk in a live scenario is added to the manifest. This event will fire on the UI thread.|
|![Public event](images/Ff728262.pubevent(en-us,VS.90).gif "Public event")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[SelectStreamsCompleted](manifestinfo-selectstreamscompleted-event-microsoft-web-media-smoothstreaming_1.md)|Event activated when a [SelectStreamsAsync](segmentinfo-selectstreamsasync-method-microsoft-web-media-smoothstreaming_1.md) call has completed in any of the segments contained in [Segments](manifestinfo-segments-property-microsoft-web-media-smoothstreaming_1.md).|


## Remarks

The object represents the top element in the client manifest. It has a collection of [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) objects, which each contain [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) and [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) collections. These [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects contain the audio, video, and textual data of Smooth Streaming presentations. The [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property must include exactly one video stream and one audio stream. Non-audio/video streams do not have this restriction and can be multiply selected and deselected. The streams in the list must be members of the current segment’s [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) and/or [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) collections. To generate the lists of available streams or selected streams use a [List\<T\>.CopyTo](http://msdn.microsoft.com/en-us/library/t69dktcd\(v=vs.100\).aspx) constructor of type [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) to copy either the [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) or the [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property. Add or remove streams until you have the desired list.

Notifications for de-selection of current streams will arrive before selection notifications on a per-segment basis. Applications can clean up any state associated with the deselected stream before adding state associated with the new stream. However, due to the possibility of multiple segments, it is preferable to use the [UniqueId](streaminfo-uniqueid-property-microsoft-web-media-smoothstreaming_1.md) property to identify the stream with which objects are associated.

## Examples

The following example shows how to get [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) and [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects from the ManifestInfo object.

For more information, see [Microsoft Smooth Streaming Client 2.0](microsoft-smooth-streaming-client-2-0.md)

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

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

