---
title: JobManifest.Initialize Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Initialize Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.Initialize(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.initialize(v=VS.90)
ms:contentKeyID: 35520756
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.Initialize
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.Initialize
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Initialize Method

Initializes member variables for a manifest that is loaded from disk instead of created as part of job submission.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub Initialize ( _
    fileName As String _
)
'Usage

  Dim instance As JobManifest
Dim fileName As String

instance.Initialize(fileName)
```

```csharp
  public void Initialize(
    string fileName
)
```

```cpp
  public:
virtual void Initialize(
    String^ fileName
) sealed
```

``` fsharp
  abstract Initialize : 
        fileName:string -> unit 
override Initialize : 
        fileName:string -> unit 
```

```jscript
  public final function Initialize(
    fileName : String
)
```

### Parameters

  - fileName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the manifest file.  

### Implements

[IJobManifest.Initialize(String)](ijobmanifest-initialize-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

