---
title: HpcScheduler Class (Microsoft.Web.Media.TransformManager)
TOCTitle: HpcScheduler Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.HpcScheduler
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.hpcscheduler(v=VS.90)
ms:contentKeyID: 35520924
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# HpcScheduler Class

Manages IIS Transform Manager jobs that are run on a High Performance Computing (HPC) computer cluster.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  [Microsoft.Web.Media.TransformManager.Scheduler](scheduler-class-microsoft-web-media-transformmanager.md)  
    Microsoft.Web.Media.TransformManager..::..HpcScheduler  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Class HpcScheduler _
    Inherits Scheduler _
    Implements IDisposable
'Usage

  Dim instance As HpcScheduler
```

```csharp
  public class HpcScheduler : Scheduler,
    IDisposable
```

```cpp
  public ref class HpcScheduler : public Scheduler,
    IDisposable
```

``` fsharp
  type HpcScheduler =  
    class
        inherit Scheduler
        interface IDisposable
    end
```

```jscript
  public class HpcScheduler extends Scheduler implements IDisposable
```

The HpcScheduler type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[HpcScheduler](hpcscheduler-constructor-microsoft-web-media-transformmanager.md)|Initializes a new instance of the HpcScheduler class.|

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TestConnectionMessage](hpcscheduler-testconnectionmessage-property-microsoft-web-media-transformmanager.md)|Gets the connection message.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CancelJob](hpcscheduler-canceljob-method-microsoft-web-media-transformmanager.md)|Cancels the job. (Overrides [Scheduler.CancelJob(String)](scheduler-canceljob-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CleanupJob](hpcscheduler-cleanupjob-method-microsoft-web-media-transformmanager.md)|Cleans up scheduler data structure artifacts. (Overrides [Scheduler.CleanupJob(String)](scheduler-cleanupjob-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CleanupWorkFolder](hpcscheduler-cleanupworkfolder-method-microsoft-web-media-transformmanager.md)|(Overrides [Scheduler.CleanupWorkFolder(String)](scheduler-cleanupworkfolder-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Connect](hpcscheduler-connect-method-microsoft-web-media-transformmanager.md)|Connects to the HPC scheduler. (Overrides [Scheduler.Connect(String)](scheduler-connect-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Dispose() () () ()](hpcscheduler-dispose-method-microsoft-web-media-transformmanager_1.md)|Releases all resources used by the HPC scheduler instance. (Overrides [Scheduler.Dispose() () () ()](scheduler-dispose-method-microsoft-web-media-transformmanager.md).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Dispose(Boolean)](hpcscheduler-dispose-method-boolean-microsoft-web-media-transformmanager.md)|Releases all resources used by the HPC scheduler and optionally releases the managed resources.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobCompletionDetails](hpcscheduler-getjobcompletiondetails-method-microsoft-web-media-transformmanager.md)|Returns a report about the job instance. (Overrides [Scheduler.GetJobCompletionDetails(String)](scheduler-getjobcompletiondetails-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobStatus](hpcscheduler-getjobstatus-method-microsoft-web-media-transformmanager.md)|Returns the status of a job. (Overrides [Scheduler.GetJobStatus(String)](scheduler-getjobstatus-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetRunningJobs](hpcscheduler-getrunningjobs-method-microsoft-web-media-transformmanager.md)|Returns a list of job instance IDs based on the currently running jobs. (Overrides [Scheduler.GetRunningJobs() () () ()](scheduler-getrunningjobs-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetTaskChildProcessId](hpcscheduler-gettaskchildprocessid-method-microsoft-web-media-transformmanager.md)|Returns the child process ID of a task. (Overrides [Scheduler.GetTaskChildProcessId(String)](scheduler-gettaskchildprocessid-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetTaskProgress](hpcscheduler-gettaskprogress-method-microsoft-web-media-transformmanager.md)|Returns the percentage complete for the specified job. (Overrides [Scheduler.GetTaskProgress(String)](scheduler-gettaskprogress-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Initialize](hpcscheduler-initialize-method-microsoft-web-media-transformmanager.md)|Sets the name, priority, and properties for this scheduler instance. (Overrides [Scheduler.Initialize(String, Credential, String, Int32, Dictionary< (Of < <' (String, String> ) > > ))](scheduler-initialize-method-microsoft-web-media-transformmanager.md).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetCredential](hpcscheduler-setcredential-method-microsoft-web-media-transformmanager.md)|Sets the [Credential](credential-class-microsoft-web-media-transformmanager.md) object that is required in order to access HPC scheduler resources.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetLogWriter](hpcscheduler-setlogwriter-method-microsoft-web-media-transformmanager.md)|Sets the logger object for the HPC scheduler. (Overrides [Scheduler.SetLogWriter(Logger)](scheduler-setlogwriter-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskChildProcessId](hpcscheduler-settaskchildprocessid-method-microsoft-web-media-transformmanager.md)|Sets the child process ID of a child task that is an executable program for the HPC scheduler. (Overrides [Scheduler.SetTaskChildProcessId(String, Int32)](scheduler-settaskchildprocessid-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskCount](hpcscheduler-settaskcount-method-microsoft-web-media-transformmanager.md)|Sets the task count of the HPC scheduler by using the specified job and task count. (Overrides [Scheduler.SetTaskCount(String, Int32)](scheduler-settaskcount-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetTaskIndex](hpcscheduler-settaskindex-method-microsoft-web-media-transformmanager.md)|Sets the index of a task for the HPC scheduler. (Overrides [Scheduler.SetTaskIndex(String, Int32)](scheduler-settaskindex-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[StartJob](hpcscheduler-startjob-method-microsoft-web-media-transformmanager.md)|Starts the specified job using the HPC scheduler. (Overrides [Scheduler.StartJob(String)](scheduler-startjob-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SubmitJob](hpcscheduler-submitjob-method-microsoft-web-media-transformmanager.md)|Submits a job manifest to the HPC scheduler. (Overrides [Scheduler.SubmitJob(JobManifest)](scheduler-submitjob-method-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[TestConnection](hpcscheduler-testconnection-method-microsoft-web-media-transformmanager.md)|Tests connectivity of the IIS Transform Manager service to the HpcScheduler object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateJobProgress](hpcscheduler-updatejobprogress-method-microsoft-web-media-transformmanager.md)|Sets the percentage complete of the specified job. (Overrides [Scheduler.UpdateJobProgress(String, Int32)](scheduler-updatejobprogress-method-microsoft-web-media-transformmanager.md).)|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
