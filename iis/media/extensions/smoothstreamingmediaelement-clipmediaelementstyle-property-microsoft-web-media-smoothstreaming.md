---
title: SmoothStreamingMediaElement.ClipMediaElementStyle Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipMediaElementStyle Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipMediaElementStyle
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.clipmediaelementstyle(v=VS.90)
ms:contentKeyID: 23961262
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipMediaElementStyle
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_ClipMediaElementStyle
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_ClipMediaElementStyle
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipMediaElementStyle
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_ClipMediaElementStyle
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_ClipMediaElementStyle
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipMediaElementStyle Property

Gets or sets the style object for the window.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyClipMediaElementStyleAsStyle
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsStylevalue = instance.ClipMediaElementStyle

instance.ClipMediaElementStyle = value
```

``` csharp
publicStyleClipMediaElementStyle { get; set; }
```

``` c++
public:
propertyStyle^ ClipMediaElementStyle {
    Style^ get ();
    voidset (Style^ value);
}
```

``` jscript
function getClipMediaElementStyle () : Stylefunction setClipMediaElementStyle (value : Style)
```

#### Property Value

Type: [System.Windows. . :: . .Style](https://msdn.microsoft.com/en-us/library/ms603146\(v=vs.90\))  
A Windows style object.  

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

