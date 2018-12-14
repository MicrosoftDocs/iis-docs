---
title: HpcScheduler Class (Microsoft.Web.Media.TransformManager)
TOCTitle: HpcScheduler Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.HpcScheduler
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler(v=VS.90)
ms:contentKeyID: 35520924
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# HpcScheduler Class

Manages IIS Transform Manager jobs that are run on a High Performance Computing (HPC) computer cluster.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [Microsoft.Web.Media.TransformManager. . :: . .Scheduler](scheduler-class-microsoft-web-media-transformmanager.md)  
    Microsoft.Web.Media.TransformManager..::..HpcScheduler  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicClassHpcScheduler _
    InheritsScheduler _
    ImplementsIDisposable
'Usage
DiminstanceAsHpcScheduler
```

``` csharp
publicclassHpcScheduler : Scheduler, 
    IDisposable
```

``` c++
publicref classHpcScheduler : publicScheduler, 
    IDisposable
```

``` fsharp
typeHpcScheduler =  
    classinheritSchedulerinterfaceIDisposableend
```

``` jscript
publicclass HpcScheduler extendsSchedulerimplementsIDisposable
```

The HpcScheduler type exposes the following members.

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
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-constructor-microsoft-web-media-transformmanager.md">HpcScheduler</a></td>
<td>Initializes a new instance of the HpcScheduler class.</td>
</tr>
</tbody>
</table>


Top

## Properties

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
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="hpcscheduler-testconnectionmessage-property-microsoft-web-media-transformmanager.md">TestConnectionMessage</a></td>
<td>Gets the connection message.</td>
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
<td><a href="hpcscheduler-canceljob-method-microsoft-web-media-transformmanager.md">CancelJob</a></td>
<td>Cancels the job. (Overrides <a href="scheduler-canceljob-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .CancelJob(String)</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-cleanupjob-method-microsoft-web-media-transformmanager.md">CleanupJob</a></td>
<td>Cleans up scheduler data structure artifacts. (Overrides <a href="scheduler-cleanupjob-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .CleanupJob(String)</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-cleanupworkfolder-method-microsoft-web-media-transformmanager.md">CleanupWorkFolder</a></td>
<td>(Overrides <a href="scheduler-cleanupworkfolder-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .CleanupWorkFolder(String)</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-connect-method-microsoft-web-media-transformmanager.md">Connect</a></td>
<td>Connects to the HPC scheduler. (Overrides <a href="scheduler-connect-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .Connect(String)</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-dispose-method-microsoft-web-media-transformmanager_1.md">Dispose() () () ()</a></td>
<td>Releases all resources used by the HPC scheduler instance. (Overrides <a href="scheduler-dispose-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .Dispose() () () ()</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="hpcscheduler-dispose-method-boolean-microsoft-web-media-transformmanager.md">Dispose(Boolean)</a></td>
<td>Releases all resources used by the HPC scheduler and optionally releases the managed resources.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-getjobcompletiondetails-method-microsoft-web-media-transformmanager.md">GetJobCompletionDetails</a></td>
<td>Returns a report about the job instance. (Overrides <a href="scheduler-getjobcompletiondetails-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .GetJobCompletionDetails(String)</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-getjobstatus-method-microsoft-web-media-transformmanager.md">GetJobStatus</a></td>
<td>Returns the status of a job. (Overrides <a href="scheduler-getjobstatus-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .GetJobStatus(String)</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-getrunningjobs-method-microsoft-web-media-transformmanager.md">GetRunningJobs</a></td>
<td>Returns a list of job instance IDs based on the currently running jobs. (Overrides <a href="scheduler-getrunningjobs-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .GetRunningJobs() () () ()</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-gettaskchildprocessid-method-microsoft-web-media-transformmanager.md">GetTaskChildProcessId</a></td>
<td>Returns the child process ID of a task. (Overrides <a href="scheduler-gettaskchildprocessid-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .GetTaskChildProcessId(String)</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-gettaskprogress-method-microsoft-web-media-transformmanager.md">GetTaskProgress</a></td>
<td>Returns the percentage complete for the specified job. (Overrides <a href="scheduler-gettaskprogress-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .GetTaskProgress(String)</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-initialize-method-microsoft-web-media-transformmanager.md">Initialize</a></td>
<td>Sets the name, priority, and properties for this scheduler instance. (Overrides <a href="scheduler-initialize-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .Initialize(String, Credential, String, Int32, Dictionary&lt; (Of &lt; &lt;' (String, String&gt; ) &gt; &gt; ))</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-setcredential-method-microsoft-web-media-transformmanager.md">SetCredential</a></td>
<td>Sets the <a href="credential-class-microsoft-web-media-transformmanager.md">Credential</a> object that is required in order to access HPC scheduler resources.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-setlogwriter-method-microsoft-web-media-transformmanager.md">SetLogWriter</a></td>
<td>Sets the logger object for the HPC scheduler. (Overrides <a href="scheduler-setlogwriter-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .SetLogWriter(Logger)</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-settaskchildprocessid-method-microsoft-web-media-transformmanager.md">SetTaskChildProcessId</a></td>
<td>Sets the child process ID of a child task that is an executable program for the HPC scheduler. (Overrides <a href="scheduler-settaskchildprocessid-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .SetTaskChildProcessId(String, Int32)</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-settaskcount-method-microsoft-web-media-transformmanager.md">SetTaskCount</a></td>
<td>Sets the task count of the HPC scheduler by using the specified job and task count. (Overrides <a href="scheduler-settaskcount-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .SetTaskCount(String, Int32)</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-settaskindex-method-microsoft-web-media-transformmanager.md">SetTaskIndex</a></td>
<td>Sets the index of a task for the HPC scheduler. (Overrides <a href="scheduler-settaskindex-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .SetTaskIndex(String, Int32)</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-startjob-method-microsoft-web-media-transformmanager.md">StartJob</a></td>
<td>Starts the specified job using the HPC scheduler. (Overrides <a href="scheduler-startjob-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .StartJob(String)</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-submitjob-method-microsoft-web-media-transformmanager.md">SubmitJob</a></td>
<td>Submits a job manifest to the HPC scheduler. (Overrides <a href="scheduler-submitjob-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .SubmitJob(JobManifest)</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-testconnection-method-microsoft-web-media-transformmanager.md">TestConnection</a></td>
<td>Tests connectivity of the IIS Transform Manager service to the HpcScheduler object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="hpcscheduler-updatejobprogress-method-microsoft-web-media-transformmanager.md">UpdateJobProgress</a></td>
<td>Sets the percentage complete of the specified job. (Overrides <a href="scheduler-updatejobprogress-method-microsoft-web-media-transformmanager.md">Scheduler. . :: . .UpdateJobProgress(String, Int32)</a>.)</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

