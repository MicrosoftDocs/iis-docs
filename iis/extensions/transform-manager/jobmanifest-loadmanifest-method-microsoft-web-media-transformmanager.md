---
title: JobManifest.LoadManifest Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: LoadManifest Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.LoadManifest(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.loadmanifest(v=VS.90)
ms:contentKeyID: 35521086
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.LoadManifest
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.LoadManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# LoadManifest Method

Loads the manifest file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function LoadManifest ( _
    fileName As String _
) As JobManifest
'Usage

  Dim fileName As String
Dim returnValue As JobManifest

returnValue = JobManifest.LoadManifest(fileName)
```

```csharp
  public static JobManifest LoadManifest(
    string fileName
)
```

```cpp
  public:
static JobManifest^ LoadManifest(
    String^ fileName
)
```

``` fsharp
  static member LoadManifest : 
        fileName:string -> JobManifest 
```

```jscript
  public static function LoadManifest(
    fileName : String
) : JobManifest
```

### Parameters

  - fileName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the manifest file.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md)  
A job manifest object that contains job-instance metadata.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

