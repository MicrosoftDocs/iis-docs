---
title: StreamInfo.Segment Property (Microsoft.Web.Media.SmoothStreaming)
description: Describes the StreamInfo.Segment property and provides the property's syntax, remarks, and version information.
TOCTitle: Segment Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.Segment
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.segment(v=VS.95)
ms:contentKeyID: 46307873
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Segment
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Segment
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Segment
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Segment
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StreamInfo.Segment Property

Gets or sets the segment for this stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property Segment As SegmentInfo
    Get
'Usage

Dim instance As StreamInfo
Dim value As SegmentInfo

value = instance.Segment
```

```csharp
public SegmentInfo Segment { get; }
```

```cpp
public:
property SegmentInfo^ Segment {
    SegmentInfo^ get ();
}
```

``` fsharp
member Segment : SegmentInfo
```

```jscript
function get Segment () : SegmentInfo
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) object.

## Remarks

For more information and an example that parses [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) objects, see [Timeline Markers and Events](timeline-markers-and-events.md) under the heading "Extract Timeline Events and Assign Markers."

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
