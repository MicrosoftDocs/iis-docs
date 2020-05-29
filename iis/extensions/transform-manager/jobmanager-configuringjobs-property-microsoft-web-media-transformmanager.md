---
title: JobManager.ConfiguringJobs Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfiguringJobs Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.ConfiguringJobs
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanager.configuringjobs(v=VS.90)
ms:contentKeyID: 35521189
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_ConfiguringJobs
- Microsoft.Web.Media.TransformManager.JobManager.ConfiguringJobs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.ConfiguringJobs
- Microsoft.Web.Media.TransformManager.JobManager.get_ConfiguringJobs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConfiguringJobs Property

Gets a collection of job details that specify jobs that are being configured.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property ConfiguringJobs As Collection(Of JobDetails)
    Get
'Usage

  Dim instance As JobManager
Dim value As Collection(Of JobDetails)

value = instance.ConfiguringJobs
```

```csharp
  public Collection<JobDetails> ConfiguringJobs { get; }
```

```cpp
  public:
property Collection<JobDetails^>^ ConfiguringJobs {
    Collection<JobDetails^>^ get ();
}
```

``` fsharp
  member ConfiguringJobs : Collection<JobDetails>
```

```jscript
  function get ConfiguringJobs () : Collection<JobDetails>
```

### Property Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
The collection of job details.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
