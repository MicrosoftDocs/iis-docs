---
title: CacheResponse.Headers Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Headers Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.Headers
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse.headers(v=VS.90)
ms:contentKeyID: 31469175
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_Headers
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.Headers
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_Headers
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_Headers
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_Headers
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.Headers
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Headers Property

Metadata collection of response.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Headers As WebHeaderCollection
'Usage

  Dim instance As CacheResponse
Dim value As WebHeaderCollection

value = instance.Headers
```

```csharp
  public WebHeaderCollection Headers { get; private set; }
```

```cpp
  public:
property WebHeaderCollection^ Headers {
    WebHeaderCollection^ get ();
    private: void set (WebHeaderCollection^ value);
}
```

```jscript
  function get Headers () : WebHeaderCollection
private function set Headers (value : WebHeaderCollection)
```

### Property Value

Type: [System.Net.WebHeaderCollection](https://msdn.microsoft.com/library/1beth6ct)  
A NetWebHeaderCollection.  

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
