---
title: JobDetails.EndTime Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: EndTime Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.EndTime
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.endtime(v=VS.90)
ms:contentKeyID: 35521093
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_EndTime
- Microsoft.Web.Media.TransformManager.JobDetails.EndTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_EndTime
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.EndTime
- Microsoft.Web.Media.TransformManager.JobDetails.get_EndTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_EndTime
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# EndTime Property

Gets or sets the time when the job ended.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyEndTimeAsDateTimeGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsDateTimevalue = instance.EndTime

instance.EndTime = value
```

``` csharp
[DataMemberAttribute]
publicDateTimeEndTime { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyDateTimeEndTime {
    DateTimeget ();
    voidset (DateTimevalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberEndTime : DateTimewithget, set
```

``` jscript
function getEndTime () : DateTimefunction setEndTime (value : DateTime)
```

#### Property Value

Type: [System. . :: . .DateTime](https://msdn.microsoft.com/en-us/library/03ybds8y\(v=vs.90\))  
The time when the job ended.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

