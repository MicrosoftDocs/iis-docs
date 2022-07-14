---
title: CacheResponse Constructor (Stream) (Microsoft.Web.Media.SmoothStreaming)
description: Learn how the CacheResponse Constructor (Stream) initializes a new instance of the CacheResponse class from a Stream object.
TOCTitle: CacheResponse Constructor (Stream)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.CacheResponse.#ctor(System.IO.Stream)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse.cacheresponse(v=VS.95)
ms:contentKeyID: 46500551
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheResponse Constructor (Stream)

Initializes a new instance of the [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md) class from a [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    stream As Stream _
)
'Usage

Dim stream As Stream

Dim instance As New CacheResponse(stream)
```

```csharp
public CacheResponse(
    Stream stream
)
```

```cpp
public:
CacheResponse(
    Stream^ stream
)
```

``` fsharp
new : 
        stream:Stream -> CacheResponse
```

```jscript
public function CacheResponse(
    stream : Stream
)
```

### Parameters

  - stream  
    Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\))  
    A [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object.

## Version Information

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[CacheResponse Overload](cacheresponse-constructor-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
