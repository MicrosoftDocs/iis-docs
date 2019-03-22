---
title: SmoothStreamingMediaElement.NaturalVideoHeight Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: NaturalVideoHeight Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoHeight
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.naturalvideoheight(v=VS.95)
ms:contentKeyID: 46307839
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoHeight
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_NaturalVideoHeight
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_NaturalVideoHeight
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoHeight
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.NaturalVideoHeight Property

Gets the height of the video display at which the resource appears best.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property NaturalVideoHeight As Integer
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Integer

value = instance.NaturalVideoHeight
```

```csharp
public int NaturalVideoHeight { get; }
```

```cpp
public:
property int NaturalVideoHeight {
    int get ();
}
```

``` fsharp
member NaturalVideoHeight : int
```

```jscript
function get NaturalVideoHeight () : int
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d\(v=vs.95\))  
The height of the video display at which the resource appears best.

## Remarks

To avoid reformatting the display and to avoid unnecessary processor load, do not assign the height and width properties of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) in the XAML specification. Instead, use the dimensions at which the video was encoded.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

