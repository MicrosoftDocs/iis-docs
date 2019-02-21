---
title: SmoothStreamingMediaElement.Markers Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Markers Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Markers
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.markers(v=VS.95)
ms:contentKeyID: 46307836
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Markers
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Markers
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Markers
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Markers
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.Markers Property

Gets the markers collection.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property Markers As TimelineMarkerCollection
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As TimelineMarkerCollection

value = instance.Markers
```

```csharp
public TimelineMarkerCollection Markers { get; }
```

```cpp
public:
property TimelineMarkerCollection^ Markers {
    TimelineMarkerCollection^ get ();
}
```

``` fsharp
member Markers : TimelineMarkerCollection
```

```jscript
function get Markers () : TimelineMarkerCollection
```

### Property Value

Type: [System.Windows.Media.TimelineMarkerCollection](https://msdn.microsoft.com/library/cc190313\(v=vs.95\))  
A collection of timeline markers.

## Remarks

For more information, see [Timeline Markers and Events](timeline-markers-and-events.md).

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

