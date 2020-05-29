---
title: JobManifest.InputFileNames Property (Microsoft.Web.Media.TransformManager)
TOCTitle: InputFileNames Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.InputFileNames
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.inputfilenames(v=VS.90)
ms:contentKeyID: 35520801
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_InputFileNames
- Microsoft.Web.Media.TransformManager.JobManifest.InputFileNames
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_InputFileNames
- Microsoft.Web.Media.TransformManager.JobManifest.InputFileNames
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# InputFileNames Property

Gets a collection of input file names for a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property InputFileNames As ICollection(Of String)
    Get
'Usage

  Dim instance As JobManifest
Dim value As ICollection(Of String)

value = instance.InputFileNames
```

```csharp
  public ICollection<string> InputFileNames { get; }
```

```cpp
  public:
property ICollection<String^>^ InputFileNames {
    ICollection<String^>^ get ();
}
```

``` fsharp
  member InputFileNames : ICollection<string>
```

```jscript
  function get InputFileNames () : ICollection<String>
```

### Property Value

Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/library/92t2ye13)\< (Of \< ( \<'[String](https://msdn.microsoft.com/library/s1wwdcbf)\> ) \> ) \>  
A collection of input file names for a job.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
