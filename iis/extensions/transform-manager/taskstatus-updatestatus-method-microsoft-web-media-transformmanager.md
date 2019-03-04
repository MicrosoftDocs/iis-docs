---
title: TaskStatus.UpdateStatus Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateStatus Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TaskStatus.UpdateStatus(System.Int32,Microsoft.Web.Media.TransformManager.JobStatus,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskstatus.updatestatus(v=VS.90)
ms:contentKeyID: 35521104
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.UpdateStatus
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus.UpdateStatus
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# UpdateStatus Method

Updates the status to an ongoing task by using the specified percentage complete, status, and message.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub UpdateStatus ( _
    percentComplete As Integer, _
    status As JobStatus, _
    message As String _
)
'Usage

  Dim instance As TaskStatus
Dim percentComplete As Integer
Dim status As JobStatus
Dim message As String

instance.UpdateStatus(percentComplete, _
    status, message)
```

```csharp
  public void UpdateStatus(
    int percentComplete,
    JobStatus status,
    string message
)
```

```cpp
  public:
virtual void UpdateStatus(
    int percentComplete, 
    JobStatus status, 
    String^ message
) sealed
```

``` fsharp
  abstract UpdateStatus : 
        percentComplete:int * 
        status:JobStatus * 
        message:string -> unit 
override UpdateStatus : 
        percentComplete:int * 
        status:JobStatus * 
        message:string -> unit 
```

```jscript
  public final function UpdateStatus(
    percentComplete : int, 
    status : JobStatus, 
    message : String
)
```

### Parameters

  - percentComplete  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    The percentage completed of the task.  

<!-- end list -->

  - status  
    Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
    The task status.  

<!-- end list -->

  - message  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    A message to include in the status update.  

### Implements

[ITaskStatus.UpdateStatus(Int32, JobStatus, String)](itaskstatus-updatestatus-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

