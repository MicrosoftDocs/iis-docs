---
title: CacheResponse.ExpiryTime Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ExpiryTime Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.ExpiryTime
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse.expirytime(v=VS.90)
ms:contentKeyID: 31469264
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ExpiryTime
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ExpiryTime
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ExpiryTime
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ExpiryTime
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ExpiryTime Property

A [DateTime](https://msdn.microsoft.com/library/03ybds8y) object that contains the time of response expiration.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property ExpiryTime As DateTime
'Usage

  Dim instance As CacheResponse
Dim value As DateTime

value = instance.ExpiryTime
```

```csharp
  public DateTime ExpiryTime { get; }
```

```cpp
  public:
property DateTime ExpiryTime {
    DateTime get ();
}
```

```jscript
  function get ExpiryTime () : DateTime
```

### Property Value

Type: [System.DateTime](https://msdn.microsoft.com/library/03ybds8y)  
A [DateTime](https://msdn.microsoft.com/library/03ybds8y) object.  

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

