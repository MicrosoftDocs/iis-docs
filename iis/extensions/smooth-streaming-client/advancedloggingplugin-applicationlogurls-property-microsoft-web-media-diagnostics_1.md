---
title: AdvancedLoggingPlugin.ApplicationLogUrls Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: ApplicationLogUrls Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.ApplicationLogUrls
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.advancedloggingplugin.applicationlogurls(v=VS.95)
ms:contentKeyID: 46307722
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.ApplicationLogUrls
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_ApplicationLogUrls
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.set_ApplicationLogUrls
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
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
---

# AdvancedLoggingPlugin.ApplicationLogUrls Property

Gets or sets the ApplicationLogUrls.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ApplicationLogUrls As IList(Of String)
    Get
    Set
'Usage

Dim instance As AdvancedLoggingPlugin
Dim value As IList(Of String)

value = instance.ApplicationLogUrls

instance.ApplicationLogUrls = value
```

```csharp
public IList<string> ApplicationLogUrls { get; set; }
```

```cpp
public:
property IList<String^>^ ApplicationLogUrls {
    IList<String^>^ get ();
    void set (IList<String^>^ value);
}
```

``` fsharp
member ApplicationLogUrls : IList<string> with get, set
```

```jscript
function get ApplicationLogUrls () : IList<String>
function set ApplicationLogUrls (value : IList<String>)
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))\>  
A generic IList of type string.

## Remarks

The application can specify a list of URLs to which advanced logs will be posted. For thread safety, callers should lock(ApplicationLogUrls) before accessing. There is a separate list of URLs, [ManifestLogUrls](advancedloggingplugin-manifestlogurls-property-microsoft-web-media-diagnostics_1.md) that is populated from the LogUrl elements in the currently playing manifest. These two lists describe all the URLs that will receive the advanced logs.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[AdvancedLoggingPlugin Class](advancedloggingplugin-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

