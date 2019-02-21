---
title: JobManifest.InstanceFileIsManifest Property (Microsoft.Web.Media.TransformManager)
TOCTitle: InstanceFileIsManifest Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.InstanceFileIsManifest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.instancefileismanifest(v=VS.90)
ms:contentKeyID: 35520582
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_InstanceFileIsManifest
- Microsoft.Web.Media.TransformManager.JobManifest.InstanceFileIsManifest
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_InstanceFileIsManifest
- Microsoft.Web.Media.TransformManager.JobManifest.InstanceFileIsManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# InstanceFileIsManifest Property

Gets a value that indicates whether the file that initiates job creation is a SMIL 2.0-compliant manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property InstanceFileIsManifest As Boolean
    Get
'Usage

  Dim instance As JobManifest
Dim value As Boolean

value = instance.InstanceFileIsManifest
```

```csharp
  public bool InstanceFileIsManifest { get; }
```

```cpp
  public:
property bool InstanceFileIsManifest {
    bool get ();
}
```

``` fsharp
  member InstanceFileIsManifest : bool
```

```jscript
  function get InstanceFileIsManifest () : boolean
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the file that initiates job creation is a SMIL 2.0-compliant manifest; otherwise, false.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

