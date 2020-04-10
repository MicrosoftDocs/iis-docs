---
title: CacheResponse.Response Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Response Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.Response
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse.response(v=VS.95)
ms:contentKeyID: 46307745
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_Response
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.Response
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_Response
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_Response
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_Response
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.Response
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheResponse.Response Property

A [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object that contains the response.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Response As Stream
    Get
    Set
'Usage

Dim instance As CacheResponse
Dim value As Stream

value = instance.Response

instance.Response = value
```

```csharp
public Stream Response { get; set; }
```

```cpp
public:
property Stream^ Response {
    Stream^ get ();
    void set (Stream^ value);
}
```

``` fsharp
member Response : Stream with get, set
```

```jscript
function get Response () : Stream
function set Response (value : Stream)
```

### Property Value

Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\))  
A [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object that contains the response.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
