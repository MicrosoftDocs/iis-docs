---
title: JobMetadata.InstanceFileIsManifest Property (Microsoft.Web.Media.TransformManager)
TOCTitle: InstanceFileIsManifest Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.InstanceFileIsManifest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.instancefileismanifest(v=VS.90)
ms:contentKeyID: 35520879
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.InstanceFileIsManifest
- Microsoft.Web.Media.TransformManager.JobMetadata.get_InstanceFileIsManifest
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_InstanceFileIsManifest
- Microsoft.Web.Media.TransformManager.JobMetadata.InstanceFileIsManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstanceFileIsManifest Property

Gets a value that indicates whether the instance file is a manifest file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property InstanceFileIsManifest As Boolean
    Get
'Usage

  Dim instance As JobMetadata
Dim value As Boolean

value = instance.InstanceFileIsManifest
```

```csharp
  public bool InstanceFileIsManifest { get; }
```

```cpp
  public:
virtual property bool InstanceFileIsManifest {
    bool get () sealed;
}
```

``` fsharp
  abstract InstanceFileIsManifest : bool
override InstanceFileIsManifest : bool
```

```jscript
  final function get InstanceFileIsManifest () : boolean
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the instance file is a manifest file; otherwise, false.  

### Implements

[IJobMetadata.InstanceFileIsManifest](ijobmetadata-instancefileismanifest-property-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

