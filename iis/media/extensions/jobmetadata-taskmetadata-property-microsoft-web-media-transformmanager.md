---
title: JobMetadata.TaskMetadata Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskMetadata Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.TaskMetadata
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.taskmetadata(v=VS.90)
ms:contentKeyID: 35520931
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.TaskMetadata
- Microsoft.Web.Media.TransformManager.JobMetadata.get_TaskMetadata
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_TaskMetadata
- Microsoft.Web.Media.TransformManager.JobMetadata.TaskMetadata
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskMetadata Property

Gets the task metadata from the task element that is contained in the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyTaskMetadataAsXElementGet
'Usage
DiminstanceAsJobMetadataDimvalueAsXElementvalue = instance.TaskMetadata
```

``` csharp
publicXElementTaskMetadata { get; }
```

``` c++
public:
propertyXElement^ TaskMetadata {
    XElement^ get ();
}
```

``` fsharp
memberTaskMetadata : XElement
```

``` jscript
function getTaskMetadata () : XElement
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The task metadata.  

## See Also

#### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

