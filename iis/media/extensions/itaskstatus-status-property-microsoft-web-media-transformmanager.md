---
title: ITaskStatus.Status Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Status Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ITaskStatus.Status
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.itaskstatus.status(v=VS.90)
ms:contentKeyID: 35521129
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ITaskStatus.Status
- Microsoft.Web.Media.TransformManager.ITaskStatus.get_Status
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ITaskStatus.get_Status
- Microsoft.Web.Media.TransformManager.ITaskStatus.Status
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
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
ReadOnlyPropertyStatusAsJobStatusGet
'Usage
DiminstanceAsITaskStatusDimvalueAsJobStatusvalue = instance.Status
```

``` csharp
JobStatusStatus { get; }
```

``` c++
propertyJobStatusStatus {
    JobStatusget ();
}
```

``` fsharp
abstractStatus : JobStatus
```

``` jscript
function getStatus () : JobStatus
```

#### Property Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The task status.  

## See Also

#### Reference

[ITaskStatus Interface](itaskstatus-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

