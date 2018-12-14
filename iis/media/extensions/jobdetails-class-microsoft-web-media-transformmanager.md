---
title: JobDetails Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobDetails Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobDetails
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails(v=VS.90)
ms:contentKeyID: 35520812
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobDetails Class

Provides details about an IIS Transform Manager job.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..JobDetails  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<SerializableAttribute> _
<DataContractAttribute> _
PublicClassJobDetails
'Usage
DiminstanceAsJobDetails
```

``` csharp
[SerializableAttribute]
[DataContractAttribute]
publicclassJobDetails
```

``` c++
[SerializableAttribute]
[DataContractAttribute]
publicref classJobDetails
```

``` fsharp
[<SerializableAttribute>]
[<DataContractAttribute>]
typeJobDetails =  classend
```

``` jscript
publicclass JobDetails
```

The JobDetails type exposes the following members.

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
<td><a href="jobdetails-endtime-property-microsoft-web-media-transformmanager.md">EndTime</a></td>
<td>Gets or sets the time when the job ended.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-folder-property-microsoft-web-media-transformmanager.md">Folder</a></td>
<td>Gets or sets the root folder of the <a href="jobmanager-class-microsoft-web-media-transformmanager.md">JobManager</a> object that is processing the job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-instancefilename-property-microsoft-web-media-transformmanager.md">InstanceFileName</a></td>
<td>Gets or sets the name of the file that matched the file watcher filter and that instantiated the job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-jobdefinitionid-property-microsoft-web-media-transformmanager.md">JobDefinitionId</a></td>
<td>Gets or sets the ID of the <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> object that created this job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-jobdefinitionname-property-microsoft-web-media-transformmanager.md">JobDefinitionName</a></td>
<td>Gets or sets the name of the <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> object that created this job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-jobname-property-microsoft-web-media-transformmanager.md">JobName</a></td>
<td>Gets or set the name of this job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-jobschedulerid-property-microsoft-web-media-transformmanager.md">JobSchedulerId</a></td>
<td>Gets or sets the ID of the <a href="jobscheduler-class-microsoft-web-media-transformmanager.md">JobScheduler</a> object that runs this job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-jobschedulername-property-microsoft-web-media-transformmanager.md">JobSchedulerName</a></td>
<td>Gets or sets the name of the job scheduler that runs this job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-jobtemplateid-property-microsoft-web-media-transformmanager.md">JobTemplateId</a></td>
<td>Gets or sets the ID of the job template that defines the tasks for this job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-jobtemplatename-property-microsoft-web-media-transformmanager.md">JobTemplateName</a></td>
<td>Gets or sets the name of the job template that defines the tasks for this job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-logfolder-property-microsoft-web-media-transformmanager.md">LogFolder</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-manifestname-property-microsoft-web-media-transformmanager.md">ManifestName</a></td>
<td>Gets or sets the name of the manifest file that defines this job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-priority-property-microsoft-web-media-transformmanager.md">Priority</a></td>
<td>Gets or sets the priority of the job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-progress-property-microsoft-web-media-transformmanager.md">Progress</a></td>
<td>Gets or sets the percentage complete of the job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-queuetime-property-microsoft-web-media-transformmanager.md">QueueTime</a></td>
<td>Gets or sets the date and time when the job was added to the work queue.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-starttime-property-microsoft-web-media-transformmanager.md">StartTime</a></td>
<td>Gets or sets the date and time when the job was started by the scheduler.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-status-property-microsoft-web-media-transformmanager.md">Status</a></td>
<td>Gets or sets the status of the job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-statusstring-property-microsoft-web-media-transformmanager.md">StatusString</a></td>
<td>Gets a string representation of the status.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-submittime-property-microsoft-web-media-transformmanager.md">SubmitTime</a></td>
<td>Gets or sets the time that the job was submitted to the scheduler.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-taskcount-property-microsoft-web-media-transformmanager.md">TaskCount</a></td>
<td>Gets or sets the number of tasks that are in this job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdetails-taskindex-property-microsoft-web-media-transformmanager.md">TaskIndex</a></td>
<td>Gets or sets the index of the current task.</td>
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
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-createworkitem-method-microsoft-web-media-transformmanager.md">CreateWorkItem</a></td>
<td>Creates a JobDetails object that defines a work item based on the specified job manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-createworkitemelement-method-microsoft-web-media-transformmanager.md">CreateWorkItemElement</a></td>
<td>Creates an XML element based on the specified JobDetails object that defines a work item.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-createworkitemfromxelement-method-microsoft-web-media-transformmanager.md">CreateWorkItemFromXElement</a></td>
<td>Creates a JobDetails object that defines a work item using the specified XML element.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="jobdetails-expandjobdetailselement-method-microsoft-web-media-transformmanager.md">ExpandJobDetailsElement</a></td>
<td>Creates an XML element from a JobDetails object that defines a work item.</td>
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
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-getjobdetailsattribute-method-microsoft-web-media-transformmanager.md">GetJobDetailsAttribute</a></td>
<td>Returns the attribute name of a JobDetails object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-statusfromstring-method-microsoft-web-media-transformmanager.md">StatusFromString</a></td>
<td>Returns a <a href="jobstatus-enumeration-microsoft-web-media-transformmanager.md">JobStatus</a> object that corresponds to the specified status string.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Fields

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
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsendtime-field-microsoft-web-media-transformmanager.md">JobDetailsEndTime</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;endTime&quot; field.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsfolder-field-microsoft-web-media-transformmanager.md">JobDetailsFolder</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;folder&quot; field.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsid-field-microsoft-web-media-transformmanager.md">JobDetailsId</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;id&quot; field.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsinstancefilename-field-microsoft-web-media-transformmanager.md">JobDetailsInstanceFileName</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;instanceFileName&quot; field.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsjobdefinitionid-field-microsoft-web-media-transformmanager.md">JobDetailsJobDefinitionId</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;jobDefinitionId&quot; field.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsjobname-field-microsoft-web-media-transformmanager.md">JobDetailsJobName</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;jobName&quot; field.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsjobtemplateid-field-microsoft-web-media-transformmanager.md">JobDetailsJobTemplateId</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;jobTemplateId&quot; field.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailslogfolder-field-microsoft-web-media-transformmanager.md">JobDetailsLogFolder</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsmanifestname-field-microsoft-web-media-transformmanager.md">JobDetailsManifestName</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;manifestName&quot; field.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailspriority-field-microsoft-web-media-transformmanager.md">JobDetailsPriority</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;priority&quot; field.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsprogress-field-microsoft-web-media-transformmanager.md">JobDetailsProgress</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;progress&quot; field.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsqueuetime-field-microsoft-web-media-transformmanager.md">JobDetailsQueueTime</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;queueTime&quot; field.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsroot-field-microsoft-web-media-transformmanager.md">JobDetailsRoot</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;workItem&quot; field.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsschedulerid-field-microsoft-web-media-transformmanager.md">JobDetailsSchedulerId</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;jobSchedulerId&quot; field.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsstarttime-field-microsoft-web-media-transformmanager.md">JobDetailsStartTime</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;startTime&quot; field.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailsstatus-field-microsoft-web-media-transformmanager.md">JobDetailsStatus</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;status&quot; field.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailssubmittime-field-microsoft-web-media-transformmanager.md">JobDetailsSubmitTime</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;submitTime&quot; field.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailstaskcount-field-microsoft-web-media-transformmanager.md">JobDetailsTaskCount</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;taskCount&quot; field.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdetails-jobdetailstaskindex-field-microsoft-web-media-transformmanager.md">JobDetailsTaskIndex</a></td>
<td>Represents a constant that is used when transform jobs are sorted by the &quot;taskIndex&quot; field.</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

