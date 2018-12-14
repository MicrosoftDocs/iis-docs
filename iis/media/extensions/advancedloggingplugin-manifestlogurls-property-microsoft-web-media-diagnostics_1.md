---
title: AdvancedLoggingPlugin.ManifestLogUrls Property  (Microsoft.Web.Media.Diagnostics)
TOCTitle: ManifestLogUrls Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.ManifestLogUrls
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.advancedloggingplugin.manifestlogurls(v=VS.95)
ms:contentKeyID: 46307723
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_ManifestLogUrls
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.ManifestLogUrls
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_ManifestLogUrls
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.ManifestLogUrls
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AdvancedLoggingPlugin.ManifestLogUrls Property

Gets the ManifestLogUrls.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public ReadOnly Property ManifestLogUrls As IList(Of String)
    Get
'Usage

Dim instance As AdvancedLoggingPlugin
Dim value As IList(Of String)

value = instance.ManifestLogUrls
```

``` csharp
public IList<string> ManifestLogUrls { get; }
```

``` c++
public:
property IList<String^>^ ManifestLogUrls {
    IList<String^>^ get ();
}
```

``` fsharp
member ManifestLogUrls : IList<string>
```

``` jscript
function get ManifestLogUrls () : IList<String>
```

#### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/en-us/library/5y536ey6\(v=vs.95\))\<[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.95\))\>  
A generic IList of type string.

## Remarks

The manifest can specify a list of URLs to which advanced logs will be posted, which is populated from the LogUrl elements in the currently playing manifest. There is a separate list of URLs, ApplicationLogUrls that is populated by the application. These two lists describe all the URLs that will receive advanced logs.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[AdvancedLoggingPlugin Class](advancedloggingplugin-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

