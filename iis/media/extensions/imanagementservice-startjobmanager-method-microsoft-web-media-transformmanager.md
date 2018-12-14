---
title: IManagementService.StartJobManager Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: StartJobManager Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.StartJobManager(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.startjobmanager(v=VS.90)
ms:contentKeyID: 35520976
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.StartJobManager
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.StartJobManager
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StartJobManager Method

Enables jobs to be processed using a [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
SubStartJobManager ( _
    jobDefinitionIdAsString _
)
'Usage
DiminstanceAsIManagementServiceDimjobDefinitionIdAsString

instance.StartJobManager(jobDefinitionId)
```

``` csharp
[OperationContractAttribute]
voidStartJobManager(
    stringjobDefinitionId
)
```

``` c++
[OperationContractAttribute]
voidStartJobManager(
    String^ jobDefinitionId
)
```

``` fsharp
[<OperationContractAttribute>]
abstractStartJobManager : 
        jobDefinitionId:string->unit
```

``` jscript
functionStartJobManager(
    jobDefinitionId : String
)
```

#### Parameters

  - jobDefinitionId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that will be used to process jobs.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><a href="https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.90)">InvalidOperationException</a></td>
<td><p>The job manager is in the process of shutting down.</p></td>
</tr>
<tr class="even">
<td><a href="https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.90)">InvalidOperationException</a></td>
<td><p>The job manager is already running.</p></td>
</tr>
<tr class="odd">
<td><a href="https://msdn.microsoft.com/en-us/library/f2y9aa54(v=vs.90)">UnauthorizedAccessException</a></td>
<td><p>The process was unable to create the watch folder.</p></td>
</tr>
<tr class="even">
<td><a href="https://msdn.microsoft.com/en-us/library/hccy4eyd(v=vs.90)">IOException</a></td>
<td><p>The process was unable to create the watch folder.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

