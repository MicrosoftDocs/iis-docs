---
title: CacheResponse.ContentType Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ContentType Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContentType
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse.contenttype(v=VS.95)
ms:contentKeyID: 46307734
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContentType
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ContentType
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_ContentType
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContentType
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_ContentType
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ContentType
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheResponse.ContentType Property

A string object that identifies the content type.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ContentType As String
    Get
    Set
'Usage

Dim instance As CacheResponse
Dim value As String

value = instance.ContentType

instance.ContentType = value
```

```csharp
public string ContentType { get; set; }
```

```cpp
public:
property String^ ContentType {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
member ContentType : string with get, set
```

```jscript
function get ContentType () : String
function set ContentType (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
A string object that identifies the content type.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
