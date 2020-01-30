---
title: JobManifest.ManifestAsString Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestAsString Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.ManifestAsString
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.manifestasstring(v=VS.90)
ms:contentKeyID: 35520944
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.ManifestAsString
- Microsoft.Web.Media.TransformManager.JobManifest.get_ManifestAsString
- Microsoft.Web.Media.TransformManager.JobManifest.set_ManifestAsString
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_ManifestAsString
- Microsoft.Web.Media.TransformManager.JobManifest.ManifestAsString
- Microsoft.Web.Media.TransformManager.JobManifest.set_ManifestAsString
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ManifestAsString Property

Gets the manifest XML content.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property ManifestAsString As String
    Get
    Set
'Usage

  Dim instance As JobManifest
Dim value As String

value = instance.ManifestAsString

instance.ManifestAsString = value
```

```csharp
  public string ManifestAsString { get; set; }
```

```cpp
  public:
property String^ ManifestAsString {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  member ManifestAsString : string with get, set
```

```jscript
  function get ManifestAsString () : String
function set ManifestAsString (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The manifest XML content.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

