---
title: JobManifest.InstanceId Property (Microsoft.Web.Media.TransformManager)
TOCTitle: InstanceId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.InstanceId
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.instanceid(v=VS.90)
ms:contentKeyID: 35520911
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_InstanceId
- Microsoft.Web.Media.TransformManager.JobManifest.InstanceId
- Microsoft.Web.Media.TransformManager.JobManifest.set_InstanceId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_InstanceId
- Microsoft.Web.Media.TransformManager.JobManifest.InstanceId
- Microsoft.Web.Media.TransformManager.JobManifest.set_InstanceId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# InstanceId Property

Gets or sets the ID of the manifest instance.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property InstanceId As String
    Get
    Set
'Usage

  Dim instance As JobManifest
Dim value As String

value = instance.InstanceId

instance.InstanceId = value
```

```csharp
  public string InstanceId { get; set; }
```

```cpp
  public:
property String^ InstanceId {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  member InstanceId : string with get, set
```

```jscript
  function get InstanceId () : String
function set InstanceId (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The ID of the manifest instance.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
