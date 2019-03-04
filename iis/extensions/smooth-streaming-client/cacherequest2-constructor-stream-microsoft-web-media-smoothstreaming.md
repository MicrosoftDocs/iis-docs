---
title: CacheRequest2 Constructor (Stream) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheRequest2 Constructor (Stream)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.CacheRequest2.#ctor(System.IO.Stream)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacherequest2.cacherequest2(v=VS.95)
ms:contentKeyID: 46307639
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
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CacheRequest2 Constructor (Stream)

Initializes a new instance of the [CacheRequest2](cacherequest2-class-microsoft-web-media-smoothstreaming.md) class based on the specified stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    stream As Stream _
)
'Usage

Dim stream As Stream

Dim instance As New CacheRequest2(stream)
```

```csharp
public CacheRequest2(
    Stream stream
)
```

```cpp
public:
CacheRequest2(
    Stream^ stream
)
```

``` fsharp
new : 
        stream:Stream -> CacheRequest2
```

```jscript
public function CacheRequest2(
    stream : Stream
)
```

### Parameters

  - stream  
    Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\))  
    The stream from which to read.

## Remarks

The CacheRequst2 instance reads from a stream that has been written using the [WriteTo(Stream)](cacherequest-writeto-method-microsoft-web-media-smoothstreaming_1.md) method. Because serialization uses big-endian byte order for wire format, deserialization can take place on a different platform.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[CacheRequest2 Class](cacherequest2-class-microsoft-web-media-smoothstreaming.md)

[CacheRequest2 Overload](cacherequest2-constructor-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

