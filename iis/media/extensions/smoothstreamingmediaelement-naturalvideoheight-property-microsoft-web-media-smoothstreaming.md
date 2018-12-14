---
title: SmoothStreamingMediaElement.NaturalVideoHeight Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: NaturalVideoHeight Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoHeight
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.naturalvideoheight(v=VS.90)
ms:contentKeyID: 23961002
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoHeight
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_NaturalVideoHeight
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_NaturalVideoHeight
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoHeight
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# NaturalVideoHeight Property

Gets the height of the video display at which the resource appears best.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyNaturalVideoHeightAsInteger
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsIntegervalue = instance.NaturalVideoHeight
```

``` csharp
publicintNaturalVideoHeight { get; }
```

``` c++
public:
propertyintNaturalVideoHeight {
    intget ();
}
```

``` jscript
function getNaturalVideoHeight () : int
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The height of the video display at which the resource appears best.  

## Remarks

To avoid reformatting the display and to avoid unnecessary processor load, do not assign the height and width properties of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) in the XAML specification. Instead, use the dimensions at which the video was encoded.

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

