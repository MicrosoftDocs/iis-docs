---
title: JobManifest.FullFileName Property (Microsoft.Web.Media.TransformManager)
TOCTitle: FullFileName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.FullFileName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.fullfilename(v=VS.90)
ms:contentKeyID: 35520866
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_FullFileName
- Microsoft.Web.Media.TransformManager.JobManifest.FullFileName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.FullFileName
- Microsoft.Web.Media.TransformManager.JobManifest.get_FullFileName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FullFileName Property

Gets the folder name and file name of the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property FullFileName As String
    Get
'Usage

  Dim instance As JobManifest
Dim value As String

value = instance.FullFileName
```

```csharp
  public string FullFileName { get; }
```

```cpp
  public:
property String^ FullFileName {
    String^ get ();
}
```

``` fsharp
  member FullFileName : string
```

```jscript
  function get FullFileName () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The folder name and the file name of the manifest.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

