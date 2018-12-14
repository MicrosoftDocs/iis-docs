---
title: JobDetails.Status Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Status Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.Status
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.status(v=VS.90)
ms:contentKeyID: 35520980
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.set_Status
- Microsoft.Web.Media.TransformManager.JobDetails.get_Status
- Microsoft.Web.Media.TransformManager.JobDetails.Status
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_Status
- Microsoft.Web.Media.TransformManager.JobDetails.set_Status
- Microsoft.Web.Media.TransformManager.JobDetails.Status
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Status Property

Gets or sets the status of the job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyStatusAsJobStatusGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsJobStatusvalue = instance.Status

instance.Status = value
```

``` csharp
[DataMemberAttribute]
publicJobStatusStatus { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyJobStatusStatus {
    JobStatusget ();
    voidset (JobStatusvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberStatus : JobStatuswithget, set
```

``` jscript
function getStatus () : JobStatusfunction setStatus (value : JobStatus)
```

#### Property Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The status of the job.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

