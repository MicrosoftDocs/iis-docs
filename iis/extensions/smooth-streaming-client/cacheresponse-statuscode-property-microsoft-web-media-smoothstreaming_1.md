---
title: CacheResponse.StatusCode Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StatusCode Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusCode
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse.statuscode(v=VS.95)
ms:contentKeyID: 46307747
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusCode
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusCode
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CacheResponse.StatusCode Property

An [System.Net.HTTPStatusCode](https://msdn.microsoft.com/library/f92ssyy1\(v=vs.95\)) enumeration object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property StatusCode As HttpStatusCode
    Get
    Set
'Usage

Dim instance As CacheResponse
Dim value As HttpStatusCode

value = instance.StatusCode

instance.StatusCode = value
```

```csharp
public HttpStatusCode StatusCode { get; set; }
```

```cpp
public:
property HttpStatusCode StatusCode {
    HttpStatusCode get ();
    void set (HttpStatusCode value);
}
```

``` fsharp
member StatusCode : HttpStatusCode with get, set
```

```jscript
function get StatusCode () : HttpStatusCode
function set StatusCode (value : HttpStatusCode)
```

### Property Value

Type: [System.Net.HttpStatusCode](https://msdn.microsoft.com/library/f92ssyy1\(v=vs.95\))  
An [System.Net.HTTPStatusCode](https://msdn.microsoft.com/library/f92ssyy1\(v=vs.95\)) enumeration object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

