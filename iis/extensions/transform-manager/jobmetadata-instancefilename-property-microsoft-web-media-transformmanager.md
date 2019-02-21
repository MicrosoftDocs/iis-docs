---
title: JobMetadata.InstanceFileName Property (Microsoft.Web.Media.TransformManager)
TOCTitle: InstanceFileName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.InstanceFileName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.instancefilename(v=VS.90)
ms:contentKeyID: 35521102
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_InstanceFileName
- Microsoft.Web.Media.TransformManager.JobMetadata.InstanceFileName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_InstanceFileName
- Microsoft.Web.Media.TransformManager.JobMetadata.InstanceFileName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# InstanceFileName Property

Gets the instance file name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property InstanceFileName As String
    Get
'Usage

  Dim instance As JobMetadata
Dim value As String

value = instance.InstanceFileName
```

```csharp
  public string InstanceFileName { get; }
```

```cpp
  public:
virtual property String^ InstanceFileName {
    String^ get () sealed;
}
```

``` fsharp
  abstract InstanceFileName : string
override InstanceFileName : string
```

```jscript
  final function get InstanceFileName () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The instance file name.  

### Implements

[IJobMetadata.InstanceFileName](ijobmetadata-instancefilename-property-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

