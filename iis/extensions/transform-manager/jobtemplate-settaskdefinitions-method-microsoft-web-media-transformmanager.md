---
title: JobTemplate.SetTaskDefinitions Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskDefinitions Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobTemplate.SetTaskDefinitions(System.Collections.ObjectModel.Collection{Microsoft.Web.Media.TransformManager.TaskDefinition})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobtemplate.settaskdefinitions(v=VS.90)
ms:contentKeyID: 35520882
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobTemplate.SetTaskDefinitions
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobTemplate.SetTaskDefinitions
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetTaskDefinitions Method

Sets a list of [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) objects when a job template element is created.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Sub SetTaskDefinitions ( _
    taskDefinitions As Collection(Of TaskDefinition) _
)
'Usage

  Dim taskDefinitions As Collection(Of TaskDefinition)

JobTemplate.SetTaskDefinitions(taskDefinitions)
```

```csharp
  public static void SetTaskDefinitions(
    Collection<TaskDefinition> taskDefinitions
)
```

```cpp
  public:
static void SetTaskDefinitions(
    Collection<TaskDefinition^>^ taskDefinitions
)
```

``` fsharp
  static member SetTaskDefinitions : 
        taskDefinitions:Collection<TaskDefinition> -> unit 
```

```jscript
  public static function SetTaskDefinitions(
    taskDefinitions : Collection<TaskDefinition>
)
```

### Parameters

  - taskDefinitions  
    Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
    A collection of [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) objects used to specify a job template element.  

## See Also

### Reference

[JobTemplate Class](jobtemplate-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

