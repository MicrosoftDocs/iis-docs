---
title: JobManager.InputFolderPath Property (Microsoft.Web.Media.TransformManager)
TOCTitle: InputFolderPath Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.InputFolderPath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.inputfolderpath(v=VS.90)
ms:contentKeyID: 35520878
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.InputFolderPath
- Microsoft.Web.Media.TransformManager.JobManager.get_InputFolderPath
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_InputFolderPath
- Microsoft.Web.Media.TransformManager.JobManager.InputFolderPath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# InputFolderPath Property

Gets the input folder name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property InputFolderPath As String
    Get
'Usage

  Dim instance As JobManager
Dim value As String

value = instance.InputFolderPath
```

```csharp
  public string InputFolderPath { get; }
```

```cpp
  public:
property String^ InputFolderPath {
    String^ get ();
}
```

``` fsharp
  member InputFolderPath : string
```

```jscript
  function get InputFolderPath () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The input folder name.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

