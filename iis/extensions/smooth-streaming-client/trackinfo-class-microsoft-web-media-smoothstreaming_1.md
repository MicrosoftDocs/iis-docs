---
title: TrackInfo Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: TrackInfo Class
description: "The TrackInfo class represents track information that corresponds to the QualityLevel element of the client manifest."
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.TrackInfo
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.trackinfo(v=VS.95)
ms:contentKeyID: 46307958
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TrackInfo Class

Represents track information that corresponds to the QualityLevel element of the client manifest.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  Microsoft.Web.Media.SmoothStreaming.TrackInfo  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class TrackInfo _
    Implements IComparable
'Usage

Dim instance As TrackInfo
```

```csharp
public class TrackInfo : IComparable
```

```cpp
public ref class TrackInfo : IComparable
```

``` fsharp
type TrackInfo =  
    class
        interface IComparable
    end
```

```jscript
public class TrackInfo implements IComparable
```

The TrackInfo type exposes the following members.

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Attributes](trackinfo-attributes-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the attributes for a track.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Bitrate](trackinfo-bitrate-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [Bitrate](trackinfo-bitrate-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[CustomAttributes](trackinfo-customattributes-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [CustomAttributes](trackinfo-customattributes-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Index](trackinfo-index-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [Index](trackinfo-index-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Stream](trackinfo-stream-property-microsoft-web-media-smoothstreaming_1.md)|Gets the stream for this track.|

## Methods

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md)|Beginning method of the asynchronous API for the application to get chunk content based on the timestamp.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[CompareTo](trackinfo-compareto-method-microsoft-web-media-smoothstreaming_1.md)|Compares a T:Microsoft.Web.Media.SmoothStreaming.TrackInfo object to an object specified by the obj parameter.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[EndGetChunk](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md)|Method to complete the action of [BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md).|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[GetChunkUri](trackinfo-getchunkuri-method-microsoft-web-media-smoothstreaming_1.md)|Gets the Uri for the chunk identified by the timestamp parameter.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ToString](trackinfo-tostring-method-microsoft-web-media-smoothstreaming_1.md)|Writes a TrackInfo object to string. (Overrides [Object.ToString()](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95)).)|

## Remarks

The QualityLevel elements of the client manifest are nested inside StreamIndex elements. To access the corresponding TrackInfo objects in application code, start with the [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) property of the [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) object. Both the [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) and [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md) collections contain [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects, which, in turn, contain TrackInfo objects in the [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) and [SelectedTracks](streaminfo-selectedtracks-property-microsoft-web-media-smoothstreaming_1.md) properties.

For an example that uses TrackInfo objects, see [Timeline Markers and Events](timeline-markers-and-events.md) under the heading "Extract Timeline Events and Assign Markers."

## Examples

The following example shows how to parse [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) and [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects to access TrackInfo objects.

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
