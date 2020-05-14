---
title: IJobManifest.Initialize Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Initialize Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IJobManifest.Initialize(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.ijobmanifest.initialize(v=VS.90)
ms:contentKeyID: 35520772
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobManifest.Initialize
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobManifest.Initialize
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Initialize Method

Initializes member variables for a job manifest that is loaded from disk instead of created as part of a job submission.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Sub Initialize ( _
    fileName As String _
)
'Usage

  Dim instance As IJobManifest
Dim fileName As String

instance.Initialize(fileName)
```

```csharp
  void Initialize(
    string fileName
)
```

```cpp
  void Initialize(
    String^ fileName
)
```

``` fsharp
  abstract Initialize :
        fileName:string -> unit
```

```jscript
  function Initialize(
    fileName : String
)
```

### Parameters

  - fileName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the job manifest file.  

## See Also

### Reference

[IJobManifest Interface](ijobmanifest-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
