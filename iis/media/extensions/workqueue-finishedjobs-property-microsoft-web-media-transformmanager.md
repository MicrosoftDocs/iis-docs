---
title: WorkQueue.FinishedJobs Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: FinishedJobs Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.WorkQueue.FinishedJobs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.workqueue.finishedjobs(v=VS.90)
ms:contentKeyID: 35521004
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.WorkQueue.get_FinishedJobs
- Microsoft.Web.Media.TransformManager.WorkQueue.FinishedJobs
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.WorkQueue.FinishedJobs
- Microsoft.Web.Media.TransformManager.WorkQueue.get_FinishedJobs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FinishedJobs Property

Gets a collection of job details that specify jobs that have finished.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyFinishedJobsAsCollection(OfJobDetails)
    Get
'Usage
DiminstanceAsWorkQueueDimvalueAsCollection(OfJobDetails)

value = instance.FinishedJobs
```

``` csharp
publicCollection<JobDetails> FinishedJobs { get; }
```

``` c++
public:
propertyCollection<JobDetails^>^ FinishedJobs {
    Collection<JobDetails^>^ get ();
}
```

``` fsharp
memberFinishedJobs : Collection<JobDetails>
```

``` jscript
function getFinishedJobs () : Collection<JobDetails>
```

#### Property Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of job details that specify jobs that have finished.  

## See Also

#### Reference

[WorkQueue Class](workqueue-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

