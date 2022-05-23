---
title: StreamInfo.ChunkList Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkList Property
description: Describes the StreamInfo.ChunkList property and provides the field's namespace, assembly, syntax, and version information.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChunkList
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.chunklist(v=VS.95)
ms:contentKeyID: 46307862
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChunkList
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ChunkList
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChunkList
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ChunkList
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StreamInfo.ChunkList Property

Gets the list of chunks for this stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property ChunkList As IList(Of ChunkInfo)
    Get
'Usage

Dim instance As StreamInfo
Dim value As IList(Of ChunkInfo)

value = instance.ChunkList
```

```csharp
public IList<ChunkInfo> ChunkList { get; }
```

```cpp
public:
property IList<ChunkInfo^>^ ChunkList {
    IList<ChunkInfo^>^ get ();
}
```

``` fsharp
member ChunkList : IList<ChunkInfo>
```

```jscript
function get ChunkList () : IList<ChunkInfo>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[ChunkInfo](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md)\>  
An IList of [ChunkInfo](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md) objects.

## Examples

The following example uses the ChunkList property to get data chunks and call the [BeginGetChunk(TimeSpan, AsyncCallback, Object)](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) method. For more information, see [Timeline Markers and Events](timeline-markers-and-events.md).

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

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
