---
title: JobDefinition.JobManagerLogRolloverIntervalMinutes Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: JobManagerLogRolloverIntervalMinutes Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.JobManagerLogRolloverIntervalMinutes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.jobmanagerlogrolloverintervalminutes(v=VS.90)
ms:contentKeyID: 35568109
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_JobManagerLogRolloverIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.JobManagerLogRolloverIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.set_JobManagerLogRolloverIntervalMinutes
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_JobManagerLogRolloverIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.JobManagerLogRolloverIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.set_JobManagerLogRolloverIntervalMinutes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobManagerLogRolloverIntervalMinutes Property

Gets or sets the number of minutes of log data to collect before a new log file is created.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyJobManagerLogRolloverIntervalMinutesAsIntegerGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsIntegervalue = instance.JobManagerLogRolloverIntervalMinutes

instance.JobManagerLogRolloverIntervalMinutes = value
```

``` csharp
[DataMemberAttribute]
publicintJobManagerLogRolloverIntervalMinutes { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyintJobManagerLogRolloverIntervalMinutes {
    intget ();
    voidset (intvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberJobManagerLogRolloverIntervalMinutes : intwithget, set
```

``` jscript
function getJobManagerLogRolloverIntervalMinutes () : intfunction setJobManagerLogRolloverIntervalMinutes (value : int)
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The number of minutes of log data to collect before a new log file is created.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

