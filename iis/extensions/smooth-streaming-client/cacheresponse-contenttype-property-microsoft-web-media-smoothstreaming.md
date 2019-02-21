---
title: CacheResponse.ContentType Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ContentType Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContentType
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse.contenttype(v=VS.90)
ms:contentKeyID: 31469154
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContentType
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ContentType
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_ContentType
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContentType
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_ContentType
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ContentType
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ContentType Property

A string object that identifies the content type

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property ContentType As String
'Usage

  Dim instance As CacheResponse
Dim value As String

value = instance.ContentType
```

```csharp
  public string ContentType { get; private set; }
```

```cpp
  public:
property String^ ContentType {
    String^ get ();
    private: void set (String^ value);
}
```

```jscript
  function get ContentType () : String
private function set ContentType (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A string object that identifies the content type  

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

