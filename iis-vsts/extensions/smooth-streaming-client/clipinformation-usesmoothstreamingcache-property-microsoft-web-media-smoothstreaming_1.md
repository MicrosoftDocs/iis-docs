---
title: ClipInformation.UseSmoothStreamingCache Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: UseSmoothStreamingCache Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.UseSmoothStreamingCache
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipinformation.usesmoothstreamingcache(v=VS.95)
ms:contentKeyID: 46307785
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_UseSmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_UseSmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.UseSmoothStreamingCache
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_UseSmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_UseSmoothStreamingCache
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.UseSmoothStreamingCache
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipInformation.UseSmoothStreamingCache Property

Gets or sets a Boolean value that indicates whether to use the Smooth Streaming cache.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property UseSmoothStreamingCache As Boolean
    Get
    Private Set
'Usage

Dim instance As ClipInformation
Dim value As Boolean

value = instance.UseSmoothStreamingCache
```

```csharp
public bool UseSmoothStreamingCache { get; private set; }
```

```cpp
public:
property bool UseSmoothStreamingCache {
    bool get ();
    private: void set (bool value);
}
```

``` fsharp
member UseSmoothStreamingCache : bool with get, private set
```

```jscript
function get UseSmoothStreamingCache () : boolean
private function set UseSmoothStreamingCache (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
A Boolean value, true if Smooth Streaming cache is to be used, otherwise false.

## Remarks

If this property is false (default), ignore [SmoothStreamingCache](clipinformation-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md) and inherit the [SmoothStreamingCache](smoothstreamingmediaelement-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md) from the main [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md). If this property is true, use [SmoothStreamingCache](clipinformation-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md). This property can be set to true in two ways:

1.  Implicitly. It is set to true when [SmoothStreamingCache](clipinformation-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md) is set, or

2.  Explicitly. It can be explicitly set to false at any time.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

