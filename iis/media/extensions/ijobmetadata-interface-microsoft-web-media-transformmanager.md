---
title: IJobMetadata Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: IJobMetadata Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.IJobMetadata
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmetadata(v=VS.90)
ms:contentKeyID: 35520802
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IJobMetadata Interface

Represents an interface that defines an object that is passed to the task through the [Initialize(ITaskStatus, IJobMetadata, ILogger)](itask-initialize-method-microsoft-web-media-transformmanager.md) method of the [ITask](itask-interface-microsoft-web-media-transformmanager.md) class.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicInterfaceIJobMetadata
'Usage
DiminstanceAsIJobMetadata
```

``` csharp
publicinterfaceIJobMetadata
```

``` c++
publicinterface classIJobMetadata
```

``` fsharp
typeIJobMetadata =  interfaceend
```

``` jscript
publicinterface IJobMetadata
```

The IJobMetadata type exposes the following members.

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
<td><a href="ijobmetadata-inputfolder-property-microsoft-web-media-transformmanager.md">InputFolder</a></td>
<td>Gets the name of the input folder for the job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="ijobmetadata-instancefileismanifest-property-microsoft-web-media-transformmanager.md">InstanceFileIsManifest</a></td>
<td>Gets a value that indicates whether the instance file is a manifest file.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="ijobmetadata-instancefilename-property-microsoft-web-media-transformmanager.md">InstanceFileName</a></td>
<td>Gets the instance file name.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="ijobmetadata-manifest-property-microsoft-web-media-transformmanager.md">Manifest</a></td>
<td>Gets the full job manifest from the synchronized multimedia interface language (SMIL) manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="ijobmetadata-outputfolder-property-microsoft-web-media-transformmanager.md">OutputFolder</a></td>
<td>Gets the name of the output folder for completed jobs.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="ijobmetadata-processpriority-property-microsoft-web-media-transformmanager.md">ProcessPriority</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="ijobmetadata-status-property-microsoft-web-media-transformmanager.md">Status</a></td>
<td>Gets or sets the status of an ongoing transform.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="ijobmetadata-taskelement-property-microsoft-web-media-transformmanager.md">TaskElement</a></td>
<td>Gets the task element from the manifest.</td>
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
<td><a href="ijobmetadata-getproperty-method-microsoft-web-media-transformmanager.md">GetProperty</a></td>
<td>Returns the value of the specified property from the task resource description framework (RDF) metadata section in the manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="ijobmetadata-setproperty-method-microsoft-web-media-transformmanager.md">SetProperty</a></td>
<td>Sets a property value in the task resource description framework (RDF) metadata section in the manifest.</td>
</tr>
</tbody>
</table>


Top

## Remarks

This object contains the metadata that is required by the task. The [SetProperty(IManifestProperty)](ijobmetadata-setproperty-method-microsoft-web-media-transformmanager.md) and [GetProperty(XName)](ijobmetadata-getproperty-method-microsoft-web-media-transformmanager.md) methods can access metadata that is stored in the task resource description framework (RDF) metadata section in the manifest. The [TaskMetadata](jobmetadata-taskmetadata-property-microsoft-web-media-transformmanager.md) property provides read-only access to the task-specific metadata that was provided in the synchronized multimedia interface language (SMIL) manifest, which simplifies access to the task metadata stored in the manifest. This same metadata can also be accessed by reading the [Manifest](ijobmetadata-manifest-property-microsoft-web-media-transformmanager.md) property.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

