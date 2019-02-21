---
title: ChunkDownloadedEventArgs.Chunk Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Chunk Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.Chunk
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkdownloadedeventargs.chunk(v=VS.95)
ms:contentKeyID: 46307751
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_Chunk
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_Chunk
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.Chunk
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.Chunk
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_Chunk
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_Chunk
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ChunkDownloadedEventArgs.Chunk Property

Gets the chunk being downloaded.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Chunk As ChunkInfo
    Get
    Private Set
'Usage

Dim instance As ChunkDownloadedEventArgs
Dim value As ChunkInfo

value = instance.Chunk
```

```csharp
public ChunkInfo Chunk { get; private set; }
```

```cpp
public:
property ChunkInfo^ Chunk {
    ChunkInfo^ get ();
    private: void set (ChunkInfo^ value);
}
```

``` fsharp
member Chunk : ChunkInfo with get, private set
```

```jscript
function get Chunk () : ChunkInfo
private function set Chunk (value : ChunkInfo)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ChunkInfo](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md)  
A ChunkInfo object that represents the chunk being downloaded.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ChunkDownloadedEventArgs Class](chunkdownloadedeventargs-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

