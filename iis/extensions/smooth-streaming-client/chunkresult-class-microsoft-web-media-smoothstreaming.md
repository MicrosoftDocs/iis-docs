---
title: ChunkResult Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkResult Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ChunkResult
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkresult(v=VS.90)
ms:contentKeyID: 31469214
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ChunkResult Class

Contains all the result information for the [BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) and [EndGetChunk](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md) methods.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.SmoothStreaming..::..ChunkResult  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Class ChunkResult
'Usage

  Dim instance As ChunkResult
```

```csharp
  public class ChunkResult
```

```cpp
  public ref class ChunkResult
```

```jscript
  public class ChunkResult
```

The ChunkResult type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ChunkData](chunkresult-chunkdata-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the data contained by ChunkResult.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Error](chunkresult-error-property-microsoft-web-media-smoothstreaming_1.md)|Contains error information if an error occurs.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Result](chunkresult-result-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the result of call to [BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) or [GetChunkUri](trackinfo-getchunkuri-method-microsoft-web-media-smoothstreaming_1.md).|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Timestamp](chunkresult-timestamp-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the time stamp of the chunk in ticks.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|


## Examples

The following example shows the call to the [EndGetChunk(IAsyncResult)](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md) method and return of a ChunkResult object that contains the results data and indicates success or failure. For more information on this asynchronous scenario, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md).

``` 
    foreach (TrackInfo trackInfo in streamInfo.SelectedTracks)
    {
        ChunkResult chunkResult = trackInfo.EndGetChunk(argAR);

        if (chunkResult.Result == ChunkResult.ChunkResultState.Succeeded)
        {
            System.Text.Encoding enc = System.Text.Encoding.UTF8;
            int length = (int)chunkResult.ChunkData.Length;
            byte[] rawData = new byte[length];
            chunkResult.ChunkData.Read(rawData, 0, length);
            String text = enc.GetString(rawData, 0, rawData.Length);
            TimelineMarker newMarker = new TimelineMarker();
            newMarker.Text = text;
            newMarker.Time = chunkResult.Timestamp;

            SmoothPlayer.Markers.Add(newMarker);
        }
    }
```

## Version Information

### Silverlight

Supported in: 4  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

