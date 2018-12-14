---
title: JobDetails.SubmitTime Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: SubmitTime Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.SubmitTime
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.submittime(v=VS.90)
ms:contentKeyID: 35520778
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.SubmitTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_SubmitTime
- Microsoft.Web.Media.TransformManager.JobDetails.get_SubmitTime
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_SubmitTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_SubmitTime
- Microsoft.Web.Media.TransformManager.JobDetails.SubmitTime
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SubmitTime Property

Gets or sets the time that the job was submitted to the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertySubmitTimeAsDateTimeGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsDateTimevalue = instance.SubmitTime

instance.SubmitTime = value
```

``` csharp
[DataMemberAttribute]
publicDateTimeSubmitTime { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyDateTimeSubmitTime {
    DateTimeget ();
    voidset (DateTimevalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberSubmitTime : DateTimewithget, set
```

``` jscript
function getSubmitTime () : DateTimefunction setSubmitTime (value : DateTime)
```

#### Property Value

Type: [System. . :: . .DateTime](https://msdn.microsoft.com/en-us/library/03ybds8y\(v=vs.90\))  
The time that the job was submitted to the scheduler.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

