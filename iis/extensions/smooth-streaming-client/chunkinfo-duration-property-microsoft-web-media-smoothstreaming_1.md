---
title: ChunkInfo.Duration Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Duration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkInfo.Duration
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkinfo.duration(v=VS.95)
ms:contentKeyID: 46307760
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.Duration
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.get_Duration
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.set_Duration
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.Duration
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.set_Duration
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.get_Duration
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChunkInfo.Duration Property

Time duration that corresponds the to the \<d\> element in the manifest for the chunk.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Duration As TimeSpan
    Get
    Private Set
'Usage

Dim instance As ChunkInfo
Dim value As TimeSpan

value = instance.Duration
```

```csharp
public TimeSpan Duration { get; private set; }
```

```cpp
public:
property TimeSpan Duration {
    TimeSpan get ();
    private: void set (TimeSpan value);
}
```

``` fsharp
member Duration : TimeSpan with get, private set
```

```jscript
function get Duration () : TimeSpan
private function set Duration (value : TimeSpan)
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

