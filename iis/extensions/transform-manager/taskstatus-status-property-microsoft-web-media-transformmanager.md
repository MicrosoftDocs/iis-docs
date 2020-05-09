---
title: TaskStatus.Status Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Status Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskStatus.Status
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskstatus.status(v=VS.90)
ms:contentKeyID: 35520598
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.get_Status
- Microsoft.Web.Media.TransformManager.TaskStatus.Status
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus.get_Status
- Microsoft.Web.Media.TransformManager.TaskStatus.Status
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Status Property

Gets the status of the task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property Status As JobStatus
    Get
'Usage

  Dim instance As TaskStatus
Dim value As JobStatus

value = instance.Status
```

```csharp
  public JobStatus Status { get; }
```

```cpp
  public:
virtual property JobStatus Status {
    JobStatus get () sealed;
}
```

``` fsharp
  abstract Status : JobStatus
override Status : JobStatus
```

```jscript
  final function get Status () : JobStatus
```

### Property Value

Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The task status.  

### Implements

[ITaskStatus.Status](itaskstatus-status-property-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
