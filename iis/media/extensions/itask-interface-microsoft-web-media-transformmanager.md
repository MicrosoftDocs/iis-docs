---
title: ITask Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: ITask Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.ITask
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.itask(v=VS.90)
ms:contentKeyID: 35520845
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ITask
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ITask
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ITask Interface

Defines a class as a transform task for use with the IIS Transform Manager framework.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicInterfaceITask _
    InheritsIDisposable
'Usage
DiminstanceAsITask
```

``` csharp
publicinterfaceITask : IDisposable
```

``` c++
publicinterface classITask : IDisposable
```

``` fsharp
typeITask =  
    interfaceinterfaceIDisposableend
```

``` jscript
publicinterface ITask extendsIDisposable
```

The ITask type exposes the following members.

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
<td><a href="https://msdn.microsoft.com/en-us/library/es4s3w1d(v=vs.90)">Dispose</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/aax125c9(v=vs.90)">IDisposable</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="itask-initialize-method-microsoft-web-media-transformmanager.md">Initialize</a></td>
<td>Initializes the task with objects for reporting status, logging data, and getting metadata from the job manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="itask-start-method-microsoft-web-media-transformmanager.md">Start</a></td>
<td>Called by the framework to start the task immediately after the <a href="itask-initialize-method-microsoft-web-media-transformmanager.md">Initialize(ITaskStatus, IJobMetadata, ILogger)</a> method runs.</td>
</tr>
</tbody>
</table>


Top

## Remarks

The ITask interface implements the setter injection pattern. As parameters, the [Initialize(ITaskStatus, IJobMetadata, ILogger)](itask-initialize-method-microsoft-web-media-transformmanager.md) method takes instances of [ITaskStatus](itaskstatus-interface-microsoft-web-media-transformmanager.md), [IJobMetadata](ijobmetadata-interface-microsoft-web-media-transformmanager.md), and [ILogger](ilogger-interface-microsoft-web-media-transformmanager.md) to explicitly inject dependent objects. For more information, see [Inversion of Control Containers and the Dependency Injection Pattern](http://martinfowler.com/articles/injection.html).

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

