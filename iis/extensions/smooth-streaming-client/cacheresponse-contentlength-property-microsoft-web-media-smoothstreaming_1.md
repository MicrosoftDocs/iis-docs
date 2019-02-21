---
title: CacheResponse.ContentLength Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ContentLength Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContentLength
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse.contentlength(v=VS.95)
ms:contentKeyID: 46307742
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContentLength
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ContentLength
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_ContentLength
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContentLength
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ContentLength
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_ContentLength
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CacheResponse.ContentLength Property

The length in bytes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ContentLength As Long
    Get
    Set
'Usage

Dim instance As CacheResponse
Dim value As Long

value = instance.ContentLength

instance.ContentLength = value
```

```csharp
public long ContentLength { get; set; }
```

```cpp
public:
property long long ContentLength {
    long long get ();
    void set (long long value);
}
```

``` fsharp
member ContentLength : int64 with get, set
```

```jscript
function get ContentLength () : long
function set ContentLength (value : long)
```

### Property Value

Type: [System.Int64](https://msdn.microsoft.com/library/6yy583ek\(v=vs.95\))  
A long integer that contains the length in bytes.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

