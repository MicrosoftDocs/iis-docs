---
title: TrackInfo.BeginGetChunk Method  (Microsoft.Web.Media.SmoothStreaming)
description: TrackInfo.BeginGetChunk Method beginning method of the asynchronous API for the application to get chunk content based on the timestamp.
TOCTitle: BeginGetChunk Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.TrackInfo.BeginGetChunk(System.TimeSpan,System.AsyncCallback,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.trackinfo.begingetchunk(v=VS.95)
ms:contentKeyID: 46307710
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.BeginGetChunk
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.BeginGetChunk
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TrackInfo.BeginGetChunk Method

Beginning method of the asynchronous API for the application to get chunk content based on the timestamp.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Overridable Function BeginGetChunk ( _
    timestamp As TimeSpan, _
    callback As AsyncCallback, _
    state As Object _
) As IAsyncResult
'Usage

Dim instance As TrackInfo
Dim timestamp As TimeSpan
Dim callback As AsyncCallback
Dim state As Object
Dim returnValue As IAsyncResult

returnValue = instance.BeginGetChunk(timestamp, _
    callback, state)
```

```csharp
public virtual IAsyncResult BeginGetChunk(
    TimeSpan timestamp,
    AsyncCallback callback,
    Object state
)
```

```cpp
public:
virtual IAsyncResult^ BeginGetChunk(
    TimeSpan timestamp, 
    AsyncCallback^ callback, 
    Object^ state
)
```

``` fsharp
abstract BeginGetChunk : 
        timestamp:TimeSpan * 
        callback:AsyncCallback * 
        state:Object -> IAsyncResult 
override BeginGetChunk : 
        timestamp:TimeSpan * 
        callback:AsyncCallback * 
        state:Object -> IAsyncResult 
```

```jscript
public function BeginGetChunk(
    timestamp : TimeSpan, 
    callback : AsyncCallback, 
    state : Object
) : IAsyncResult
```

### Parameters

  - timestamp  
    Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
    The timestamp of the chunk start time as a [TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\)) object.

<!-- end list -->

  - callback  
    Type: [System.AsyncCallback](https://msdn.microsoft.com/library/ckbe7yh5\(v=vs.95\))  
    [AsyncCallback](https://msdn.microsoft.com/library/ckbe7yh5\(v=vs.95\)) delegate method that completes the get chunk action.

<!-- end list -->

  - state  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
    The state information passed in by the application as [Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\)).

### Return Value

Type: [System.IAsyncResult](https://msdn.microsoft.com/library/ft8a6455\(v=vs.95\))  
An [IAsyncResult](https://msdn.microsoft.com/library/ft8a6455\(v=vs.95\)) object.

## Remarks

The method will always return immediately. It may finish the operation in the same thread or start a new thread to do the work.

The following example loops through segments, streams, and tracks to get the closed captions track. The BeginGetChunk(TimeSpan, AsyncCallback, Object) method starts an asynchronous process that will get each data chunk. For the complete example and more information, see [Timeline Markers and Events](timeline-markers-and-events.md).

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

Supported in: 5  

## See Also

### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
