---
title: LocalScheduler Class (Microsoft.Web.Media.TransformManager)
TOCTitle: LocalScheduler Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.LocalScheduler
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.localscheduler(v=VS.90)
ms:contentKeyID: 35520780
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LocalScheduler Class

Schedules a new IIS Transform Manager job that runs on the local computer.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  [Microsoft.Web.Media.TransformManager.Scheduler](scheduler-class-microsoft-web-media-transformmanager.md)  
    Microsoft.Web.Media.TransformManager..::..LocalScheduler  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Class LocalScheduler _
    Inherits Scheduler _
    Implements IDisposable
'Usage

  Dim instance As LocalScheduler
```

```csharp
  public class LocalScheduler : Scheduler, 
    IDisposable
```

```cpp
  public ref class LocalScheduler : public Scheduler, 
    IDisposable
```

``` fsharp
  type LocalScheduler =  
    class
        inherit Scheduler
        interface IDisposable
    end
```

```jscript
  public class LocalScheduler extends Scheduler implements IDisposable
```

The LocalScheduler type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[LocalScheduler](localscheduler-constructor-microsoft-web-media-transformmanager.md)|Initializes a new instance of the LocalScheduler class.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CancelJob](localscheduler-canceljob-method-microsoft-web-media-transformmanager.md)|Cancels the specified job. (Overrides [Scheduler.CancelJob(String)](scheduler-canceljob-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CleanupJob](localscheduler-cleanupjob-method-microsoft-web-media-transformmanager.md)|Removes scheduler artifacts for the specified job. (Overrides [Scheduler.CleanupJob(String)](scheduler-cleanupjob-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CleanupWorkFolder](localscheduler-cleanupworkfolder-method-microsoft-web-media-transformmanager.md)|(Overrides [Scheduler.CleanupWorkFolder(String)](scheduler-cleanupworkfolder-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Connect](localscheduler-connect-method-microsoft-web-media-transformmanager.md)|Connects to the local scheduler. (Overrides [Scheduler.Connect(String)](scheduler-connect-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Dispose() () () ()](localscheduler-dispose-method-microsoft-web-media-transformmanager_1.md)|Releases all resources that are used by the current instance of the LocalScheduler class. (Overrides [Scheduler.Dispose() () () ()](scheduler-dispose-method-microsoft-web-media-transformmanager.md).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Dispose(Boolean)](localscheduler-dispose-method-boolean-microsoft-web-media-transformmanager.md)|Releases unmanaged resources and optionally releases managed resources.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobCompletionDetails](localscheduler-getjobcompletiondetails-method-microsoft-web-media-transformmanager.md)|Returns a report about the specified job. (Overrides [Scheduler.GetJobCompletionDetails(String)](scheduler-getjobcompletiondetails-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobStatus](localscheduler-getjobstatus-method-microsoft-web-media-transformmanager.md)|Returns the status of the specified job. (Overrides [Scheduler.GetJobStatus(String)](scheduler-getjobstatus-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetRunningJobs](localscheduler-getrunningjobs-method-microsoft-web-media-transformmanager.md)|Returns a list of job instance IDs based on the currently running jobs. (Overrides [Scheduler.GetRunningJobs() () () ()](scheduler-getrunningjobs-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetTaskChildProcessId](localscheduler-gettaskchildprocessid-method-microsoft-web-media-transformmanager.md)|Returns the ID of the child process of a task that is an executable, using the specified job. (Overrides [Scheduler.GetTaskChildProcessId(String)](scheduler-gettaskchildprocessid-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetTaskProgress](localscheduler-gettaskprogress-method-microsoft-web-media-transformmanager.md)|Returns the percentage complete for a job. (Overrides [Scheduler.GetTaskProgress(String)](scheduler-gettaskprogress-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Initialize](localscheduler-initialize-method-microsoft-web-media-transformmanager.md)|Sets the name, priority, and properties for this scheduler instance. (Overrides [Scheduler.Initialize(String, Credential, String, Int32, Dictionary< (Of < <' (String, String> ) > > ))](scheduler-initialize-method-microsoft-web-media-transformmanager.md).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetLogWriter](localscheduler-setlogwriter-method-microsoft-web-media-transformmanager.md)|Sets the [Logger](logger-class-microsoft-web-media-transformmanager.md) object for the local scheduler. (Overrides [Scheduler.SetLogWriter(Logger)](scheduler-setlogwriter-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskChildProcessId](localscheduler-settaskchildprocessid-method-microsoft-web-media-transformmanager.md)|Sets the ID of the child process for a task that is an executable by using the specified job and child process. (Overrides [Scheduler.SetTaskChildProcessId(String, Int32)](scheduler-settaskchildprocessid-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskCount](localscheduler-settaskcount-method-microsoft-web-media-transformmanager.md)|Sets the task count for the local scheduler by using the specified job and task count. (Overrides [Scheduler.SetTaskCount(String, Int32)](scheduler-settaskcount-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskIndex](localscheduler-settaskindex-method-microsoft-web-media-transformmanager.md)|Sets the index of a task for the local scheduler. (Overrides [Scheduler.SetTaskIndex(String, Int32)](scheduler-settaskindex-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[StartJob](localscheduler-startjob-method-microsoft-web-media-transformmanager.md)|Starts the specified job using the local scheduler. (Overrides [Scheduler.StartJob(String)](scheduler-startjob-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SubmitJob](localscheduler-submitjob-method-microsoft-web-media-transformmanager.md)|Submits a job manifest to the local scheduler. (Overrides [Scheduler.SubmitJob(JobManifest)](scheduler-submitjob-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateJobProgress](localscheduler-updatejobprogress-method-microsoft-web-media-transformmanager.md)|Updates the percentage complete of the specified job. (Overrides [Scheduler.UpdateJobProgress(String, Int32)](scheduler-updatejobprogress-method-microsoft-web-media-transformmanager.md).)|

## Remarks

The local scheduler implements a set of methods for starting, stopping, and reporting progress of a job. The local scheduler uses the Windows Task Scheduler on the local computer to schedule jobs.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
