---
title: JobDetails.QueueTime Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: QueueTime Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.QueueTime
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.queuetime(v=VS.90)
ms:contentKeyID: 35520722
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.set_QueueTime
- Microsoft.Web.Media.TransformManager.JobDetails.QueueTime
- Microsoft.Web.Media.TransformManager.JobDetails.get_QueueTime
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_QueueTime
- Microsoft.Web.Media.TransformManager.JobDetails.QueueTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_QueueTime
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# QueueTime Property

Gets or sets the date and time when the job was added to the work queue.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyQueueTimeAsDateTimeGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsDateTimevalue = instance.QueueTime

instance.QueueTime = value
```

``` csharp
[DataMemberAttribute]
publicDateTimeQueueTime { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyDateTimeQueueTime {
    DateTimeget ();
    voidset (DateTimevalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberQueueTime : DateTimewithget, set
```

``` jscript
function getQueueTime () : DateTimefunction setQueueTime (value : DateTime)
```

#### Property Value

Type: [System. . :: . .DateTime](https://msdn.microsoft.com/en-us/library/03ybds8y\(v=vs.90\))  
The date and time when the job was added to the work queue.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

