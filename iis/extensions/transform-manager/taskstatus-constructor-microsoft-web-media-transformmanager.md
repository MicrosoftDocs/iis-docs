---
title: TaskStatus Constructor  (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskStatus Constructor
ms:assetid: M:Microsoft.Web.Media.TransformManager.TaskStatus.#ctor(Microsoft.Web.Media.TransformManager.JobManifest,Microsoft.Web.Media.TransformManager.ILogger)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskstatus.taskstatus(v=VS.90)
ms:contentKeyID: 35520679
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.TaskStatus
- Microsoft.Web.Media.TransformManager.TaskStatus.#ctor
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TaskStatus Constructor

Initializes a new instance of the [TaskStatus](taskstatus-class-microsoft-web-media-transformmanager.md) class by using the specified manifest and logger.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    manifest As JobManifest, _
    logger As ILogger _
)
'Usage

  Dim manifest As JobManifest
Dim logger As ILogger

Dim instance As New TaskStatus(manifest, _
    logger)
```

```csharp
  public TaskStatus(
    JobManifest manifest,
    ILogger logger
)
```

```cpp
  public:
TaskStatus(
    JobManifest^ manifest, 
    ILogger^ logger
)
```

``` fsharp
  new : 
        manifest:JobManifest * 
        logger:ILogger -> TaskStatus
```

```jscript
  public function TaskStatus(
    manifest : JobManifest, 
    logger : ILogger
)
```

### Parameters

  - manifest  
    Type: [Microsoft.Web.Media.TransformManager.JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md)  
    A job manifest that contains a [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) object.  

<!-- end list -->

  - logger  
    Type: [Microsoft.Web.Media.TransformManager.ILogger](ilogger-interface-microsoft-web-media-transformmanager.md)  
    A logger object that can be used by the task to write data to the job-instance log.  

## See Also

### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

