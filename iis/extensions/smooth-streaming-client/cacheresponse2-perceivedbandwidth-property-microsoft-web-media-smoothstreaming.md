---
title: CacheResponse2.PerceivedBandwidth Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PerceivedBandwidth Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse2.PerceivedBandwidth
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse2.perceivedbandwidth(v=VS.95)
ms:contentKeyID: 46307746
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.set_PerceivedBandwidth
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.PerceivedBandwidth
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.get_PerceivedBandwidth
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.get_PerceivedBandwidth
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.PerceivedBandwidth
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.set_PerceivedBandwidth
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CacheResponse2.PerceivedBandwidth Property

Gets or sets the perceived bandwidth while downloading individual media chunks.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property PerceivedBandwidth As Double
    Get
    Set
'Usage

Dim instance As CacheResponse2
Dim value As Double

value = instance.PerceivedBandwidth

instance.PerceivedBandwidth = value
```

```csharp
public double PerceivedBandwidth { get; set; }
```

```cpp
public:
property double PerceivedBandwidth {
    double get ();
    void set (double value);
}
```

``` fsharp
member PerceivedBandwidth : float with get, set
```

```jscript
function get PerceivedBandwidth () : double
function set PerceivedBandwidth (value : double)
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t\(v=vs.95\))  
The bandwidth in bytes per second.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[CacheResponse2 Class](cacheresponse2-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

