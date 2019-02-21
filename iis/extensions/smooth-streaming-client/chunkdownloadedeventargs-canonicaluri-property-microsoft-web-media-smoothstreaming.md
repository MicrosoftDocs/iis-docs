---
title: ChunkDownloadedEventArgs.CanonicalUri Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CanonicalUri Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.CanonicalUri
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkdownloadedeventargs.canonicaluri(v=VS.95)
ms:contentKeyID: 46307750
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.CanonicalUri
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_CanonicalUri
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_CanonicalUri
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.CanonicalUri
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_CanonicalUri
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_CanonicalUri
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ChunkDownloadedEventArgs.CanonicalUri Property

Gets the canonical URI for downloading the current chunk.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property CanonicalUri As Uri
    Get
    Private Set
'Usage

Dim instance As ChunkDownloadedEventArgs
Dim value As Uri

value = instance.CanonicalUri
```

```csharp
public Uri CanonicalUri { get; private set; }
```

```cpp
public:
property Uri^ CanonicalUri {
    Uri^ get ();
    private: void set (Uri^ value);
}
```

``` fsharp
member CanonicalUri : Uri with get, private set
```

```jscript
function get CanonicalUri () : Uri
private function set CanonicalUri (value : Uri)
```

### Property Value

Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))  
The canonical URI.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ChunkDownloadedEventArgs Class](chunkdownloadedeventargs-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

