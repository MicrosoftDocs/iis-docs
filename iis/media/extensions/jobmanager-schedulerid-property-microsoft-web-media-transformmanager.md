---
title: JobManager.SchedulerId Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.SchedulerId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.schedulerid(v=VS.90)
ms:contentKeyID: 35520933
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.SchedulerId
- Microsoft.Web.Media.TransformManager.JobManager.get_SchedulerId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_SchedulerId
- Microsoft.Web.Media.TransformManager.JobManager.SchedulerId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SchedulerId Property

Gets the ID of the scheduler that is associated with this job definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySchedulerIdAsStringGet
'Usage
DiminstanceAsJobManagerDimvalueAsStringvalue = instance.SchedulerId
```

``` csharp
publicstringSchedulerId { get; }
```

``` c++
public:
propertyString^ SchedulerId {
    String^ get ();
}
```

``` fsharp
memberSchedulerId : string
```

``` jscript
function getSchedulerId () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The ID of the scheduler that is associated with this job definition.  

## See Also

#### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

