---
title: SegmentInfo Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SegmentInfo Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SegmentInfo
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.segmentinfo(v=VS.90)
ms:contentKeyID: 31469293
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SegmentInfo Class

Defines the information that must be exposed by any manifest parser. This class corresponds to the Clip element in the composite manifest. You can extend the class with private data if a custom parser needs more information.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.SmoothStreaming..::..SegmentInfo  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Class SegmentInfo
'Usage

  Dim instance As SegmentInfo
```

```csharp
  public class SegmentInfo
```

```cpp
  public ref class SegmentInfo
```

```jscript
  public class SegmentInfo
```

The SegmentInfo type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md)|Gets the available [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects that is contained by a SegmentInfo object.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[EndPosition](segmentinfo-endposition-property-microsoft-web-media-smoothstreaming_1.md)|Gets the minimum of the end time for the last audio chunk and last video chunk.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md)|Gets the selected [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[StartPosition](segmentinfo-startposition-property-microsoft-web-media-smoothstreaming_1.md)|Gets the maximum of the start times of the first audio chunk and first video chunk.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[SelectStreamsAsync(IList< (Of < <' (StreamInfo> ) > > ))](segmentinfo-selectstreamsasync-method-ilist-streaminfo-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the SegmentInfo class.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[SelectStreamsAsync(IList< (Of < <' (StreamInfo> ) > > ), Object)](segmentinfo-selectstreamsasync-method-ilist-streaminfo-object-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the SegmentInfo class.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|


## Remarks

For the client manifest, on demand and live, there is only one SegmentInfo object. You can refer to it as the zeroth segment of [Segments](manifestinfo-segments-property-microsoft-web-media-smoothstreaming_1.md). For composite manifests, there can be multiple SegmentInfo objects. (Composite manifests are currently exposed as one segment, but applications should use segment-handling code that can be called on several segments. Do not assume that ManifestInfo.Segments\[0\] is the current segment.)

SegmentInfo objects contain a list of all available and selected streams and a method for stream selection. The [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) and [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) collections represent all the streams in the Smooth Streaming presentation.

For implementation examples, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md) and other topics in [IIS Smooth Streaming Client 1.5](microsoft-smooth-streaming-client-2-0.md).

## Examples

The following example shows code that loops through any number of SegmentInfo objects.

``` 
    void SmoothPlayer_MediaOpened(object sender, RoutedEventArgs e)
    {
        foreach (SegmentInfo segmentInfo in SmoothPlayer.ManifestInfo.Segments)
        {
            List<StreamInfo> selectStreams = segmentInfo.SelectedStreams.ToList<StreamInfo>();
            foreach (StreamInfo streamInfo in segmentInfo.AvailableStreams)
            {
                if (streamInfo.Type == System.Windows.Media.MediaStreamType.Script)
                {
                    if (streamInfo.Attributes["Name"] == "ClosedCaptions" ||
                                            streamInfo.Attributes["Name"] == "MARKERS")
                    {
                        selectStreams.Add(streamInfo);
                        segmentInfo.SelectStreamsAsync(selectStreams);

                        foreach (TrackInfo trackInfo in streamInfo.SelectedTracks)
                        {
                            foreach (ChunkInfo chunk in streamInfo.ChunkList.ToList<ChunkInfo>())
                            {
                                IAsyncResult ar =
                                    trackInfo.BeginGetChunk(
                                    chunk.TimeStamp, new AsyncCallback(AddMarkers), streamInfo.UniqueId);
                            }
                        }
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

