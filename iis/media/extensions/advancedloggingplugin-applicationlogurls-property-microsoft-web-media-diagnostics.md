---
title: AdvancedLoggingPlugin.ApplicationLogUrls Property  (Microsoft.Web.Media.Diagnostics)
TOCTitle: ApplicationLogUrls Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.ApplicationLogUrls
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.advancedloggingplugin.applicationlogurls(v=VS.90)
ms:contentKeyID: 31469187
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.ApplicationLogUrls
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_ApplicationLogUrls
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.set_ApplicationLogUrls
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.ApplicationLogUrls
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_ApplicationLogUrls
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.set_ApplicationLogUrls
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ApplicationLogUrls Property

Gets or sets the ApplicationLogUrls.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyApplicationLogUrlsAsIList(OfString)
'Usage
DiminstanceAsAdvancedLoggingPluginDimvalueAsIList(OfString)

value = instance.ApplicationLogUrls

instance.ApplicationLogUrls = value
```

``` csharp
publicIList<string> ApplicationLogUrls { get; set; }
```

``` c++
public:
propertyIList<String^>^ ApplicationLogUrls {
    IList<String^>^ get ();
    voidset (IList<String^>^ value);
}
```

``` jscript
function getApplicationLogUrls () : IList<String>
function setApplicationLogUrls (value : IList<String>)
```

#### Property Value

Type: [System.Collections.Generic. . :: . .IList](https://msdn.microsoft.com/en-us/library/5y536ey6\(v=vs.90\))\< (Of \< ( \<'[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))\> ) \> ) \>  
A generic IList of type string.  

## Remarks

The application can specify a list of URLs to which advanced logs will be posted. For thread safety, callers should lock(ApplicationLogUrls) before accessing. There is a separate list of URLs, [ManifestLogUrls](advancedloggingplugin-manifestlogurls-property-microsoft-web-media-diagnostics_1.md) that is populated from the LogUrl elements in the currently playing manifest. These two lists describe all the URLs that will receive the advanced logs.

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

