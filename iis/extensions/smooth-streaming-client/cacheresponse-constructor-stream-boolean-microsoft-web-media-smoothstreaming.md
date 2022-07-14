---
title: CacheResponse Constructor (Stream, Boolean) (Microsoft.Web.Media.SmoothStreaming)
description: The CacheResponse constructor (Stream, Boolean) initializes a new instance of the CacheResponse class from a Stream object.
TOCTitle: CacheResponse Constructor (Stream, Boolean)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.CacheResponse.#ctor(System.IO.Stream,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse.cacheresponse(v=VS.95)
ms:contentKeyID: 46307640
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

# CacheResponse Constructor (Stream, Boolean)

Initializes a new instance of the [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md) class from a [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object specifying whether to continue processing in case of a cache miss.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    stream As Stream, _
    continueProcessing As Boolean _
)
'Usage

Dim stream As Stream
Dim continueProcessing As Boolean

Dim instance As New CacheResponse(stream, _
    continueProcessing)
```

```csharp
public CacheResponse(
    Stream stream,
    bool continueProcessing
)
```

```cpp
public:
CacheResponse(
    Stream^ stream, 
    bool continueProcessing
)
```

``` fsharp
new : 
        stream:Stream * 
        continueProcessing:bool -> CacheResponse
```

```jscript
public function CacheResponse(
    stream : Stream, 
    continueProcessing : boolean
)
```

### Parameters

  - stream  
    Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\))  
    A [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object.

<!-- end list -->

  - continueProcessing  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
    A Boolean value indicating whether cache response processing continues to the next cache module (including HTTP download) in case of a cache miss. true if the cache response processing continues; otherwise, false.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[CacheResponse Overload](cacheresponse-constructor-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
