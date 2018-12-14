---
title: JobDetails.Progress Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Progress Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.Progress
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.progress(v=VS.90)
ms:contentKeyID: 35520799
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.set_Progress
- Microsoft.Web.Media.TransformManager.JobDetails.get_Progress
- Microsoft.Web.Media.TransformManager.JobDetails.Progress
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_Progress
- Microsoft.Web.Media.TransformManager.JobDetails.Progress
- Microsoft.Web.Media.TransformManager.JobDetails.set_Progress
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Progress Property

Gets or sets the percentage complete of the job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyProgressAsIntegerGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsIntegervalue = instance.Progress

instance.Progress = value
```

``` csharp
[DataMemberAttribute]
publicintProgress { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyintProgress {
    intget ();
    voidset (intvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberProgress : intwithget, set
```

``` jscript
function getProgress () : intfunction setProgress (value : int)
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The percentage complete.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

