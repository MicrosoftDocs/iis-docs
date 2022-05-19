---
title: ISmoothStreamingCache.CloseMedia Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CloseMedia Method
description: Ends ISmoothStreamingCache operations for the specified media.
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.CloseMedia(System.Uri)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ismoothstreamingcache.closemedia(v=VS.95)
ms:contentKeyID: 46307662
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.CloseMedia
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.CloseMedia
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ISmoothStreamingCache.CloseMedia Method

Ends [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) operations for the specified media.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Sub CloseMedia ( _
    manifestUri As Uri _
)
'Usage

Dim instance As ISmoothStreamingCache
Dim manifestUri As Uri

instance.CloseMedia(manifestUri)
```

```csharp
void CloseMedia(
    Uri manifestUri
)
```

```cpp
void CloseMedia(
    Uri^ manifestUri
)
```

``` fsharp
abstract CloseMedia : 
        manifestUri:Uri -> unit 
```

```jscript
function CloseMedia(
    manifestUri : Uri
)
```

### Parameters

  - manifestUri  
    Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))  
    The Uri of the media manifest.

## Remarks

The CloseMedia method is called when the cache is no longer needed. Each [OpenMedia(Uri)](ismoothstreamingcache-openmedia-method-microsoft-web-media-smoothstreaming.md) call is reference counted and should be paired with a CloseMedia.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ISmoothStreamingCache Interface](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
