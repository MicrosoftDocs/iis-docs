---
title: JobTemplate.TaskDefinitions Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskDefinitions Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobTemplate.TaskDefinitions
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobtemplate.taskdefinitions(v=VS.90)
ms:contentKeyID: 35520683
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobTemplate.get_TaskDefinitions
- Microsoft.Web.Media.TransformManager.JobTemplate.TaskDefinitions
- Microsoft.Web.Media.TransformManager.JobTemplate.set_TaskDefinitions
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobTemplate.get_TaskDefinitions
- Microsoft.Web.Media.TransformManager.JobTemplate.set_TaskDefinitions
- Microsoft.Web.Media.TransformManager.JobTemplate.TaskDefinitions
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskDefinitions Property

Gets or sets a collection of the task definitions for the job template.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyTaskDefinitionsAsTaskDefinition()
    GetSet
'Usage
DiminstanceAsJobTemplateDimvalueAsTaskDefinition()

value = instance.TaskDefinitions

instance.TaskDefinitions = value
```

``` csharp
[DataMemberAttribute]
publicTaskDefinition[] TaskDefinitions { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyarray<TaskDefinition^>^ TaskDefinitions {
    array<TaskDefinition^>^ get ();
    voidset (array<TaskDefinition^>^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberTaskDefinitions : TaskDefinition[] withget, set
```

``` jscript
function getTaskDefinitions () : TaskDefinition[]
function setTaskDefinitions (value : TaskDefinition[])
```

#### Property Value

Type: array\<[Microsoft.Web.Media.TransformManager. . :: . .TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md)\> \[\] () \[\] \[\]  
A collection of the task definitions.  

## See Also

#### Reference

[JobTemplate Class](jobtemplate-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

