---
title: IJobManifest Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: IJobManifest Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.IJobManifest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmanifest(v=VS.90)
ms:contentKeyID: 35521191
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobManifest
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IJobManifest Interface

Represents an interface that retrieves job scheduler information.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicInterfaceIJobManifest
'Usage
DiminstanceAsIJobManifest
```

``` csharp
publicinterfaceIJobManifest
```

``` c++
publicinterface classIJobManifest
```

``` fsharp
typeIJobManifest =  interfaceend
```

``` jscript
publicinterface IJobManifest
```

The IJobManifest type exposes the following members.

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
<td><a href="ijobmanifest-getscheduler-method-microsoft-web-media-transformmanager.md">GetScheduler</a></td>
<td>Returns a job scheduler object by searching the job manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="ijobmanifest-getschedulerinfo-method-microsoft-web-media-transformmanager.md">GetSchedulerInfo</a></td>
<td>Returns scheduler information by searching the job manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="ijobmanifest-initialize-method-microsoft-web-media-transformmanager.md">Initialize</a></td>
<td>Initializes member variables for a job manifest that is loaded from disk instead of created as part of a job submission.</td>
</tr>
</tbody>
</table>


Top

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

