---
title: ChunkInfo.TimeStamp Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: TimeStamp Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkInfo.TimeStamp
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.chunkinfo.timestamp(v=VS.95)
ms:contentKeyID: 46307761
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.get_TimeStamp
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.set_TimeStamp
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.TimeStamp
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.get_TimeStamp
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.set_TimeStamp
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.TimeStamp
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ChunkInfo.TimeStamp Property

Gets or sets the start time for the data chunk.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property TimeStamp As TimeSpan
    Get
    Friend Set
'Usage

Dim instance As ChunkInfo
Dim value As TimeSpan

value = instance.TimeStamp
```

```csharp
public TimeSpan TimeStamp { get; internal set; }
```

```cpp
public:
property TimeSpan TimeStamp {
    TimeSpan get ();
    internal: void set (TimeSpan value);
}
```

``` fsharp
member TimeStamp : TimeSpan with get, internal set
```

```jscript
function get TimeStamp () : TimeSpan
internal function set TimeStamp (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
A [TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\)) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[ChunkInfo Class](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
