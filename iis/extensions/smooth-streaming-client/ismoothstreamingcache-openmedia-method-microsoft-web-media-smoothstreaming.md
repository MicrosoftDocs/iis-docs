---
title: ISmoothStreamingCache.OpenMedia Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: OpenMedia Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.OpenMedia(System.Uri)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ismoothstreamingcache.openmedia(v=VS.95)
ms:contentKeyID: 46307670
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.OpenMedia
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.OpenMedia
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ISmoothStreamingCache.OpenMedia Method

Opens the specified media for [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) operations.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Sub OpenMedia ( _
    manifestUri As Uri _
)
'Usage

Dim instance As ISmoothStreamingCache
Dim manifestUri As Uri

instance.OpenMedia(manifestUri)
```

```csharp
void OpenMedia(
    Uri manifestUri
)
```

```cpp
void OpenMedia(
    Uri^ manifestUri
)
```

``` fsharp
abstract OpenMedia :
        manifestUri:Uri -> unit
```

```jscript
function OpenMedia(
    manifestUri : Uri
)
```

### Parameters

  - manifestUri  
    Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))  
    The Uri of the media manifest.

## Remarks

The OpenMedia method is called before any other interface call. The cache plug-in can take advantage of this behavior to handle initialization, although a static cache such as a disk cache does not normally require any initialization.

Multiple OpenMedia calls can be made with the same Uri. Each OpenMedia call is reference counted and should be paired with a [CloseMedia(Uri)](ismoothstreamingcache-closemedia-method-microsoft-web-media-smoothstreaming.md) call.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ISmoothStreamingCache Interface](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
