---
title: ChunkResult.ChunkData Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkData Property
description: Describes the ChunkResult.ChunkData property and provides the syntax, property value, and version information.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkData
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.chunkresult.chunkdata(v=VS.95)
ms:contentKeyID: 46307755
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkData
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_ChunkData
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_ChunkData
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkData
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_ChunkData
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_ChunkData
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ChunkResult.ChunkData Property

Gets or sets the data contained by [ChunkResult](chunkresult-class-microsoft-web-media-smoothstreaming_1.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ChunkData As Stream
    Get
    Private Set
'Usage

Dim instance As ChunkResult
Dim value As Stream

value = instance.ChunkData
```

```csharp
public Stream ChunkData { get; private set; }
```

```cpp
public:
property Stream^ ChunkData {
    Stream^ get ();
    private: void set (Stream^ value);
}
```

``` fsharp
member ChunkData : Stream with get, private set
```

```jscript
function get ChunkData () : Stream
private function set ChunkData (value : Stream)
```

### Property Value

Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\))  
A [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ChunkResult Class](chunkresult-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
