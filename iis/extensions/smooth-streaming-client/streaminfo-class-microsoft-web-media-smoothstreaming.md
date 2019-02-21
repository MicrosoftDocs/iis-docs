---
title: StreamInfo Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamInfo Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.StreamInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo(v=VS.90)
ms:contentKeyID: 23961256
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StreamInfo Class

Defines the basic information for each stream. This class corresponds to the StreamIndex element of the client manifest. You can extend the class to add private data per stream.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.SmoothStreaming..::..StreamInfo  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Class StreamInfo
'Usage

  Dim instance As StreamInfo
```

```csharp
  public class StreamInfo
```

```cpp
  public ref class StreamInfo
```

```jscript
  public class StreamInfo
```

The StreamInfo type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Attributes](streaminfo-attributes-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets attributes for this stream.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md)|Gets the [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ChildStreams](streaminfo-childstreams-property-microsoft-web-media-smoothstreaming_1.md)|Gets the [ChildStreams](streaminfo-childstreams-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ChunkList](streaminfo-chunklist-property-microsoft-web-media-smoothstreaming_1.md)|Gets the list of chunks for this stream.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ParentStream](streaminfo-parentstream-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the parent stream in the case of a sparse stream. Otherwise this is null.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Segment](streaminfo-segment-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the segment for this stream.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[SelectedTracks](streaminfo-selectedtracks-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [SelectedTracks](streaminfo-selectedtracks-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Subtype](streaminfo-subtype-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [Subtype](streaminfo-subtype-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Type](streaminfo-type-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [Type](streaminfo-type-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[UniqueId](streaminfo-uniqueid-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the Id that identifies this stream.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[RestrictTracks](streaminfo-restricttracks-method-microsoft-web-media-smoothstreaming_1.md)|Replaces [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) with the list of available tracks supplied by the parameter. Also restricts decoder initialization to the given list of available tracks to avoid initializing the decoder with unsupported modes.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[SelectTracks](streaminfo-selecttracks-method-microsoft-web-media-smoothstreaming_1.md)|Selects [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) objects for this stream. For more information see [Select and Monitor Bit Rate (IIS Smooth Streaming)](select-and-monitor-bitrate.md).|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ToString](streaminfo-tostring-method-microsoft-web-media-smoothstreaming_1.md)|Writes the StreamInfo item to a string. (Overrides [Object.ToString() () () ()](https://msdn.microsoft.com/library/7bxwbwt2).)|


## Remarks

The [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) property of the [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) object contains a collection of StreamInfo objects. The [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property of the [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) object must include exactly one video StreamInfo object and one audio StreamInfo object. Text streams do not have this restriction and can be multiply selected and deselected. Streams must be members of the current segment’s [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) and/or [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property. To generate the lists of available streams or selected streams use a [List\<T\>.CopyTo](http://msdn.microsoft.com/en-us/library/t69dktcd\(v=vs.100\).aspx) constructor of type StreamInfo to copy either the [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) or the [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) property. Add or remove streams until you have the desired list.

Notifications for de-selection of current streams will arrive before selection notifications on a per-segment basis. Applications can clean up any state associated with the deselected stream before adding state associated with the new stream. However, due to the possibility of multiple segments, it is preferable to use the [UniqueId](streaminfo-uniqueid-property-microsoft-web-media-smoothstreaming_1.md) property to identify the stream with which objects are associated.

For an implementation example that parses StreamInfo objects, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md) under the heading "Extract Timeline Events and Assign Markers."

## Examples

The following example shows how to get [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) and StreamInfo objects from the [ManifestInfo](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md) object.

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

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

