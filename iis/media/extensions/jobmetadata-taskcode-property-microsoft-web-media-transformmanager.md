---
title: JobMetadata.TaskCode Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskCode Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.TaskCode
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.taskcode(v=VS.90)
ms:contentKeyID: 35520684
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_TaskCode
- Microsoft.Web.Media.TransformManager.JobMetadata.TaskCode
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_TaskCode
- Microsoft.Web.Media.TransformManager.JobMetadata.TaskCode
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskCode Property

Gets the task code from the task element that is contained in the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyTaskCodeAsStringGet
'Usage
DiminstanceAsJobMetadataDimvalueAsStringvalue = instance.TaskCode
```

``` csharp
publicstringTaskCode { get; }
```

``` c++
public:
propertyString^ TaskCode {
    String^ get ();
}
```

``` fsharp
memberTaskCode : string
```

``` jscript
function getTaskCode () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The task code.  

## See Also

#### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

