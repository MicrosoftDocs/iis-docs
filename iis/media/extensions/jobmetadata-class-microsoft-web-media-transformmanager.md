---
title: JobMetadata Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobMetadata Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobMetadata
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata(v=VS.90)
ms:contentKeyID: 35520790
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobMetadata Class

Defines an object that is passed to the task through the [Initialize(ITaskStatus, IJobMetadata, ILogger)](itask-initialize-method-microsoft-web-media-transformmanager.md) method of the [ITask](itask-interface-microsoft-web-media-transformmanager.md) class.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..JobMetadata  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicClassJobMetadata _
    ImplementsIJobMetadata
'Usage
DiminstanceAsJobMetadata
```

``` csharp
publicclassJobMetadata : IJobMetadata
```

``` c++
publicref classJobMetadata : IJobMetadata
```

``` fsharp
typeJobMetadata =  
    classinterfaceIJobMetadataend
```

``` jscript
publicclass JobMetadata implementsIJobMetadata
```

The JobMetadata type exposes the following members.

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
<td><a href="jobmetadata-constructor-microsoft-web-media-transformmanager.md">JobMetadata</a></td>
<td>Initializes a new instance of the JobMetadata class by using the specified manifest and task index.</td>
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
<td><a href="jobmetadata-inputfolder-property-microsoft-web-media-transformmanager.md">InputFolder</a></td>
<td>Gets the name of the input folder for the job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmetadata-instancefileismanifest-property-microsoft-web-media-transformmanager.md">InstanceFileIsManifest</a></td>
<td>Gets a value that indicates whether the instance file is a manifest file.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmetadata-instancefilename-property-microsoft-web-media-transformmanager.md">InstanceFileName</a></td>
<td>Gets the instance file name.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmetadata-jobmanifest-property-microsoft-web-media-transformmanager.md">JobManifest</a></td>
<td>Gets the job-specific metadata from the <a href="jobmanifest-class-microsoft-web-media-transformmanager.md">JobManifest</a> object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmetadata-manifest-property-microsoft-web-media-transformmanager.md">Manifest</a></td>
<td>Gets the manifest metadata from the synchronized multimedia interface language (SMIL) manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmetadata-outputfolder-property-microsoft-web-media-transformmanager.md">OutputFolder</a></td>
<td>Gets the name of the output folder for completed jobs.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmetadata-processpriority-property-microsoft-web-media-transformmanager.md">ProcessPriority</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmetadata-status-property-microsoft-web-media-transformmanager.md">Status</a></td>
<td>Gets or sets the status of an ongoing transform.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmetadata-successcodes-property-microsoft-web-media-transformmanager.md">SuccessCodes</a></td>
<td>Gets the success codes from the task element that is contained in the manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmetadata-taskcode-property-microsoft-web-media-transformmanager.md">TaskCode</a></td>
<td>Gets the task code from the task element that is contained in the manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmetadata-taskelement-property-microsoft-web-media-transformmanager.md">TaskElement</a></td>
<td>Gets the task element from the manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobmetadata-taskmetadata-property-microsoft-web-media-transformmanager.md">TaskMetadata</a></td>
<td>Gets the task metadata from the task element that is contained in the manifest.</td>
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
<td><a href="jobmetadata-getproperty-method-microsoft-web-media-transformmanager.md">GetProperty</a></td>
<td>Returns the value of the specified property from the task resource description framework (RDF) metadata section in the manifest.</td>
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
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="jobmetadata-setproperty-method-microsoft-web-media-transformmanager.md">SetProperty</a></td>
<td>Sets a property value in the task resource description framework (RDF) metadata section in the manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

