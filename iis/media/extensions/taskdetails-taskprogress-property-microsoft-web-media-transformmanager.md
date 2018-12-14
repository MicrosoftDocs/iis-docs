---
title: TaskDetails.TaskProgress Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskProgress Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDetails.TaskProgress
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdetails.taskprogress(v=VS.90)
ms:contentKeyID: 35520585
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDetails.TaskProgress
- Microsoft.Web.Media.TransformManager.TaskDetails.set_TaskProgress
- Microsoft.Web.Media.TransformManager.TaskDetails.get_TaskProgress
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDetails.get_TaskProgress
- Microsoft.Web.Media.TransformManager.TaskDetails.set_TaskProgress
- Microsoft.Web.Media.TransformManager.TaskDetails.TaskProgress
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskProgress Property

Gets or sets the progress of a task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyTaskProgressAsIntegerGetSet
'Usage
DiminstanceAsTaskDetailsDimvalueAsIntegervalue = instance.TaskProgress

instance.TaskProgress = value
```

``` csharp
publicintTaskProgress { get; set; }
```

``` c++
public:
propertyintTaskProgress {
    intget ();
    voidset (intvalue);
}
```

``` fsharp
memberTaskProgress : intwithget, set
```

``` jscript
function getTaskProgress () : intfunction setTaskProgress (value : int)
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The progress of a task.  

## See Also

#### Reference

[TaskDetails Structure](taskdetails-structure-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

