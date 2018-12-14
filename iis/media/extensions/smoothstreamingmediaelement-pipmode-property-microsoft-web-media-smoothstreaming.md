---
title: SmoothStreamingMediaElement.PipMode Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PipMode Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PipMode
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.pipmode(v=VS.90)
ms:contentKeyID: 28440971
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PipMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_PipMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_PipMode
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_PipMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PipMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_PipMode
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PipMode Property

Gets or sets a value that indicates whether the media stream is in picture-in-picture (PIP) mode.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyPipModeAsBoolean
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsBooleanvalue = instance.PipMode

instance.PipMode = value
```

``` csharp
publicboolPipMode { get; set; }
```

``` c++
public:
propertyboolPipMode {
    boolget ();
    voidset (boolvalue);
}
```

``` jscript
function getPipMode () : booleanfunction setPipMode (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the media stream is in picture-in-picture (PIP) mode; otherwise, false.  

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

