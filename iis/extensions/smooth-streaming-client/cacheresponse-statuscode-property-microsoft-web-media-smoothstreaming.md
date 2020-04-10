---
title: CacheResponse.StatusCode Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StatusCode Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusCode
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse.statuscode(v=VS.90)
ms:contentKeyID: 31469201
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusCode
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusCode
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StatusCode Property

An HTTPStatusCode enumeration object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property StatusCode As HttpStatusCode
'Usage

  Dim instance As CacheResponse
Dim value As HttpStatusCode

value = instance.StatusCode
```

```csharp
  public HttpStatusCode StatusCode { get; private set; }
```

```cpp
  public:
property HttpStatusCode StatusCode {
    HttpStatusCode get ();
    private: void set (HttpStatusCode value);
}
```

```jscript
  function get StatusCode () : HttpStatusCode
private function set StatusCode (value : HttpStatusCode)
```

### Property Value

Type: [System.Net.HttpStatusCode](https://msdn.microsoft.com/library/f92ssyy1)  
An HTTPStatusCode enumeration object.  

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
