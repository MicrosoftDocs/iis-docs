---
title: SmoothStreamingMediaElement.CurrentSegmentIndex Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CurrentSegmentIndex Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentSegmentIndex
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.currentsegmentindex(v=VS.90)
ms:contentKeyID: 31469206
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentSegmentIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CurrentSegmentIndex
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentSegmentIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CurrentSegmentIndex
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CurrentSegmentIndex Property

Gets the index of the current playing segment.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyCurrentSegmentIndexAsNullable(OfInteger)
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsNullable(OfInteger)

value = instance.CurrentSegmentIndex
```

``` csharp
publicNullable<int> CurrentSegmentIndex { get; }
```

``` c++
public:
propertyNullable<int> CurrentSegmentIndex {
    Nullable<int> get ();
}
```

``` jscript
function getCurrentSegmentIndex () : Nullable<int>
```

#### Property Value

Type: [System. . :: . .Nullable](https://msdn.microsoft.com/en-us/library/b3h38hb0\(v=vs.90\))\< (Of \< ( \<'[Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))\> ) \> ) \>  
The index of the playing segment.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

