---
title: CacheRequest2 Constructor (HttpWebRequest, IList(TrackInfo)) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheRequest2 Constructor (HttpWebRequest, IList(TrackInfo))
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.CacheRequest2.#ctor(System.Net.HttpWebRequest,System.Collections.Generic.IList{Microsoft.Web.Media.SmoothStreaming.TrackInfo})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacherequest2.cacherequest2(v=VS.95)
ms:contentKeyID: 46307656
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- "cpp"
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CacheRequest2 Constructor (HttpWebRequest, IList\<TrackInfo\>)

Initializes a new instance of the [CacheRequest2](cacherequest2-class-microsoft-web-media-smoothstreaming.md) class based on the specified web request and list of selectable tracks.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    request As HttpWebRequest, _
    tracks As IList(Of TrackInfo) _
)
'Usage

Dim request As HttpWebRequest
Dim tracks As IList(Of TrackInfo)

Dim instance As New CacheRequest2(request, _
    tracks)
```

```csharp
public CacheRequest2(
    HttpWebRequest request,
    IList<TrackInfo> tracks
)
```

```cpp
public:
CacheRequest2(
    HttpWebRequest^ request, 
    IList<TrackInfo^>^ tracks
)
```

``` fsharp
new : 
        request:HttpWebRequest * 
        tracks:IList<TrackInfo> -> CacheRequest2
```

```jscript
public function CacheRequest2(
    request : HttpWebRequest, 
    tracks : IList<TrackInfo>
)
```

### Parameters

  - request  
    Type: [System.Net.HttpWebRequest](https://msdn.microsoft.com/library/8y7x3zz2\(v=vs.95\))  
    A [HttpWebRequest](https://msdn.microsoft.com/library/8y7x3zz2\(v=vs.95\)) object that represents the web request.

<!-- end list -->

  - tracks  
    Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)\>  
    The list of selectable tracks that the cache plug-in can use for downloading.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[CacheRequest2 Class](cacherequest2-class-microsoft-web-media-smoothstreaming.md)

[CacheRequest2 Overload](cacherequest2-constructor-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

