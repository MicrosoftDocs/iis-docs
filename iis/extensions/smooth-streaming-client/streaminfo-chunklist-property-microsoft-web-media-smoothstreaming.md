---
title: StreamInfo.ChunkList Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkList Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChunkList
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.chunklist(v=VS.90)
ms:contentKeyID: 31469211
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChunkList
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ChunkList
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChunkList
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ChunkList
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChunkList Property

Gets the list of chunks for this stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property ChunkList As IList(Of ChunkInfo)
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

```jscript
  function get ChunkList () : IList<ChunkInfo>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\< (Of \< ( \<'[ChunkInfo](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
An IList of [ChunkInfo](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md) objects.  

## Examples

The following example uses the ChunkList property to get data chunks and call the [BeginGetChunk(TimeSpan, AsyncCallback, Object)](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) method. For more information, see see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md).

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

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

