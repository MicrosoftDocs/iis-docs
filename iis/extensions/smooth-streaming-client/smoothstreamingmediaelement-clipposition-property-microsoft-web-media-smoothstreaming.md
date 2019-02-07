---
title: SmoothStreamingMediaElement.ClipPosition Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipPosition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.clipposition(v=VS.90)
ms:contentKeyID: 23961036
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_ClipPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_ClipPosition
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_ClipPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_ClipPosition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipPosition Property

Gets or sets the position in a clip stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Property ClipPosition As TimeSpan
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As TimeSpan

value = instance.ClipPosition
```

``` csharp
  public TimeSpan ClipPosition { get; private set; }
```

``` c++
  public:
property TimeSpan ClipPosition {
    TimeSpan get ();
    private: void set (TimeSpan value);
}
```

``` jscript
  function get ClipPosition () : TimeSpan
private function set ClipPosition (value : TimeSpan)
```

#### Property Value

Type: [System. . :: . .TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\))  
The position in a clip stream.  

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

