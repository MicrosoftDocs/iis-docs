---
title: ITask.Initialize Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Initialize Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.ITask.Initialize(Microsoft.Web.Media.TransformManager.ITaskStatus,Microsoft.Web.Media.TransformManager.IJobMetadata,Microsoft.Web.Media.TransformManager.ILogger)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.itask.initialize(v=VS.90)
ms:contentKeyID: 35521024
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ITask.Initialize
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ITask.Initialize
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Initialize Method

Initializes the task with objects for reporting status, logging data, and getting metadata from the job manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Sub Initialize ( _
    status As ITaskStatus, _
    metadata As IJobMetadata, _
    logger As ILogger _
)
'Usage

  Dim instance As ITask
Dim status As ITaskStatus
Dim metadata As IJobMetadata
Dim logger As ILogger

instance.Initialize(status, metadata, _
    logger)
```

```csharp
  void Initialize(
    ITaskStatus status,
    IJobMetadata metadata,
    ILogger logger
)
```

```cpp
  void Initialize(
    ITaskStatus^ status, 
    IJobMetadata^ metadata, 
    ILogger^ logger
)
```

``` fsharp
  abstract Initialize : 
        status:ITaskStatus * 
        metadata:IJobMetadata * 
        logger:ILogger -> unit 
```

```jscript
  function Initialize(
    status : ITaskStatus, 
    metadata : IJobMetadata, 
    logger : ILogger
)
```

### Parameters

  - status  
    Type: [Microsoft.Web.Media.TransformManager.ITaskStatus](itaskstatus-interface-microsoft-web-media-transformmanager.md)  
    A status object that contains two properties, a percent complete and a [JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md) enumeration value.  

<!-- end list -->

  - metadata  
    Type: [Microsoft.Web.Media.TransformManager.IJobMetadata](ijobmetadata-interface-microsoft-web-media-transformmanager.md)  
    Metadata about the task.  

<!-- end list -->

  - logger  
    Type: [Microsoft.Web.Media.TransformManager.ILogger](ilogger-interface-microsoft-web-media-transformmanager.md)  
    The logger object.  

## See Also

### Reference

[ITask Interface](itask-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

