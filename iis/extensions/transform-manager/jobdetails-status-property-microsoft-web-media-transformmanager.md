---
title: JobDetails.Status Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Status Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.Status
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdetails.status(v=VS.90)
ms:contentKeyID: 35520980
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.set_Status
- Microsoft.Web.Media.TransformManager.JobDetails.get_Status
- Microsoft.Web.Media.TransformManager.JobDetails.Status
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_Status
- Microsoft.Web.Media.TransformManager.JobDetails.set_Status
- Microsoft.Web.Media.TransformManager.JobDetails.Status
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Status Property

Gets or sets the status of the job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Status As JobStatus
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As JobStatus

value = instance.Status

instance.Status = value
```

```csharp
[DataMemberAttribute]
public JobStatus Status { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property JobStatus Status {
    JobStatus get ();
    void set (JobStatus value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Status : JobStatus with get, set
```

```jscript
  function get Status () : JobStatus
function set Status (value : JobStatus)
```

### Property Value

Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The status of the job.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
