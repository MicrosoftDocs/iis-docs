---
title: JobManager.RunningJobs Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: RunningJobs Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.RunningJobs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.runningjobs(v=VS.90)
ms:contentKeyID: 35521164
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_RunningJobs
- Microsoft.Web.Media.TransformManager.JobManager.RunningJobs
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_RunningJobs
- Microsoft.Web.Media.TransformManager.JobManager.RunningJobs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RunningJobs Property

Gets a collection of job details that specify jobs that are running.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyRunningJobsAsCollection(OfJobDetails)
    Get
'Usage
DiminstanceAsJobManagerDimvalueAsCollection(OfJobDetails)

value = instance.RunningJobs
```

``` csharp
publicCollection<JobDetails> RunningJobs { get; }
```

``` c++
public:
propertyCollection<JobDetails^>^ RunningJobs {
    Collection<JobDetails^>^ get ();
}
```

``` fsharp
memberRunningJobs : Collection<JobDetails>
```

``` jscript
function getRunningJobs () : Collection<JobDetails>
```

#### Property Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of job details that specify jobs that are running.  

## See Also

#### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

