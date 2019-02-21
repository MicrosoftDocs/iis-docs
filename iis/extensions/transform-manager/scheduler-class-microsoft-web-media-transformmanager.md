---
title: Scheduler Class (Microsoft.Web.Media.TransformManager)
TOCTitle: Scheduler Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.Scheduler
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.scheduler(v=VS.90)
ms:contentKeyID: 35520728
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Scheduler Class

Schedules IIS Transform Manager jobs.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..Scheduler  
    [Microsoft.Web.Media.TransformManager.HpcScheduler](hpcscheduler-class-microsoft-web-media-transformmanager.md)  
    [Microsoft.Web.Media.TransformManager.LocalScheduler](localscheduler-class-microsoft-web-media-transformmanager.md)  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustInherit Class Scheduler
'Usage

  Dim instance As Scheduler
```

```csharp
  public abstract class Scheduler
```

```cpp
  public ref class Scheduler abstract
```

``` fsharp
[<AbstractClassAttribute>]
type Scheduler =  class end
```

```jscript
  public abstract class Scheduler
```

The Scheduler type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Scheduler](scheduler-constructor-microsoft-web-media-transformmanager.md)|Initializes a new instance of the Scheduler class.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CancelJob](scheduler-canceljob-method-microsoft-web-media-transformmanager.md)|Cancels the specified job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CleanupJob](scheduler-cleanupjob-method-microsoft-web-media-transformmanager.md)|Removes scheduler artifacts for the specified job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CleanupWorkFolder](scheduler-cleanupworkfolder-method-microsoft-web-media-transformmanager.md)||
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Connect](scheduler-connect-method-microsoft-web-media-transformmanager.md)|Connects to the scheduler.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Dispose](scheduler-dispose-method-microsoft-web-media-transformmanager.md)|Releases all resources that are used by the current instance of the Scheduler class.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobCompletionDetails](scheduler-getjobcompletiondetails-method-microsoft-web-media-transformmanager.md)|Returns a report about the specified job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobStatus](scheduler-getjobstatus-method-microsoft-web-media-transformmanager.md)|Returns the status of the specified job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetRunningJobs](scheduler-getrunningjobs-method-microsoft-web-media-transformmanager.md)|Returns a list of job instance IDs for jobs that are running.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetTaskChildProcessId](scheduler-gettaskchildprocessid-method-microsoft-web-media-transformmanager.md)|Returns the ID of the child process of an executable program by using the specified job instance ID.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetTaskProgress](scheduler-gettaskprogress-method-microsoft-web-media-transformmanager.md)|Returns task progress for the specified job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Initialize](scheduler-initialize-method-microsoft-web-media-transformmanager.md)|Sets the properties for this scheduler instance.|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetLogWriter](scheduler-setlogwriter-method-microsoft-web-media-transformmanager.md)|Sets the [Logger](logger-class-microsoft-web-media-transformmanager.md) object for the scheduler.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskChildProcessId](scheduler-settaskchildprocessid-method-microsoft-web-media-transformmanager.md)|Sets the ID of the child process of an executable program by using the specified job instance ID and child process ID.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskCount](scheduler-settaskcount-method-microsoft-web-media-transformmanager.md)|Sets the task count for the specified job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskIndex](scheduler-settaskindex-method-microsoft-web-media-transformmanager.md)|Sets the index of a task for the scheduler by using the specified job and task index.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[StartJob](scheduler-startjob-method-microsoft-web-media-transformmanager.md)|Starts the specified job using the scheduler.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SubmitJob](scheduler-submitjob-method-microsoft-web-media-transformmanager.md)|Submits the job to the scheduler.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateJobProgress](scheduler-updatejobprogress-method-microsoft-web-media-transformmanager.md)|Updates the progress of the specified job.|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

