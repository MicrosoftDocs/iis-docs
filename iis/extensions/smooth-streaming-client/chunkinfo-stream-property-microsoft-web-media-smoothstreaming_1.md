---
title: ChunkInfo.Stream Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Stream Property
description: This article contains syntax, property value, and version information for the ChunkInfo.Stream property.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkInfo.Stream
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.chunkinfo.stream(v=VS.95)
ms:contentKeyID: 46307754
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.get_Stream
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.Stream
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.get_Stream
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.Stream
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ChunkInfo.Stream Property

Gets the [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property Stream As StreamInfo
    Get
'Usage

Dim instance As ChunkInfo
Dim value As StreamInfo

value = instance.Stream
```

```csharp
public StreamInfo Stream { get; }
```

```cpp
public:
property StreamInfo^ Stream {
    StreamInfo^ get ();
}
```

``` fsharp
member Stream : StreamInfo
```

```jscript
function get Stream () : StreamInfo
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[ChunkInfo Class](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
