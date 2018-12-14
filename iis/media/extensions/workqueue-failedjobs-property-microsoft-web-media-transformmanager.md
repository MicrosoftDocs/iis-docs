---
title: WorkQueue.FailedJobs Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: FailedJobs Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.WorkQueue.FailedJobs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.workqueue.failedjobs(v=VS.90)
ms:contentKeyID: 35520880
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.WorkQueue.get_FailedJobs
- Microsoft.Web.Media.TransformManager.WorkQueue.FailedJobs
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.WorkQueue.FailedJobs
- Microsoft.Web.Media.TransformManager.WorkQueue.get_FailedJobs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FailedJobs Property

Gets a collection of job details that specify jobs that have failed.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyFailedJobsAsCollection(OfJobDetails)
    Get
'Usage
DiminstanceAsWorkQueueDimvalueAsCollection(OfJobDetails)

value = instance.FailedJobs
```

``` csharp
publicCollection<JobDetails> FailedJobs { get; }
```

``` c++
public:
propertyCollection<JobDetails^>^ FailedJobs {
    Collection<JobDetails^>^ get ();
}
```

``` fsharp
memberFailedJobs : Collection<JobDetails>
```

``` jscript
function getFailedJobs () : Collection<JobDetails>
```

#### Property Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of job details that specify jobs that have failed.  

## See Also

#### Reference

[WorkQueue Class](workqueue-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

