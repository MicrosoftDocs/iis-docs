---
title: CacheRequest.CanonicalUri Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CanonicalUri Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheRequest.CanonicalUri
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacherequest.canonicaluri(v=VS.90)
ms:contentKeyID: 31469150
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest.CanonicalUri
- Microsoft.Web.Media.SmoothStreaming.CacheRequest.get_CanonicalUri
- Microsoft.Web.Media.SmoothStreaming.CacheRequest.set_CanonicalUri
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest.CanonicalUri
- Microsoft.Web.Media.SmoothStreaming.CacheRequest.set_CanonicalUri
- Microsoft.Web.Media.SmoothStreaming.CacheRequest.get_CanonicalUri
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CanonicalUri Property

The Uri of the request.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property CanonicalUri As Uri
'Usage

  Dim instance As CacheRequest
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

```jscript
  function get CanonicalUri () : Uri
private function set CanonicalUri (value : Uri)
```

### Property Value

Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a)  
A [Uri](https://msdn.microsoft.com/library/txt7706a) object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[CacheRequest Class](cacherequest-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

