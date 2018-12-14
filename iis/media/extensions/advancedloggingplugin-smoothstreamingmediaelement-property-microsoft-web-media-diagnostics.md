---
title: AdvancedLoggingPlugin.SmoothStreamingMediaElement Property  (Microsoft.Web.Media.Diagnostics)
TOCTitle: SmoothStreamingMediaElement Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.SmoothStreamingMediaElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.advancedloggingplugin.smoothstreamingmediaelement(v=VS.90)
ms:contentKeyID: 31469204
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_SmoothStreamingMediaElement
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.set_SmoothStreamingMediaElement
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.SmoothStreamingMediaElement
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_SmoothStreamingMediaElement
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.set_SmoothStreamingMediaElement
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.SmoothStreamingMediaElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement Property

Gets or sets the \[SmoothStreamingMediaElement\] that this plug-in will service.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertySmoothStreamingMediaElementAsSmoothStreamingMediaElement
'Usage
DiminstanceAsAdvancedLoggingPluginDimvalueAsSmoothStreamingMediaElementvalue = instance.SmoothStreamingMediaElement

instance.SmoothStreamingMediaElement = value
```

``` csharp
publicSmoothStreamingMediaElementSmoothStreamingMediaElement { get; set; }
```

``` c++
public:
propertySmoothStreamingMediaElement^ SmoothStreamingMediaElement {
    SmoothStreamingMediaElement^ get ();
    voidset (SmoothStreamingMediaElement^ value);
}
```

``` jscript
function getSmoothStreamingMediaElement () : SmoothStreamingMediaElementfunction setSmoothStreamingMediaElement (value : SmoothStreamingMediaElement)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)  

## Remarks

This plugin will collect advanced logs and post them to the URLs specified in [ApplicationLogUrls](advancedloggingplugin-applicationlogurls-property-microsoft-web-media-diagnostics_1.md) and in the [ManifestLogUrls](advancedloggingplugin-manifestlogurls-property-microsoft-web-media-diagnostics_1.md) elements.

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[AdvancedLoggingPlugin Class](advancedloggingplugin-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

