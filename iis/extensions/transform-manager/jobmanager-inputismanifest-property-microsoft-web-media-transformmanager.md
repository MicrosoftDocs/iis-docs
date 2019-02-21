---
title: JobManager.InputIsManifest Property (Microsoft.Web.Media.TransformManager)
TOCTitle: InputIsManifest Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.InputIsManifest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.inputismanifest(v=VS.90)
ms:contentKeyID: 35521122
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_InputIsManifest
- Microsoft.Web.Media.TransformManager.JobManager.InputIsManifest
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_InputIsManifest
- Microsoft.Web.Media.TransformManager.JobManager.InputIsManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# InputIsManifest Property

Gets a value that indicates whether the file that initiates job creation is a SMIL 2.0-compliant manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property InputIsManifest As Boolean
    Get
'Usage

  Dim instance As JobManager
Dim value As Boolean

value = instance.InputIsManifest
```

```csharp
  public bool InputIsManifest { get; }
```

```cpp
  public:
property bool InputIsManifest {
    bool get ();
}
```

``` fsharp
  member InputIsManifest : bool
```

```jscript
  function get InputIsManifest () : boolean
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
A value that indicates whether the file that initiates job creation is a SMIL 2.0-compliant manifest.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

