---
title: CacheResponse.Response Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Response Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.Response
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse.response(v=VS.90)
ms:contentKeyID: 31469265
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_Response
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.Response
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_Response
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_Response
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_Response
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.Response
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Response Property

A [Stream](https://msdn.microsoft.com/library/8f86tw9e) object that contains the response.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Response As Stream
'Usage

  Dim instance As CacheResponse
Dim value As Stream

value = instance.Response
```

```csharp
  public Stream Response { get; private set; }
```

```cpp
  public:
property Stream^ Response {
    Stream^ get ();
    private: void set (Stream^ value);
}
```

```jscript
  function get Response () : Stream
private function set Response (value : Stream)
```

### Property Value

Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e)  
A [Stream](https://msdn.microsoft.com/library/8f86tw9e) object that contains the response.  

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

