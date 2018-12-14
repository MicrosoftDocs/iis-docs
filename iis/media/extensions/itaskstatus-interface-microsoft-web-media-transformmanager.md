---
title: ITaskStatus Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: ITaskStatus Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.ITaskStatus
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.itaskstatus(v=VS.90)
ms:contentKeyID: 35520844
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ITaskStatus
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ITaskStatus
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ITaskStatus Interface

Defines an interface that is used to implement a status callback mechanism for the task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicInterfaceITaskStatus
'Usage
DiminstanceAsITaskStatus
```

``` csharp
publicinterfaceITaskStatus
```

``` c++
publicinterface classITaskStatus
```

``` fsharp
typeITaskStatus =  interfaceend
```

``` jscript
publicinterface ITaskStatus
```

The ITaskStatus type exposes the following members.

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
<td><a href="itaskstatus-message-property-microsoft-web-media-transformmanager.md">Message</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="itaskstatus-percentcomplete-property-microsoft-web-media-transformmanager.md">PercentComplete</a></td>
<td>Gets the percentage of task completion.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="itaskstatus-status-property-microsoft-web-media-transformmanager.md">Status</a></td>
<td>Gets the status of the task.</td>
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
<td><a href="itaskstatus-updatestatus-method-microsoft-web-media-transformmanager.md">UpdateStatus</a></td>
<td>Updates the status of an ongoing task.</td>
</tr>
</tbody>
</table>


Top

## Remarks

Task status is reported through the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object. Initialize this object with a manifest that contains scheduler information. Each task will be passed an object that implements this interface through dependency injection.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

