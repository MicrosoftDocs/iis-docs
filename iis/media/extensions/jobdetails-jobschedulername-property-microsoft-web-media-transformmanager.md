---
title: JobDetails.JobSchedulerName Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: JobSchedulerName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.JobSchedulerName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.jobschedulername(v=VS.90)
ms:contentKeyID: 35521018
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobSchedulerName
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobSchedulerName
- Microsoft.Web.Media.TransformManager.JobDetails.JobSchedulerName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobSchedulerName
- Microsoft.Web.Media.TransformManager.JobDetails.JobSchedulerName
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobSchedulerName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobSchedulerName Property

Gets or sets the name of the job scheduler that runs this job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyJobSchedulerNameAsStringGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsStringvalue = instance.JobSchedulerName

instance.JobSchedulerName = value
```

``` csharp
[DataMemberAttribute]
publicstringJobSchedulerName { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ JobSchedulerName {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberJobSchedulerName : stringwithget, set
```

``` jscript
function getJobSchedulerName () : Stringfunction setJobSchedulerName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The name of the job scheduler that runs this job.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

