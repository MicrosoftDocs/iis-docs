---
title: TaskStatus.Status Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Status Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskStatus.Status
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskstatus.status(v=VS.90)
ms:contentKeyID: 35520598
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.get_Status
- Microsoft.Web.Media.TransformManager.TaskStatus.Status
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus.get_Status
- Microsoft.Web.Media.TransformManager.TaskStatus.Status
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Status Property

Gets the status of the task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyStatusAsJobStatusGet
'Usage
DiminstanceAsTaskStatusDimvalueAsJobStatusvalue = instance.Status
```

``` csharp
publicJobStatusStatus { get; }
```

``` c++
public:
virtualpropertyJobStatusStatus {
    JobStatusget () sealed;
}
```

``` fsharp
abstractStatus : JobStatusoverrideStatus : JobStatus
```

``` jscript
finalfunction getStatus () : JobStatus
```

#### Property Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The task status.  

#### Implements

[ITaskStatus. . :: . .Status](itaskstatus-status-property-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

