---
title: SmoothStreamingMediaElement.NaturalVideoWidth Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: NaturalVideoWidth Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoWidth
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.naturalvideowidth(v=VS.90)
ms:contentKeyID: 23961241
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoWidth
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_NaturalVideoWidth
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_NaturalVideoWidth
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalVideoWidth
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# NaturalVideoWidth Property

Gets the width of video display at which the resource appears best.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property NaturalVideoWidth As Integer
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Integer

value = instance.NaturalVideoWidth
```

```csharp
  public int NaturalVideoWidth { get; }
```

```cpp
  public:
property int NaturalVideoWidth {
    int get ();
}
```

```jscript
  function get NaturalVideoWidth () : int
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The width of video display at which the resource appears best.  

## Remarks

To avoid reformatting the display and to avoid unnecessary processor load, do not assign the height and width properties of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) in the XAML specification. Instead, use the dimensions at which the video was encoded.

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

