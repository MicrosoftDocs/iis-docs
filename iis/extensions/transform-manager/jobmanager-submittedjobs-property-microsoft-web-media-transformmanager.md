---
title: JobManager.SubmittedJobs Property (Microsoft.Web.Media.TransformManager)
TOCTitle: SubmittedJobs Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.SubmittedJobs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.submittedjobs(v=VS.90)
ms:contentKeyID: 35520962
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_SubmittedJobs
- Microsoft.Web.Media.TransformManager.JobManager.SubmittedJobs
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_SubmittedJobs
- Microsoft.Web.Media.TransformManager.JobManager.SubmittedJobs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
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

  Dim instance As JobManager
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

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

