---
title: LocalScheduler.CleanupJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CleanupJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupJob(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.cleanupjob(v=VS.90)
ms:contentKeyID: 35520620
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupJob
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CleanupJob Method

Removes scheduler artifacts for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesSubCleanupJob ( _
    jobInstanceIdAsString _
)
'Usage
DiminstanceAsLocalSchedulerDimjobInstanceIdAsString

instance.CleanupJob(jobInstanceId)
```

``` csharp
publicoverridevoidCleanupJob(
    stringjobInstanceId
)
```

``` c++
public:
virtualvoidCleanupJob(
    String^ jobInstanceId
) override
```

``` fsharp
abstractCleanupJob : 
        jobInstanceId:string->unitoverrideCleanupJob : 
        jobInstanceId:string->unit
```

``` jscript
publicoverridefunctionCleanupJob(
    jobInstanceId : String
)
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

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
<td><a href="https://msdn.microsoft.com/en-us/library/99akez90(v=vs.90)">FileLoadException</a></td>
<td><p>The method was unable to load a file that was created by the task scheduler when a job was submitted.</p></td>
</tr>
<tr class="even">
<td><a href="https://msdn.microsoft.com/en-us/library/02hkayhc(v=vs.90)">COMException</a></td>
<td><p>The method was unable to complete the transaction that was originated by the task scheduler.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

