---
title: ChunkInfo Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkInfo Class
description: Describes the ChunkInfo Class and provides the field's namespace, assembly, syntax, properties, methods and version information.
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ChunkInfo
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.chunkinfo(v=VS.90)
ms:contentKeyID: 31469186
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ChunkInfo Class

Defines per chunk information for text/binary chunks of Smooth Streaming data.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.SmoothStreaming..::..ChunkInfo  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Class ChunkInfo _
    Implements IComparable
'Usage

  Dim instance As ChunkInfo
```

```csharp
  public class ChunkInfo : IComparable
```

```cpp
  public ref class ChunkInfo : IComparable
```

```jscript
  public class ChunkInfo implements IComparable
```

The ChunkInfo type exposes the following members.

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Attributes](chunkinfo-attributes-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets [Attributes](chunkinfo-attributes-property-microsoft-web-media-smoothstreaming_1.md).|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Duration](chunkinfo-duration-property-microsoft-web-media-smoothstreaming_1.md)|Time duration that corresponds the to the \<d> element in the manifest for the chunk.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Stream](chunkinfo-stream-property-microsoft-web-media-smoothstreaming_1.md)|Gets the [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[TimeStamp](chunkinfo-timestamp-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the start time for the data chunk.|

## Methods

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[CompareTo](chunkinfo-compareto-method-microsoft-web-media-smoothstreaming_1.md)|Compares a chunk to another object.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Examples

The following example shows how to get the ChunkInfo objects in a [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object and how to call the asynchronous method [BeginGetChunk(TimeSpan, AsyncCallback, Object)](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md). For more information, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md)

``` 
    foreach (TrackInfo trackInfo in streamInfo.SelectedTracks)
    {
        foreach (ChunkInfo chunk in streamInfo.ChunkList.ToList<ChunkInfo>())
        {
            IAsyncResult ar =
                trackInfo.BeginGetChunk(
                chunk.TimeStamp, new AsyncCallback(AddMarkers), streamInfo.UniqueId);
        }
    }
```

The following example shows the call to the [EndGetChunk(IAsyncResult)](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md) method. For more information on this asynchronous scenario, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md).

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

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
