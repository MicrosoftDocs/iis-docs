---
title: WorkQueue.SubmittedJobs Property (Microsoft.Web.Media.TransformManager)
TOCTitle: SubmittedJobs Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.WorkQueue.SubmittedJobs
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.workqueue.submittedjobs(v=VS.90)
ms:contentKeyID: 35520575
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.WorkQueue.SubmittedJobs
- Microsoft.Web.Media.TransformManager.WorkQueue.get_SubmittedJobs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.WorkQueue.get_SubmittedJobs
- Microsoft.Web.Media.TransformManager.WorkQueue.SubmittedJobs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SubmittedJobs Property

Gets a collection of job details that specify jobs that have been submitted.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property SubmittedJobs As Collection(Of JobDetails)
    Get
'Usage

  Dim instance As WorkQueue
Dim value As Collection(Of JobDetails)

value = instance.SubmittedJobs
```

```csharp
  public Collection<JobDetails> SubmittedJobs { get; }
```

```cpp
  public:
property Collection<JobDetails^>^ SubmittedJobs {
    Collection<JobDetails^>^ get ();
}
```

``` fsharp
  member SubmittedJobs : Collection<JobDetails>
```

```jscript
  function get SubmittedJobs () : Collection<JobDetails>
```

### Property Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of job details that specify jobs that have been submitted.  

## See Also

### Reference

[WorkQueue Class](workqueue-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
