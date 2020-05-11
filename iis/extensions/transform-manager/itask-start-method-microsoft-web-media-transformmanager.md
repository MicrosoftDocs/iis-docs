---
title: ITask.Start Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Start Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.ITask.Start
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.itask.start(v=VS.90)
ms:contentKeyID: 35520816
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ITask.Start
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ITask.Start
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Start Method

Called by the framework to start the task immediately after the [Initialize(ITaskStatus, IJobMetadata, ILogger)](itask-initialize-method-microsoft-web-media-transformmanager.md) method runs.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Sub Start
'Usage

  Dim instance As ITask

instance.Start()
```

```csharp
  void Start()
```

```cpp
  void Start()
```

``` fsharp
  abstract Start : unit -> unit 
```

```jscript
  function Start()
```

## See Also

### Reference

[ITask Interface](itask-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
