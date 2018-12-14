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
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# TaskStatus Class

Provides a status callback mechanism for the task.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..TaskStatus  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicClassTaskStatus _
    ImplementsITaskStatus, IDisposable
'Usage
DiminstanceAsTaskStatus
```

``` csharp
publicclassTaskStatus : ITaskStatus, IDisposable
```

``` c++
publicref classTaskStatus : ITaskStatus, 
    IDisposable
```

``` fsharp
typeTaskStatus =  
    classinterfaceITaskStatusinterfaceIDisposableend
```

``` jscript
publicclass TaskStatus implementsITaskStatus, IDisposable
```

The TaskStatus type exposes the following members.

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
<td><a href="taskstatus-constructor-microsoft-web-media-transformmanager.md">TaskStatus</a></td>
<td>Initializes a new instance of the TaskStatus class by using the specified manifest and logger.</td>
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
<td><a href="taskstatus-message-property-microsoft-web-media-transformmanager.md">Message</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskstatus-percentcomplete-property-microsoft-web-media-transformmanager.md">PercentComplete</a></td>
<td>Gets the percentage of task completion.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskstatus-status-property-microsoft-web-media-transformmanager.md">Status</a></td>
<td>Gets the status of the task.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskstatus-taskchildprocessid-property-microsoft-web-media-transformmanager.md">TaskChildProcessId</a></td>
<td>Gets the ID of the child process of the task.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskstatus-taskcount-property-microsoft-web-media-transformmanager.md">TaskCount</a></td>
<td>Gets the task count.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskstatus-taskindex-property-microsoft-web-media-transformmanager.md">TaskIndex</a></td>
<td>Gets the task index.</td>
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
<td><a href="taskstatus-dispose-method-microsoft-web-media-transformmanager_1.md">Dispose() () () ()</a></td>
<td>Disposes task resources.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="taskstatus-dispose-method-boolean-microsoft-web-media-transformmanager.md">Dispose(Boolean)</a></td>
<td>Disposes task resources and optionally releases the managed resources.</td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="taskstatus-settaskchildprocessid-method-microsoft-web-media-transformmanager.md">SetTaskChildProcessId</a></td>
<td>Sets the ID of the child process of the task.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="taskstatus-settaskcount-method-microsoft-web-media-transformmanager.md">SetTaskCount</a></td>
<td>Sets the number of tasks to be performed by the scheduler.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="taskstatus-settaskindex-method-microsoft-web-media-transformmanager.md">SetTaskIndex</a></td>
<td>Sets the index of the task to be performed by the scheduler.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="taskstatus-updatestatus-method-microsoft-web-media-transformmanager.md">UpdateStatus</a></td>
<td>Updates the status to an ongoing task by using the specified percentage complete, status, and message.</td>
</tr>
</tbody>
</table>


Top

## Remarks

Task status is reported back through the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object. Initialize this object using a manifest that contains scheduler information. Each task will be passed an object that implements this interface through dependency injection.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

