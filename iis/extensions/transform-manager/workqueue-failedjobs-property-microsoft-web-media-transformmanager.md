---
title: WorkQueue.FailedJobs Property (Microsoft.Web.Media.TransformManager)
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
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.WorkQueue.FailedJobs
- Microsoft.Web.Media.TransformManager.WorkQueue.get_FailedJobs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# FailedJobs Property

Gets a collection of job details that specify jobs that have failed.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property FailedJobs As Collection(Of JobDetails)
    Get
'Usage

  Dim instance As WorkQueue
Dim value As Collection(Of JobDetails)

value = instance.FailedJobs
```

```csharp
  public Collection<JobDetails> FailedJobs { get; }
```

```cpp
  public:
property Collection<JobDetails^>^ FailedJobs {
    Collection<JobDetails^>^ get ();
}
```

``` fsharp
  member FailedJobs : Collection<JobDetails>
```

```jscript
  function get FailedJobs () : Collection<JobDetails>
```

### Property Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of job details that specify jobs that have failed.  

## See Also

### Reference

[WorkQueue Class](workqueue-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

