---
title: CacheResponse.Headers Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Headers Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.Headers
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse.headers(v=VS.95)
ms:contentKeyID: 46307740
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_Headers
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.Headers
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_Headers
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_Headers
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_Headers
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.Headers
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CacheResponse.Headers Property

Gets a metadata collection of responses.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Headers As WebHeaderCollection
    Get
    Set
'Usage

Dim instance As CacheResponse
Dim value As WebHeaderCollection

value = instance.Headers

instance.Headers = value
```

```csharp
public WebHeaderCollection Headers { get; set; }
```

```cpp
public:
property WebHeaderCollection^ Headers {
    WebHeaderCollection^ get ();
    void set (WebHeaderCollection^ value);
}
```

``` fsharp
member Headers : WebHeaderCollection with get, set
```

```jscript
function get Headers () : WebHeaderCollection
function set Headers (value : WebHeaderCollection)
```

### Property Value

Type: [System.Net.WebHeaderCollection](https://msdn.microsoft.com/library/1beth6ct\(v=vs.95\))  
A System.NetWebHeaderCollection object that contains the responses.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

