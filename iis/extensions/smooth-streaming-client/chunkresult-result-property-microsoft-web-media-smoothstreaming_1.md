---
title: Result Property (Microsoft.Web.Media.SmoothStreaming)
description: Learn how the ChunkResult.Result property gets or sets the result of call to BeginGetChunk or GetChunkUri.
TOCTitle: Result Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkResult.Result
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.chunkresult.result(v=VS.95)
ms:contentKeyID: 46307756
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_Result
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.Result
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_Result
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_Result
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.Result
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_Result
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Result Property

Gets or sets the result of call to [BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) or [GetChunkUri](trackinfo-getchunkuri-method-microsoft-web-media-smoothstreaming_1.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Result As ChunkResult.ChunkResultState
    Get
    Private Set
'Usage

Dim instance As ChunkResult
Dim value As ChunkResult.ChunkResultState

value = instance.Result
```

```csharp
public ChunkResult.ChunkResultState Result { get; private set; }
```

```cpp
public:
property ChunkResult.ChunkResultState Result {
    ChunkResult.ChunkResultState get ();
    private: void set (ChunkResult.ChunkResultState value);
}
```

``` fsharp
member Result : ChunkResult.ChunkResultState with get, private set
```

```jscript
function get Result () : ChunkResult.ChunkResultState
private function set Result (value : ChunkResult.ChunkResultState)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkResultState](chunkresult-chunkresultstate-enumeration-microsoft-web-media-smoothstreaming_1.md)  
A [ChunkResult.ChunkResultState](chunkresult-chunkresultstate-enumeration-microsoft-web-media-smoothstreaming_1.md) object.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ChunkResult Class](chunkresult-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
