---
title: JobManifest Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobManifest Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobManifest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest(v=VS.90)
ms:contentKeyID: 35521078
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobManifest Class

Provides capabilities to manipulate job-instance metadata.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..JobManifest  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicClassJobManifest _
    ImplementsIJobManifest
'Usage
DiminstanceAsJobManifest
```

``` csharp
publicclassJobManifest : IJobManifest
```

``` c++
publicref classJobManifest : IJobManifest
```

``` fsharp
typeJobManifest =  
    classinterfaceIJobManifestend
```

``` jscript
publicclass JobManifest implementsIJobManifest
```

The JobManifest type exposes the following members.

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
<td><a href="jobmanifest-constructor-microsoft-web-media-transformmanager.md">JobManifest</a></td>
<td>Initializes a new instance of the JobManifest class.</td>
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
<td><a href="jobmanifest-arguments-property-microsoft-web-media-transformmanager.md">Arguments</a></td>
<td>Gets executable program task arguments that are associated with the data in the manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-filename-property-microsoft-web-media-transformmanager.md">FileName</a></td>
<td>Gets or sets the file name of the manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-folder-property-microsoft-web-media-transformmanager.md">Folder</a></td>
<td>Gets or sets the folder name of the manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-fullfilename-property-microsoft-web-media-transformmanager.md">FullFileName</a></td>
<td>Gets the folder name and file name of the manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-inputfilenames-property-microsoft-web-media-transformmanager.md">InputFileNames</a></td>
<td>Gets a collection of input file names for a job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-instancefileismanifest-property-microsoft-web-media-transformmanager.md">InstanceFileIsManifest</a></td>
<td>Gets a value that indicates whether the file that initiates job creation is a SMIL 2.0-compliant manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-instancefilename-property-microsoft-web-media-transformmanager.md">InstanceFileName</a></td>
<td>Gets or sets the file name of the manifest instance.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-instanceid-property-microsoft-web-media-transformmanager.md">InstanceId</a></td>
<td>Gets or sets the ID of the manifest instance.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-jobdefinitionid-property-microsoft-web-media-transformmanager.md">JobDefinitionId</a></td>
<td>Gets the ID of the job definition.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-jobdefinitionname-property-microsoft-web-media-transformmanager.md">JobDefinitionName</a></td>
<td>Gets the name of the job definition from the job manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-jobdetails-property-microsoft-web-media-transformmanager.md">JobDetails</a></td>
<td>Gets a <a href="jobdetails-class-microsoft-web-media-transformmanager.md">JobDetails</a> object that is based on details from the job manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-logfolder-property-microsoft-web-media-transformmanager.md">LogFolder</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-manifestasstring-property-microsoft-web-media-transformmanager.md">ManifestAsString</a></td>
<td>Gets the manifest XML content.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-name-property-microsoft-web-media-transformmanager.md">Name</a></td>
<td>Gets or sets the name of the job manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-priority-property-microsoft-web-media-transformmanager.md">Priority</a></td>
<td>Gets the priority of a job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-processpriority-property-microsoft-web-media-transformmanager.md">ProcessPriority</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-programs-property-microsoft-web-media-transformmanager.md">Programs</a></td>
<td>Gets a collection of tasks that are executable program files.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-rawmanifest-property-microsoft-web-media-transformmanager.md">RawManifest</a></td>
<td>Gets the manifest XML content.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-status-property-microsoft-web-media-transformmanager.md">Status</a></td>
<td>Gets or sets the status value from the manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-taskindex-property-microsoft-web-media-transformmanager.md">TaskIndex</a></td>
<td>Gets or sets the task index value from the task index element.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-template-property-microsoft-web-media-transformmanager.md">Template</a></td>
<td>Gets an XML element that contains a set of sequential tasks that define a job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-workfolder-property-microsoft-web-media-transformmanager.md">WorkFolder</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmanifest-workqueueroot-property-microsoft-web-media-transformmanager.md">WorkQueueRoot</a></td>
<td>Gets the root work folder name.</td>
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
<td><a href="jobmanifest-createmanifest-method-microsoft-web-media-transformmanager.md">CreateManifest</a></td>
<td>Creates a JobManifest object by using the job definition, the root work folder name, scheduling information about a job, tasks that define a job, shared properties, the name of the file that is used to create the manifest, and the ID of the manifest instance.</td>
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
<td><a href="jobmanifest-findjobelement-method-microsoft-web-media-transformmanager.md">FindJobElement</a></td>
<td>Returns the XML job element from the manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobmanifest-getinputfilenames-method-microsoft-web-media-transformmanager.md">GetInputFileNames</a></td>
<td>Returns a collection of input file names.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobmanifest-getmanifestelement-method-microsoft-web-media-transformmanager.md">GetManifestElement</a></td>
<td>Returns an XML representation of the manifest metadata.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="jobmanifest-getmetadatafortask-method-microsoft-web-media-transformmanager.md">GetMetadataForTask</a></td>
<td>Returns the metadata for the specified task.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="jobmanifest-getscheduler-method-microsoft-web-media-transformmanager.md">GetScheduler</a></td>
<td>Creates and returns a new <a href="scheduler-class-microsoft-web-media-transformmanager.md">Scheduler</a> object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="jobmanifest-getschedulerinfo-method-microsoft-web-media-transformmanager.md">GetSchedulerInfo</a></td>
<td>Returns scheduling information about a job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="jobmanifest-initialize-method-microsoft-web-media-transformmanager.md">Initialize</a></td>
<td>Initializes member variables for a manifest that is loaded from disk instead of created as part of job submission.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobmanifest-loadmanifest-method-microsoft-web-media-transformmanager.md">LoadManifest</a></td>
<td>Loads the manifest file.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="jobmanifest-save-method-microsoft-web-media-transformmanager.md">Save</a></td>
<td>Saves a job manifest file.</td>
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
<td><a href="jobmanifest-manifestextension-field-microsoft-web-media-transformmanager.md">ManifestExtension</a></td>
<td>Represents a constant that is used as the job manifest file extension (&quot;.smil&quot;).</td>
</tr>
</tbody>
</table>


Top

## Remarks

The job manifest holds the information about a job instance. The job manifest is a .smil file that conforms to the Synchronized Multimedia Integration Language (SMIL). It contains a body section that lists all of the files that triggered the job. The job manifest also contains Resource Description Framework (RDF) metadata in a head section that describes the job definition, job scheduler, and job template. This metadata is combined with the input files to create the manifest for a job. The manifest constitutes the instructions that a scheduler requires in order to create, run, and report on the job.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

