---
title: TaskDefinition.TaskTypeArchitecture Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskTypeArchitecture Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.TaskTypeArchitecture
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.tasktypearchitecture(v=VS.90)
ms:contentKeyID: 35520932
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_TaskTypeArchitecture
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_TaskTypeArchitecture
- Microsoft.Web.Media.TransformManager.TaskDefinition.TaskTypeArchitecture
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_TaskTypeArchitecture
- Microsoft.Web.Media.TransformManager.TaskDefinition.TaskTypeArchitecture
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_TaskTypeArchitecture
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskTypeArchitecture Property

Gets or sets the architecture of the task type, if the command-line executable is architecture specific.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyTaskTypeArchitectureAsStringGetSet
'Usage
DiminstanceAsTaskDefinitionDimvalueAsStringvalue = instance.TaskTypeArchitecture

instance.TaskTypeArchitecture = value
```

``` csharp
[DataMemberAttribute]
publicstringTaskTypeArchitecture { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ TaskTypeArchitecture {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberTaskTypeArchitecture : stringwithget, set
```

``` jscript
function getTaskTypeArchitecture () : Stringfunction setTaskTypeArchitecture (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The architecture of the task type.  

## See Also

#### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

