---
title: SegmentInfo.StartPosition Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StartPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SegmentInfo.StartPosition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.segmentinfo.startposition(v=VS.90)
ms:contentKeyID: 31469318
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.get_StartPosition
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.StartPosition
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.get_StartPosition
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.StartPosition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StartPosition Property

Gets the maximum of the start times of the first audio chunk and first video chunk.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property StartPosition As TimeSpan
'Usage

  Dim instance As SegmentInfo
Dim value As TimeSpan

value = instance.StartPosition
```

```csharp
  public TimeSpan StartPosition { get; }
```

```cpp
  public:
property TimeSpan StartPosition {
    TimeSpan get ();
}
```

```jscript
  function get StartPosition () : TimeSpan
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577)  
A [TimeSpan](https://msdn.microsoft.com/library/269ew577) object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SegmentInfo Class](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

