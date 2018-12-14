---
title: JobManager Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobManager Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobManager
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager(v=VS.90)
ms:contentKeyID: 35520677
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobManager Class

Processes IIS Transform Manager jobs.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..JobManager  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PermissionSetAttribute(SecurityAction.Demand, Name := "FullTrust")> _
PublicClassJobManager _
    ImplementsIDisposable
'Usage
DiminstanceAsJobManager
```

``` csharp
[PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")]
publicclassJobManager : IDisposable
```

``` c++
[PermissionSetAttribute(SecurityAction::Demand, Name = L"FullTrust")]
publicref classJobManager : IDisposable
```

``` fsharp
[<PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")>]
typeJobManager =  
    classinterfaceIDisposableend
```

``` jscript
publicclass JobManager implementsIDisposable
```

The JobManager type exposes the following members.

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
<td><a href="jobmanager-configuringjobs-property-microsoft-web-media-transformmanager.md">ConfiguringJobs</a></td>
<td>Gets a collection of job details that specify jobs that are being configured.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-credentialid-property-microsoft-web-media-transformmanager.md">CredentialId</a></td>
<td>Gets a GUID that identifies the credential that is associated with this job definition.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-enabled-property-microsoft-web-media-transformmanager.md">Enabled</a></td>
<td>Gets a value that indicates whether the job manager that is associated with this job definition can be started.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-id-property-microsoft-web-media-transformmanager.md">Id</a></td>
<td>Gets the XML element ID of the IIS Transform Manager configuration.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-inputfolderpath-property-microsoft-web-media-transformmanager.md">InputFolderPath</a></td>
<td>Gets the input folder name.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-inputismanifest-property-microsoft-web-media-transformmanager.md">InputIsManifest</a></td>
<td>Gets a value that indicates whether the file that initiates job creation is a SMIL 2.0-compliant manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-lastmodified-property-microsoft-web-media-transformmanager.md">LastModified</a></td>
<td>Gets the date and time when the IIS Transform Manager configuration was last modified.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-localfilewatcherfilter-property-microsoft-web-media-transformmanager.md">LocalFileWatcherFilter</a></td>
<td>Gets a file filter value that is used to initiate job creation.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-loglevel-property-microsoft-web-media-transformmanager.md">LogLevel</a></td>
<td>Gets a log level value that is contained in the log level element of the IIS Transform Manager configuration.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-name-property-microsoft-web-media-transformmanager.md">Name</a></td>
<td>Gets the XML element name of the IIS Transform Manager configuration.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-outputfolderpath-property-microsoft-web-media-transformmanager.md">OutputFolderPath</a></td>
<td>Gets the output folder for a job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-priority-property-microsoft-web-media-transformmanager.md">Priority</a></td>
<td>Gets the priority of a job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-runningjobs-property-microsoft-web-media-transformmanager.md">RunningJobs</a></td>
<td>Gets a collection of job details that specify jobs that are running.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-schedulerid-property-microsoft-web-media-transformmanager.md">SchedulerId</a></td>
<td>Gets the ID of the scheduler that is associated with this job definition.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-schedulerinfo-property-microsoft-web-media-transformmanager.md">SchedulerInfo</a></td>
<td>Gets scheduling information about the IIS Transform Manager job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-submittedjobs-property-microsoft-web-media-transformmanager.md">SubmittedJobs</a></td>
<td>Gets a collection of job details that specify jobs that have been submitted.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-template-property-microsoft-web-media-transformmanager.md">Template</a></td>
<td>Gets the job template that defines the tasks for this job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-templateid-property-microsoft-web-media-transformmanager.md">TemplateId</a></td>
<td>Gets the ID of the job template that the <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> object uses.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanager-watchfolder-property-microsoft-web-media-transformmanager.md">WatchFolder</a></td>
<td>Gets a file system folder that will be watched for files that instantiate jobs.</td>
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
<td><a href="jobmanager-dispose-method-microsoft-web-media-transformmanager_1.md">Dispose() () () ()</a></td>
<td>Releases all resources that are used by the current instance of the JobManager class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="jobmanager-dispose-method-boolean-microsoft-web-media-transformmanager.md">Dispose(Boolean)</a></td>
<td>Releases unmanaged resources and optionally releases managed resources.</td>
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
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="jobmanager-onshutdowncomplete-method-microsoft-web-media-transformmanager.md">OnShutdownComplete</a></td>
<td>Raises the <a href="jobmanager-shutdowncomplete-event-microsoft-web-media-transformmanager.md">ShutdownComplete</a> event.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Events

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
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="jobmanager-shutdowncomplete-event-microsoft-web-media-transformmanager.md">ShutdownComplete</a></td>
<td>Occurs when all transform jobs have been processed.</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

