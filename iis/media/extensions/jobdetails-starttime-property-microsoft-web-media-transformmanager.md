---
title: JobDetails.StartTime Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: StartTime Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.StartTime
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.starttime(v=VS.90)
ms:contentKeyID: 35520726
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_StartTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_StartTime
- Microsoft.Web.Media.TransformManager.JobDetails.StartTime
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_StartTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_StartTime
- Microsoft.Web.Media.TransformManager.JobDetails.StartTime
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StartTime Property

Gets or sets the date and time when the job was started by the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyStartTimeAsDateTimeGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsDateTimevalue = instance.StartTime

instance.StartTime = value
```

``` csharp
[DataMemberAttribute]
publicDateTimeStartTime { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyDateTimeStartTime {
    DateTimeget ();
    voidset (DateTimevalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberStartTime : DateTimewithget, set
```

``` jscript
function getStartTime () : DateTimefunction setStartTime (value : DateTime)
```

#### Property Value

Type: [System. . :: . .DateTime](https://msdn.microsoft.com/en-us/library/03ybds8y\(v=vs.90\))  
The date and time when the job was started by the scheduler.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

