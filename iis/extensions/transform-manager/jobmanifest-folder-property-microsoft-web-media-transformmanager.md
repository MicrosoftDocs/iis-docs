---
title: JobManifest.Folder Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Folder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.Folder
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.folder(v=VS.90)
ms:contentKeyID: 35520589
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_Folder
- Microsoft.Web.Media.TransformManager.JobManifest.set_Folder
- Microsoft.Web.Media.TransformManager.JobManifest.Folder
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.Folder
- Microsoft.Web.Media.TransformManager.JobManifest.get_Folder
- Microsoft.Web.Media.TransformManager.JobManifest.set_Folder
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Folder Property

Gets or sets the folder name of the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property Folder As String
    Get
    Set
'Usage

  Dim instance As JobManifest
Dim value As String

value = instance.Folder

instance.Folder = value
```

```csharp
  public string Folder { get; set; }
```

```cpp
  public:
property String^ Folder {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  member Folder : string with get, set
```

```jscript
  function get Folder () : String
function set Folder (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The folder name of the manifest.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
