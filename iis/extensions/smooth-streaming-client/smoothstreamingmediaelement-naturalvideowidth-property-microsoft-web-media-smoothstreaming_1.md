---
title: SmoothStreamingMediaElement.NaturalVideoWidth Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: NaturalVideoWidth Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoWidth
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.naturalvideowidth(v=VS.95)
ms:contentKeyID: 46307841
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoWidth
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_NaturalVideoWidth
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_NaturalVideoWidth
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoWidth
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.NaturalVideoWidth Property

Gets the width of video display at which the resource appears best.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public ReadOnly Property NaturalVideoWidth As Integer
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Integer

value = instance.NaturalVideoWidth
```

``` csharp
public int NaturalVideoWidth { get; }
```

``` c++
public:
property int NaturalVideoWidth {
    int get ();
}
```

``` fsharp
member NaturalVideoWidth : int
```

``` jscript
function get NaturalVideoWidth () : int
```

#### Property Value

Type: [System.Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.95\))  
The width of video display at which the resource appears best.

## Remarks

To avoid reformatting the display and to avoid unnecessary processor load, do not assign the height and width properties of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) in the XAML specification. Instead, use the dimensions at which the video was encoded.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

