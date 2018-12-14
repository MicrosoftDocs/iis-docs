---
title: IManagementService.ResubmitJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: ResubmitJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.ResubmitJob(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.resubmitjob(v=VS.90)
ms:contentKeyID: 35520661
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.ResubmitJob
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.ResubmitJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ResubmitJob Method

Moves a transform job to the configuring queue, where it will be resubmitted.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
SubResubmitJob ( _
    jobDetailsAsJobDetails _
)
'Usage
DiminstanceAsIManagementServiceDimjobDetailsAsJobDetails

instance.ResubmitJob(jobDetails)
```

``` csharp
[OperationContractAttribute]
voidResubmitJob(
    JobDetailsjobDetails
)
```

``` c++
[OperationContractAttribute]
voidResubmitJob(
    JobDetails^ jobDetails
)
```

``` fsharp
[<OperationContractAttribute>]
abstractResubmitJob : 
        jobDetails:JobDetails->unit
```

``` jscript
functionResubmitJob(
    jobDetails : JobDetails
)
```

#### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    A [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object for the job to resubmit.  

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
<td><a href="https://msdn.microsoft.com/en-us/library/27426hcy(v=vs.90)">ArgumentNullException</a></td>
<td><p>jobDetails is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .</p></td>
</tr>
<tr class="even">
<td><a href="https://msdn.microsoft.com/en-us/library/27426hcy(v=vs.90)">ArgumentNullException</a></td>
<td><p>The JobDefinitionId property of the jobDetails parameter is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

