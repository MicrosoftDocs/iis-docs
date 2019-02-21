---
title: CacheRequest2.WebRequest Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: WebRequest Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheRequest2.WebRequest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacherequest2.webrequest(v=VS.95)
ms:contentKeyID: 46307735
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.WebRequest
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.set_WebRequest
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.get_WebRequest
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.get_WebRequest
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.set_WebRequest
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.WebRequest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CacheRequest2.WebRequest Property

Gets or sets a web request that the media element downloader uses for downloading.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property WebRequest As HttpWebRequest
    Get
    Set
'Usage

Dim instance As CacheRequest2
Dim value As HttpWebRequest

value = instance.WebRequest

instance.WebRequest = value
```

```csharp
public HttpWebRequest WebRequest { get; set; }
```

```cpp
public:
property HttpWebRequest^ WebRequest {
    HttpWebRequest^ get ();
    void set (HttpWebRequest^ value);
}
```

``` fsharp
member WebRequest : HttpWebRequest with get, set
```

```jscript
function get WebRequest () : HttpWebRequest
function set WebRequest (value : HttpWebRequest)
```

### Property Value

Type: [System.Net.HttpWebRequest](https://msdn.microsoft.com/library/8y7x3zz2\(v=vs.95\))  
An HttpWebRequest object that represents the web request.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[CacheRequest2 Class](cacherequest2-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

