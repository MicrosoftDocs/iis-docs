---
title: WorkQueue.FinishedJobs Property (Microsoft.Web.Media.TransformManager)
description: Learn how the FinishedJobs property gets a collection of job details that specify jobs that have finished.
TOCTitle: FinishedJobs Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.WorkQueue.FinishedJobs
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.workqueue.finishedjobs(v=VS.90)
ms:contentKeyID: 35521004
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.WorkQueue.get_FinishedJobs
- Microsoft.Web.Media.TransformManager.WorkQueue.FinishedJobs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.WorkQueue.FinishedJobs
- Microsoft.Web.Media.TransformManager.WorkQueue.get_FinishedJobs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# FinishedJobs Property

Gets a collection of job details that specify jobs that have finished.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property FinishedJobs As Collection(Of JobDetails)
    Get
'Usage

  Dim instance As WorkQueue
Dim value As Collection(Of JobDetails)

value = instance.FinishedJobs
```

```csharp
  public Collection<JobDetails> FinishedJobs { get; }
```

```cpp
  public:
property Collection<JobDetails^>^ FinishedJobs {
    Collection<JobDetails^>^ get ();
}
```

``` fsharp
  member FinishedJobs : Collection<JobDetails>
```

```jscript
  function get FinishedJobs () : Collection<JobDetails>
```

### Property Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of job details that specify jobs that have finished.  

## See Also

### Reference

[WorkQueue Class](workqueue-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
