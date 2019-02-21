---
title: SegmentInfo.EndPosition Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: EndPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SegmentInfo.EndPosition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.segmentinfo.endposition(v=VS.90)
ms:contentKeyID: 31469145
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.EndPosition
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.get_EndPosition
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
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
---

# EndPosition Property

Gets the minimum of the end time for the last audio chunk and last video chunk.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property EndPosition As TimeSpan
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

```jscript
  function get EndPosition () : TimeSpan
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

