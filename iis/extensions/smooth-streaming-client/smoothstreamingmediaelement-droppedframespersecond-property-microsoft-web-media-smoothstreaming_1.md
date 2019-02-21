---
title: SmoothStreamingMediaElement.DroppedFramesPerSecond Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: DroppedFramesPerSecond Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DroppedFramesPerSecond
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.droppedframespersecond(v=VS.95)
ms:contentKeyID: 46307824
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DroppedFramesPerSecond
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_DroppedFramesPerSecond
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DroppedFramesPerSecond
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_DroppedFramesPerSecond
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.DroppedFramesPerSecond Property

Gets or sets the percentage of dropped frames per second.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property DroppedFramesPerSecond As Double
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Double

value = instance.DroppedFramesPerSecond
```

```csharp
public double DroppedFramesPerSecond { get; }
```

```cpp
public:
property double DroppedFramesPerSecond {
    double get ();
}
```

``` fsharp
member DroppedFramesPerSecond : float
```

```jscript
function get DroppedFramesPerSecond () : double
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t\(v=vs.95\))  
A value that indicates the percentage of dropped frames per second.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

