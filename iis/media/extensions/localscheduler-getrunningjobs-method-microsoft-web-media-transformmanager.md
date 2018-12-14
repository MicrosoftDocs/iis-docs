---
title: LocalScheduler.GetRunningJobs Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetRunningJobs Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.GetRunningJobs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.getrunningjobs(v=VS.90)
ms:contentKeyID: 35521130
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetRunningJobs
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetRunningJobs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetRunningJobs Method

Returns a list of job instance IDs based on the currently running jobs.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesFunctionGetRunningJobsAsICollection(OfString)
'Usage
DiminstanceAsLocalSchedulerDimreturnValueAsICollection(OfString)

returnValue = instance.GetRunningJobs()
```

``` csharp
publicoverrideICollection<string> GetRunningJobs()
```

``` c++
public:
virtualICollection<String^>^ GetRunningJobs() override
```

``` fsharp
abstractGetRunningJobs : unit->ICollection<string> 
overrideGetRunningJobs : unit->ICollection<string> 
```

``` jscript
publicoverridefunctionGetRunningJobs() : ICollection<String>
```

#### Return Value

Type: [System.Collections.Generic. . :: . .ICollection](https://msdn.microsoft.com/en-us/library/92t2ye13\(v=vs.90\))\< (Of \< ( \<'[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))\> ) \> ) \>  
A list of job instance IDs.  

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
<td><a href="https://msdn.microsoft.com/en-us/library/02hkayhc(v=vs.90)">COMException</a></td>
<td><p>The method was unable to complete the transaction that was originated by the task scheduler.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

