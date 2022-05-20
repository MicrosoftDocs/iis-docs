---
title: SmoothStreamingMediaElement.MarkerReached Event (Microsoft.Web.Media.SmoothStreaming)
description: This article contains syntax and version information for the SmoothStreamingMediaElement.MarkerReached event.
TOCTitle: MarkerReached Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MarkerReached
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.markerreached(v=VS.95)
ms:contentKeyID: 46307499
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MarkerReached
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_MarkerReached
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MarkerReached
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_MarkerReached
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.MarkerReached Event

Occurs when media playback reaches a timeline marker.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event MarkerReached As TimelineMarkerRoutedEventHandler
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As TimelineMarkerRoutedEventHandler

AddHandler instance.MarkerReached, handler
```

```csharp
public event TimelineMarkerRoutedEventHandler MarkerReached
```

```cpp
public:
 event TimelineMarkerRoutedEventHandler^ MarkerReached {
    void add (TimelineMarkerRoutedEventHandler^ value);
    void remove (TimelineMarkerRoutedEventHandler^ value);
}
```

``` fsharp
member MarkerReached : <TimelineMarkerRoutedEventHandler,
    TimelineMarkerRoutedEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

For more information, see [Timeline Markers and Events](timeline-markers-and-events.md).

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
