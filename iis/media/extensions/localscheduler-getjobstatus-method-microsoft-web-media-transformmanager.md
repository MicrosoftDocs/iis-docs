---
title: LocalScheduler.GetJobStatus Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobStatus Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobStatus(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.getjobstatus(v=VS.90)
ms:contentKeyID: 35521193
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobStatus
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobStatus
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobStatus Method

Returns the status of the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesFunctionGetJobStatus ( _
    jobInstanceIdAsString _
) AsJobStatus
'Usage
DiminstanceAsLocalSchedulerDimjobInstanceIdAsStringDimreturnValueAsJobStatusreturnValue = instance.GetJobStatus(jobInstanceId)
```

``` csharp
publicoverrideJobStatusGetJobStatus(
    stringjobInstanceId
)
```

``` c++
public:
virtualJobStatusGetJobStatus(
    String^ jobInstanceId
) override
```

``` fsharp
abstractGetJobStatus : 
        jobInstanceId:string->JobStatusoverrideGetJobStatus : 
        jobInstanceId:string->JobStatus
```

``` jscript
publicoverridefunctionGetJobStatus(
    jobInstanceId : String
) : JobStatus
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The status of the job.  

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
<td><a href="https://msdn.microsoft.com/en-us/library/dzyy5k3x(v=vs.90)">FileNotFoundException</a></td>
<td><p>The method was unable to find a job file.</p></td>
</tr>
<tr class="even">
<td><a href="https://msdn.microsoft.com/en-us/library/99akez90(v=vs.90)">FileLoadException</a></td>
<td><p>The method was unable to load a file that was created by the task scheduler when a job was submitted.</p></td>
</tr>
<tr class="odd">
<td><a href="https://msdn.microsoft.com/en-us/library/02hkayhc(v=vs.90)">COMException</a></td>
<td><p>The method was unable to complete the transaction that was originated by the task scheduler.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

