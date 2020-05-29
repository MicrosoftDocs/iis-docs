---
title: SmoothStreamingMediaElement.ClipPosition Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipPosition
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.clipposition(v=VS.95)
ms:contentKeyID: 46307820
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_ClipPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_ClipPosition
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_ClipPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_ClipPosition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.ClipPosition Property

Gets or sets the position in a clip stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ClipPosition As TimeSpan
    Get
    Private Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As TimeSpan

value = instance.ClipPosition
```

```csharp
public TimeSpan ClipPosition { get; private set; }
```

```cpp
public:
property TimeSpan ClipPosition {
    TimeSpan get ();
    private: void set (TimeSpan value);
}
```

``` fsharp
member ClipPosition : TimeSpan with get, private set
```

```jscript
function get ClipPosition () : TimeSpan
private function set ClipPosition (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
The position in a clip stream.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
