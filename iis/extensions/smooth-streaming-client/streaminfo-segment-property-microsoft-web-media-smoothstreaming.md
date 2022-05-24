---
title: StreamInfo.Segment Property (Microsoft.Web.Media.SmoothStreaming)
description: Describes the Segment property and provides the property's namespace, assembly, syntax, property value, remarks, and version information.
TOCTitle: Segment Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.Segment
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.segment(v=VS.90)
ms:contentKeyID: 31469208
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Segment
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Segment
dev_langs:
- csharp
- jscript
- vb
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

# Segment Property

Gets or sets the segment for this stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property Segment As SegmentInfo
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

```jscript
  function get Segment () : SegmentInfo
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) object.  

## Remarks

For more information and an example that parses [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) objects, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md) under the heading "Extract Timeline Events and Assign Markers."

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
