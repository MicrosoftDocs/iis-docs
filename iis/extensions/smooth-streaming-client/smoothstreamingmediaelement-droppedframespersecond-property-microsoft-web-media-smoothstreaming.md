---
title: SmoothStreamingMediaElement.DroppedFramesPerSecond Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: DroppedFramesPerSecond Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DroppedFramesPerSecond
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.droppedframespersecond(v=VS.90)
ms:contentKeyID: 23961083
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DroppedFramesPerSecond
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_DroppedFramesPerSecond
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DroppedFramesPerSecond
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_DroppedFramesPerSecond
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DroppedFramesPerSecond Property

Gets or sets the percentage of dropped frames per second.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property DroppedFramesPerSecond As Double
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

```jscript
  function get DroppedFramesPerSecond () : double
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t)  
A value that indicates the percentage of dropped frames per second.  

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
