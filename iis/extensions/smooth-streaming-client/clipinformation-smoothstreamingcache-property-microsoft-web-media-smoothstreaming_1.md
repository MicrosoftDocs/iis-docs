---
title: ClipInformation.SmoothStreamingCache Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingCache Property
description: ClipInformation.SmoothStreamingCache Property gets or sets the Smooth Streaming cache.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.SmoothStreamingCache
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipinformation.smoothstreamingcache(v=VS.95)
ms:contentKeyID: 46307769
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_SmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_SmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.SmoothStreamingCache
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_SmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.SmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_SmoothStreamingCache
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipInformation.SmoothStreamingCache Property

Gets or sets the Smooth Streaming cache.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property SmoothStreamingCache As ISmoothStreamingCache
    Get
    Private Set
'Usage

Dim instance As ClipInformation
Dim value As ISmoothStreamingCache

value = instance.SmoothStreamingCache
```

```csharp
public ISmoothStreamingCache SmoothStreamingCache { get; private set; }
```

```cpp
public:
property ISmoothStreamingCache^ SmoothStreamingCache {
    ISmoothStreamingCache^ get ();
    private: void set (ISmoothStreamingCache^ value);
}
```

``` fsharp
member SmoothStreamingCache : ISmoothStreamingCache with get, private set
```

```jscript
function get SmoothStreamingCache () : ISmoothStreamingCache
private function set SmoothStreamingCache (value : ISmoothStreamingCache)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)  
An [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) object.

## Remarks

Allows the caller to specify a separate cache to use when playing this clip. This can enable offline ad scenarios. Note that setting this property implicitly sets [UseSmoothStreamingCache](clipinformation-usesmoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md) to true.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
