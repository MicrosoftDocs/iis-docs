---
title: JobManifest.Priority Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Priority Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.Priority
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.priority(v=VS.90)
ms:contentKeyID: 35520940
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.Priority
- Microsoft.Web.Media.TransformManager.JobManifest.get_Priority
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_Priority
- Microsoft.Web.Media.TransformManager.JobManifest.Priority
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Priority Property

Gets the priority of a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property Priority As Integer
    Get
'Usage

  Dim instance As JobManifest
Dim value As Integer

value = instance.Priority
```

```csharp
  public int Priority { get; }
```

```cpp
  public:
property int Priority {
    int get ();
}
```

``` fsharp
  member Priority : int
```

```jscript
  function get Priority () : int
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The job priority.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

