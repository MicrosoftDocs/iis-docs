---
title: SmoothStreamingMediaElement.CurrentSegmentIndex Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CurrentSegmentIndex Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentSegmentIndex
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.currentsegmentindex(v=VS.95)
ms:contentKeyID: 46307821
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentSegmentIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CurrentSegmentIndex
dev_langs:
- CSharp
- JScript
- VB
- FSharp
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

# SmoothStreamingMediaElement.CurrentSegmentIndex Property

Gets the index of the currently playing segment.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public ReadOnly Property CurrentSegmentIndex As Nullable(Of Integer)
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Nullable(Of Integer)

value = instance.CurrentSegmentIndex
```

``` csharp
public Nullable<int> CurrentSegmentIndex { get; }
```

``` c++
public:
property Nullable<int> CurrentSegmentIndex {
    Nullable<int> get ();
}
```

``` fsharp
member CurrentSegmentIndex : Nullable<int>
```

``` jscript
function get CurrentSegmentIndex () : Nullable<int>
```

#### Property Value

Type: [System.Nullable](https://msdn.microsoft.com/en-us/library/b3h38hb0\(v=vs.95\))\<[Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.95\))\>  
The index of the playing segment.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

