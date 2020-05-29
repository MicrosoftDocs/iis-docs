---
title: AdvancedLoggingPlugin.ManifestLogUrls Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: ManifestLogUrls Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.ManifestLogUrls
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.advancedloggingplugin.manifestlogurls(v=VS.90)
ms:contentKeyID: 31469321
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_ManifestLogUrls
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.ManifestLogUrls
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_ManifestLogUrls
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.ManifestLogUrls
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ManifestLogUrls Property

Gets the ManifestLogUrls.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property ManifestLogUrls As IList(Of String)
'Usage

  Dim instance As AdvancedLoggingPlugin
Dim value As IList(Of String)

value = instance.ManifestLogUrls
```

```csharp
  public IList<string> ManifestLogUrls { get; }
```

```cpp
  public:
property IList<String^>^ ManifestLogUrls {
    IList<String^>^ get ();
}
```

```jscript
  function get ManifestLogUrls () : IList<String>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\< (Of \< ( \<'[String](https://msdn.microsoft.com/library/s1wwdcbf)\> ) \> ) \>  
A generic IList of type string.  

## Remarks

The manifest can specify a list of URLs to which advanced logs will be posted, which is populated from the LogUrl elements in the currently playing manifest. There is a separate list of URLs, ApplicationLogUrls that is populated by the application. These two lists describe all the URLs that will receive advanced logs.

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[AdvancedLoggingPlugin Class](advancedloggingplugin-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
