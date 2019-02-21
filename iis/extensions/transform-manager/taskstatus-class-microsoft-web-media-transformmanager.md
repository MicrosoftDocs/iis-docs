---
title: TaskStatus Class (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskStatus Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.TaskStatus
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskstatus(v=VS.90)
ms:contentKeyID: 35521070
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TaskStatus Class

Provides a status callback mechanism for the task.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..TaskStatus  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Class TaskStatus _
    Implements ITaskStatus, IDisposable
'Usage

  Dim instance As TaskStatus
```

```csharp
  public class TaskStatus : ITaskStatus, IDisposable
```

```cpp
  public ref class TaskStatus : ITaskStatus, 
    IDisposable
```

``` fsharp
  type TaskStatus =  
    class
        interface ITaskStatus
        interface IDisposable
    end
```

```jscript
  public class TaskStatus implements ITaskStatus, IDisposable
```

The TaskStatus type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[TaskStatus](taskstatus-constructor-microsoft-web-media-transformmanager.md)|Initializes a new instance of the TaskStatus class by using the specified manifest and logger.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Message](taskstatus-message-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[PercentComplete](taskstatus-percentcomplete-property-microsoft-web-media-transformmanager.md)|Gets the percentage of task completion.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Status](taskstatus-status-property-microsoft-web-media-transformmanager.md)|Gets the status of the task.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskChildProcessId](taskstatus-taskchildprocessid-property-microsoft-web-media-transformmanager.md)|Gets the ID of the child process of the task.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskCount](taskstatus-taskcount-property-microsoft-web-media-transformmanager.md)|Gets the task count.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskIndex](taskstatus-taskindex-property-microsoft-web-media-transformmanager.md)|Gets the task index.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Dispose() () () ()](taskstatus-dispose-method-microsoft-web-media-transformmanager_1.md)|Disposes task resources.|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Dispose(Boolean)](taskstatus-dispose-method-boolean-microsoft-web-media-transformmanager.md)|Disposes task resources and optionally releases the managed resources.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskChildProcessId](taskstatus-settaskchildprocessid-method-microsoft-web-media-transformmanager.md)|Sets the ID of the child process of the task.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskCount](taskstatus-settaskcount-method-microsoft-web-media-transformmanager.md)|Sets the number of tasks to be performed by the scheduler.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskIndex](taskstatus-settaskindex-method-microsoft-web-media-transformmanager.md)|Sets the index of the task to be performed by the scheduler.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateStatus](taskstatus-updatestatus-method-microsoft-web-media-transformmanager.md)|Updates the status to an ongoing task by using the specified percentage complete, status, and message.|

## Remarks

Task status is reported back through the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object. Initialize this object using a manifest that contains scheduler information. Each task will be passed an object that implements this interface through dependency injection.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

