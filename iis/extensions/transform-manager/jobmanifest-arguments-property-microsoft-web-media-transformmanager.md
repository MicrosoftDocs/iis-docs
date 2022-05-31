---
title: JobManifest.Arguments Property (Microsoft.Web.Media.TransformManager)
description: Arguments Property gets executable program task arguments that are associated with the data in the manifest.
TOCTitle: Arguments Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.Arguments
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.arguments(v=VS.90)
ms:contentKeyID: 35520560
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_Arguments
- Microsoft.Web.Media.TransformManager.JobManifest.Arguments
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.Arguments
- Microsoft.Web.Media.TransformManager.JobManifest.get_Arguments
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Arguments Property

Gets executable program task arguments that are associated with the data in the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property Arguments As ArrayList
    Get
'Usage

  Dim instance As JobManifest
Dim value As ArrayList

value = instance.Arguments
```

```csharp
  public ArrayList Arguments { get; }
```

```cpp
  public:
property ArrayList^ Arguments {
    ArrayList^ get ();
}
```

``` fsharp
  member Arguments : ArrayList
```

```jscript
  function get Arguments () : ArrayList
```

### Property Value

Type: ArrayList  
An array of arguments.  

## Remarks

Tasks can either be implementations of the [ITask](itask-interface-microsoft-web-media-transformmanager.md) interface or they can be command-line tasks. If there are command-line tasks, the command-line programs are collected in the [Programs](jobmanifest-programs-property-microsoft-web-media-transformmanager.md) property and the arguments are collected in this property.

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
