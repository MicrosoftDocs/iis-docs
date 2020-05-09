---
title: JobManager.Enabled Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Enabled Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.Enabled
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanager.enabled(v=VS.90)
ms:contentKeyID: 35520591
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_Enabled
- Microsoft.Web.Media.TransformManager.JobManager.set_Enabled
- Microsoft.Web.Media.TransformManager.JobManager.Enabled
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.Enabled
- Microsoft.Web.Media.TransformManager.JobManager.get_Enabled
- Microsoft.Web.Media.TransformManager.JobManager.set_Enabled
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Enabled Property

Gets a value that indicates whether the job manager that is associated with this job definition can be started.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public Property Enabled As Boolean
    Get
    Private Set
'Usage

  Dim instance As JobManager
Dim value As Boolean

value = instance.Enabled
```

```csharp
  public bool Enabled { get; private set; }
```

```cpp
  public:
property bool Enabled {
    bool get ();
    private: void set (bool value);
}
```

``` fsharp
  member Enabled : bool with get, private set
```

```jscript
  function get Enabled () : boolean
private function set Enabled (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
A value that indicates whether the job manager that is associated with this job definition can be started.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
