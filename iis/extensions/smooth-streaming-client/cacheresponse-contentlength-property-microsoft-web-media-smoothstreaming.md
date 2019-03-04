---
title: CacheResponse.ContentLength Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ContentLength Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContentLength
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse.contentlength(v=VS.90)
ms:contentKeyID: 31469259
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContentLength
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ContentLength
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_ContentLength
dev_langs:
- csharp
- jscript
- vb
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
ROBOTS: INDEX,FOLLOW
---

# ContentLength Property

The length in bytes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property ContentLength As Long
'Usage

  Dim instance As CacheResponse
Dim value As Long

value = instance.ContentLength
```

```csharp
  public long ContentLength { get; private set; }
```

```cpp
  public:
property long long ContentLength {
    long long get ();
    private: void set (long long value);
}
```

```jscript
  function get ContentLength () : long
private function set ContentLength (value : long)
```

### Property Value

Type: [System.Int64](https://msdn.microsoft.com/library/6yy583ek)  
A long integer that contains the length in bytes.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

