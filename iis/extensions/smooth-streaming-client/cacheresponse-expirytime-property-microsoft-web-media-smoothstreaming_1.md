---
title: CacheResponse.ExpiryTime Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ExpiryTime Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.ExpiryTime
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse.expirytime(v=VS.95)
ms:contentKeyID: 46307744
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ExpiryTime
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ExpiryTime
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ExpiryTime
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ExpiryTime
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheResponse.ExpiryTime Property

A [DateTime](https://msdn.microsoft.com/library/03ybds8y\(v=vs.95\)) object that contains the time of response expiration.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property ExpiryTime As DateTime
    Get
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

``` fsharp
member ExpiryTime : DateTime
```

```jscript
function get ExpiryTime () : DateTime
```

### Property Value

Type: [System.DateTime](https://msdn.microsoft.com/library/03ybds8y\(v=vs.95\))  
A [DateTime](https://msdn.microsoft.com/library/03ybds8y\(v=vs.95\)) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

