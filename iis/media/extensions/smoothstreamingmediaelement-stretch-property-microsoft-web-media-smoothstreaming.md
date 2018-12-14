---
title: SmoothStreamingMediaElement.Stretch Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Stretch Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Stretch
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.stretch(v=VS.90)
ms:contentKeyID: 23961082
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Stretch
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Stretch
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Stretch
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Stretch
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Stretch
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Stretch
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Stretch Property

Gets or sets an object that determines how to stretch the media display.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyStretchAsStretch
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsStretchvalue = instance.Stretch

instance.Stretch = value
```

``` csharp
publicStretchStretch { get; set; }
```

``` c++
public:
propertyStretchStretch {
    Stretchget ();
    voidset (Stretchvalue);
}
```

``` jscript
function getStretch () : Stretchfunction setStretch (value : Stretch)
```

#### Property Value

Type: [System.Windows.Media. . :: . .Stretch](https://msdn.microsoft.com/en-us/library/ms635549\(v=vs.90\))  
An object that specifies how the media element should be stretched to fill the destination rectangle.  

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

