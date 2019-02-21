---
title: JobManager.OutputFolderPath Property (Microsoft.Web.Media.TransformManager)
TOCTitle: OutputFolderPath Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.OutputFolderPath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.outputfolderpath(v=VS.90)
ms:contentKeyID: 35520811
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.OutputFolderPath
- Microsoft.Web.Media.TransformManager.JobManager.get_OutputFolderPath
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_OutputFolderPath
- Microsoft.Web.Media.TransformManager.JobManager.OutputFolderPath
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# OutputFolderPath Property

Gets the output folder for a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property OutputFolderPath As String
    Get
'Usage

  Dim instance As JobManager
Dim value As String

value = instance.OutputFolderPath
```

```csharp
  public string OutputFolderPath { get; }
```

```cpp
  public:
property String^ OutputFolderPath {
    String^ get ();
}
```

``` fsharp
  member OutputFolderPath : string
```

```jscript
  function get OutputFolderPath () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The output folder for a job.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

