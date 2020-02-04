---
title: CacheResponse.ReadFrom Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ReadFrom Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.CacheResponse.ReadFrom(System.IO.Stream)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse.readfrom(v=VS.95)
ms:contentKeyID: 46307655
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ReadFrom
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ReadFrom
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheResponse.ReadFrom Method

Reads the response from a [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object. There is no default implementation for this method. Calling the method without implementing an override will result in a [NotSupportedException](https://msdn.microsoft.com/library/8a7a4e64\(v=vs.95\)).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Overridable Sub ReadFrom ( _
    stream As Stream _
)
'Usage

Dim instance As CacheResponse
Dim stream As Stream

instance.ReadFrom(stream)
```

```csharp
public virtual void ReadFrom(
    Stream stream
)
```

```cpp
public:
virtual void ReadFrom(
    Stream^ stream
)
```

``` fsharp
abstract ReadFrom : 
        stream:Stream -> unit 
override ReadFrom : 
        stream:Stream -> unit 
```

```jscript
public function ReadFrom(
    stream : Stream
)
```

### Parameters

  - stream  
    Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\))  
    The [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

