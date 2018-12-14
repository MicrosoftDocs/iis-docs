---
title: SegmentInfo.EndPosition Property  (Microsoft.Web.Media.SmoothStreaming)
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
- CSharp
- JScript
- VB
- c++
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

# EndPosition Property

Gets the minimum of the end time for the last audio chunk and last video chunk.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyEndPositionAsTimeSpan
'Usage
DiminstanceAsSegmentInfoDimvalueAsTimeSpanvalue = instance.EndPosition
```

``` csharp
publicTimeSpanEndPosition { get; }
```

``` c++
public:
propertyTimeSpanEndPosition {
    TimeSpanget ();
}
```

``` jscript
function getEndPosition () : TimeSpan
```

#### Property Value

Type: [System. . :: . .TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\))  
A [TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\)) object.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SegmentInfo Class](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

