---
title: CacheResponse2 Constructor (Stream, Boolean) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheResponse2 Constructor (Stream, Boolean)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.CacheResponse2.#ctor(System.IO.Stream,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse2.cacheresponse2(v=VS.95)
ms:contentKeyID: 46307642
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
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheResponse2 Constructor (Stream, Boolean)

Initializes a new instance of the [CacheResponse2](cacheresponse2-class-microsoft-web-media-smoothstreaming.md) class based on the specified stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

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

Dim instance As New CacheResponse2(stream, _
    continueProcessing)
```

```csharp
public CacheResponse2(
    Stream stream,
    bool continueProcessing
)
```

```cpp
public:
CacheResponse2(
    Stream^ stream, 
    bool continueProcessing
)
```

``` fsharp
new : 
        stream:Stream * 
        continueProcessing:bool -> CacheResponse2
```

```jscript
public function CacheResponse2(
    stream : Stream, 
    continueProcessing : boolean
)
```

### Parameters

  - stream  
    Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\))  
    The stream from which to deserialize.

<!-- end list -->

  - continueProcessing  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
    true if processing is allowed for downstream cache modules; otherwise, false.

## Remarks

The CacheResponse2 instance reads from a stream that has been written using the [WriteTo(Stream)](cacheresponse-writeto-method-microsoft-web-media-smoothstreaming_1.md) method. Because serialization uses big-endian byte order for wire format, deserialization can take place on a different platform.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[CacheResponse2 Class](cacheresponse2-class-microsoft-web-media-smoothstreaming.md)

[CacheResponse2 Overload](cacheresponse2-constructor-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
