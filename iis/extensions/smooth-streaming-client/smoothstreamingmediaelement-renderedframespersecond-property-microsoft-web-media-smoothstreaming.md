---
title: RenderedFramesPerSecond Property (Microsoft.Web.Media.SmoothStreaming)
description: The RenderedFramesPerSecond property gets the rate of rendered frames.
TOCTitle: RenderedFramesPerSecond Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.RenderedFramesPerSecond
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.renderedframespersecond(v=VS.90)
ms:contentKeyID: 23961261
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.RenderedFramesPerSecond
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_RenderedFramesPerSecond
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_RenderedFramesPerSecond
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.RenderedFramesPerSecond
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# RenderedFramesPerSecond Property

Gets the rate of rendered frames.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property RenderedFramesPerSecond As Double
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Double

value = instance.RenderedFramesPerSecond
```

```csharp
  public double RenderedFramesPerSecond { get; }
```

```cpp
  public:
property double RenderedFramesPerSecond {
    double get ();
}
```

```jscript
  function get RenderedFramesPerSecond () : double
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t)  
The rate of rendered frames.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
