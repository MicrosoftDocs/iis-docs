---
title: SegmentInfo.EndPosition Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: EndPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SegmentInfo.EndPosition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.segmentinfo.endposition(v=VS.95)
ms:contentKeyID: 46307796
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.EndPosition
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.get_EndPosition
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.EndPosition
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.get_EndPosition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SegmentInfo.EndPosition Property

Gets the minimum of the end time for the last audio chunk and last video chunk.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property EndPosition As TimeSpan
    Get
'Usage

Dim instance As SegmentInfo
Dim value As TimeSpan

value = instance.EndPosition
```

```csharp
public TimeSpan EndPosition { get; }
```

```cpp
public:
property TimeSpan EndPosition {
    TimeSpan get ();
}
```

``` fsharp
member EndPosition : TimeSpan
```

```jscript
function get EndPosition () : TimeSpan
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
A [TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\)) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SegmentInfo Class](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

