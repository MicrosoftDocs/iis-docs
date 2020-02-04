---
title: JobManifest.Programs Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Programs Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.Programs
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.programs(v=VS.90)
ms:contentKeyID: 35520860
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_Programs
- Microsoft.Web.Media.TransformManager.JobManifest.Programs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_Programs
- Microsoft.Web.Media.TransformManager.JobManifest.Programs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Programs Property

Gets a collection of tasks that are executable program files.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property Programs As ArrayList
    Get
'Usage

  Dim instance As JobManifest
Dim value As ArrayList

value = instance.Programs
```

```csharp
  public ArrayList Programs { get; }
```

```cpp
  public:
property ArrayList^ Programs {
    ArrayList^ get ();
}
```

``` fsharp
  member Programs : ArrayList
```

```jscript
  function get Programs () : ArrayList
```

### Property Value

Type: ArrayList  
A collection of program tasks.  

## Remarks

Tasks can either be implementations of the [ITask](itask-interface-microsoft-web-media-transformmanager.md) interface or they can be command-line tasks. If there are command-line tasks, the command-line programs are collected in this property and the arguments are collected in the Programs property.

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

