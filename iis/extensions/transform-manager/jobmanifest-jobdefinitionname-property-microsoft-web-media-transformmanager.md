---
title: JobManifest.JobDefinitionName Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobDefinitionName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.JobDefinitionName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.jobdefinitionname(v=VS.90)
ms:contentKeyID: 35520926
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.JobDefinitionName
- Microsoft.Web.Media.TransformManager.JobManifest.get_JobDefinitionName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_JobDefinitionName
- Microsoft.Web.Media.TransformManager.JobManifest.JobDefinitionName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobDefinitionName Property

Gets the name of the job definition from the job manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property JobDefinitionName As String
    Get
'Usage

  Dim instance As JobManifest
Dim value As String

value = instance.JobDefinitionName
```

```csharp
  public string JobDefinitionName { get; }
```

```cpp
  public:
property String^ JobDefinitionName {
    String^ get ();
}
```

``` fsharp
  member JobDefinitionName : string
```

```jscript
  function get JobDefinitionName () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The name of the job definition from the job manifest.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

