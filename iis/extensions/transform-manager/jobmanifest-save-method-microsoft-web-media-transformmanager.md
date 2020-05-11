---
title: JobManifest.Save Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Save Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.Save(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.save(v=VS.90)
ms:contentKeyID: 35520894
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.Save
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.Save
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Save Method

Saves a job manifest file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub Save ( _
    fileName As String _
)
'Usage

  Dim instance As JobManifest
Dim fileName As String

instance.Save(fileName)
```

```csharp
  public void Save(
    string fileName
)
```

```cpp
  public:
void Save(
    String^ fileName
)
```

``` fsharp
  member Save : 
        fileName:string -> unit 
```

```jscript
  public function Save(
    fileName : String
)
```

### Parameters

  - fileName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the manifest file.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
