---
title: ChunkDownloadedEventArgs.StatusCode Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StatusCode Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.StatusCode
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkdownloadedeventargs.statuscode(v=VS.95)
ms:contentKeyID: 46307757
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_StatusCode
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_StatusCode
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.StatusCode
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_StatusCode
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_StatusCode
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.StatusCode
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChunkDownloadedEventArgs.StatusCode Property

Gets the HTTP status code.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property StatusCode As HttpStatusCode
    Get
    Private Set
'Usage

Dim instance As ChunkDownloadedEventArgs
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

``` fsharp
member StatusCode : HttpStatusCode with get, private set
```

```jscript
function get StatusCode () : HttpStatusCode
private function set StatusCode (value : HttpStatusCode)
```

### Property Value

Type: [System.Net.HttpStatusCode](https://msdn.microsoft.com/library/f92ssyy1\(v=vs.95\))  
An HttpStatusCode object that represents the status code.

## Remarks

Status 404 can be overridden as status 412 for a browser.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ChunkDownloadedEventArgs Class](chunkdownloadedeventargs-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

