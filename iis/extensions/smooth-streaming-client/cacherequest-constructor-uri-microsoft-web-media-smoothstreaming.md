---
title: CacheRequest Constructor (Uri) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheRequest Constructor (Uri)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.CacheRequest.#ctor(System.Uri)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacherequest.cacherequest(v=VS.90)
ms:contentKeyID: 31469313
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheRequest Constructor (Uri)

Initializes a new instance of the [CacheRequest](cacherequest-class-microsoft-web-media-smoothstreaming_1.md) class from a [Uri](https://msdn.microsoft.com/library/txt7706a) object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    canonicalUri As Uri _
)
'Usage

  Dim canonicalUri As Uri

Dim instance As New CacheRequest(canonicalUri)
```

```csharp
  public CacheRequest(
    Uri canonicalUri
)
```

```cpp
  public:
CacheRequest(
    Uri^ canonicalUri
)
```

```jscript
  public function CacheRequest(
    canonicalUri : Uri
)
```

### Parameters

  - canonicalUri  
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

[CacheRequest Overload](cacherequest-constructor-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

