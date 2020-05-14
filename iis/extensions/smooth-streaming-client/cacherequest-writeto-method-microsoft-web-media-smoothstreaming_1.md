---
title: CacheRequest.WriteTo Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: WriteTo Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.CacheRequest.WriteTo(System.IO.Stream)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacherequest.writeto(v=VS.95)
ms:contentKeyID: 46307654
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest.WriteTo
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest.WriteTo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheRequest.WriteTo Method

Writes the request to a [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Overridable Sub WriteTo ( _
    stream As Stream _
)
'Usage

Dim instance As CacheRequest
Dim stream As Stream

instance.WriteTo(stream)
```

```csharp
public virtual void WriteTo(
    Stream stream
)
```

```cpp
public:
virtual void WriteTo(
    Stream^ stream
)
```

``` fsharp
abstract WriteTo :
        stream:Stream -> unit
override WriteTo :
        stream:Stream -> unit
```

```jscript
public function WriteTo(
    stream : Stream
)
```

### Parameters

  - stream  
    Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\))  
    A [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[CacheRequest Class](cacherequest-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
