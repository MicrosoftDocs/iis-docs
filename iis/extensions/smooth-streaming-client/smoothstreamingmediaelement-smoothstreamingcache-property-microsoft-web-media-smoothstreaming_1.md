---
title: SmoothStreamingMediaElement.SmoothStreamingCache Property (Microsoft.Web.Media.SmoothStreaming)
description: This article contains syntax and version information for the SmoothStreamingMediaElement.SmoothStreamingCache property.
TOCTitle: SmoothStreamingCache Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingCache
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.smoothstreamingcache(v=VS.95)
ms:contentKeyID: 46307843
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingCache
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SmoothStreamingCache
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.SmoothStreamingCache Property

Gets or sets the Smooth Streaming cache to use during main content playback.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property SmoothStreamingCache As ISmoothStreamingCache
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As ISmoothStreamingCache

value = instance.SmoothStreamingCache

instance.SmoothStreamingCache = value
```

```csharp
public ISmoothStreamingCache SmoothStreamingCache { get; set; }
```

```cpp
public:
property ISmoothStreamingCache^ SmoothStreamingCache {
    ISmoothStreamingCache^ get ();
    void set (ISmoothStreamingCache^ value);
}
```

``` fsharp
member SmoothStreamingCache : ISmoothStreamingCache with get, set
```

```jscript
function get SmoothStreamingCache () : ISmoothStreamingCache
function set SmoothStreamingCache (value : ISmoothStreamingCache)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)  
An object that implements the cache interface.

## Remarks

To associate a cache with advertisements, the cache should be assigned to this property. For more information, see [Cache Plug-in Implementation of ISmoothStreamingCache](cache-plug-in-implementation-of-ismoothstreamingcache_1.md)

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
