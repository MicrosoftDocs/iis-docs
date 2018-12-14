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
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# Scheduler Class

Schedules IIS Transform Manager jobs.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..Scheduler  
    [Microsoft.Web.Media.TransformManager. . :: . .HpcScheduler](hpcscheduler-class-microsoft-web-media-transformmanager.md)  
    [Microsoft.Web.Media.TransformManager. . :: . .LocalScheduler](localscheduler-class-microsoft-web-media-transformmanager.md)  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicMustInheritClassScheduler
'Usage
DiminstanceAsScheduler
```

``` csharp
publicabstractclassScheduler
```

``` c++
publicref classSchedulerabstract
```

``` fsharp
[<AbstractClassAttribute>]
typeScheduler =  classend
```

``` jscript
publicabstractclass Scheduler
```

The Scheduler type exposes the following members.

## Constructors

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="scheduler-constructor-microsoft-web-media-transformmanager.md">Scheduler</a></td>
<td>Initializes a new instance of the Scheduler class.</td>
</tr>
</tbody>
</table>


Top

## Methods

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-canceljob-method-microsoft-web-media-transformmanager.md">CancelJob</a></td>
<td>Cancels the specified job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-cleanupjob-method-microsoft-web-media-transformmanager.md">CleanupJob</a></td>
<td>Removes scheduler artifacts for the specified job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-cleanupworkfolder-method-microsoft-web-media-transformmanager.md">CleanupWorkFolder</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-connect-method-microsoft-web-media-transformmanager.md">Connect</a></td>
<td>Connects to the scheduler.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-dispose-method-microsoft-web-media-transformmanager.md">Dispose</a></td>
<td>Releases all resources that are used by the current instance of the Scheduler class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-getjobcompletiondetails-method-microsoft-web-media-transformmanager.md">GetJobCompletionDetails</a></td>
<td>Returns a report about the specified job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-getjobstatus-method-microsoft-web-media-transformmanager.md">GetJobStatus</a></td>
<td>Returns the status of the specified job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-getrunningjobs-method-microsoft-web-media-transformmanager.md">GetRunningJobs</a></td>
<td>Returns a list of job instance IDs for jobs that are running.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-gettaskchildprocessid-method-microsoft-web-media-transformmanager.md">GetTaskChildProcessId</a></td>
<td>Returns the ID of the child process of an executable program by using the specified job instance ID.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-gettaskprogress-method-microsoft-web-media-transformmanager.md">GetTaskProgress</a></td>
<td>Returns task progress for the specified job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-initialize-method-microsoft-web-media-transformmanager.md">Initialize</a></td>
<td>Sets the properties for this scheduler instance.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-setlogwriter-method-microsoft-web-media-transformmanager.md">SetLogWriter</a></td>
<td>Sets the <a href="logger-class-microsoft-web-media-transformmanager.md">Logger</a> object for the scheduler.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-settaskchildprocessid-method-microsoft-web-media-transformmanager.md">SetTaskChildProcessId</a></td>
<td>Sets the ID of the child process of an executable program by using the specified job instance ID and child process ID.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-settaskcount-method-microsoft-web-media-transformmanager.md">SetTaskCount</a></td>
<td>Sets the task count for the specified job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-settaskindex-method-microsoft-web-media-transformmanager.md">SetTaskIndex</a></td>
<td>Sets the index of a task for the scheduler by using the specified job and task index.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-startjob-method-microsoft-web-media-transformmanager.md">StartJob</a></td>
<td>Starts the specified job using the scheduler.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-submitjob-method-microsoft-web-media-transformmanager.md">SubmitJob</a></td>
<td>Submits the job to the scheduler.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="scheduler-updatejobprogress-method-microsoft-web-media-transformmanager.md">UpdateJobProgress</a></td>
<td>Updates the progress of the specified job.</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

