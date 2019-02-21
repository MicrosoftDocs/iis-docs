---
title: TaskDefinition.Save Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Save Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TaskDefinition.Save(System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.save(v=VS.90)
ms:contentKeyID: 35521198
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.Save
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.Save
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Save Method

Saves a task definition object to a configuration file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub Save ( _
    overwrite As Boolean _
)
'Usage

  Dim instance As TaskDefinition
Dim overwrite As Boolean

instance.Save(overwrite)
```

```csharp
  public void Save(
    bool overwrite
)
```

```cpp
  public:
void Save(
    bool overwrite
)
```

``` fsharp
  member Save : 
        overwrite:bool -> unit 
```

```jscript
  public function Save(
    overwrite : boolean
)
```

### Parameters

  - overwrite  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
    true to overwrite any existing file that has the same name; otherwise, false.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[InvalidOperationException](https://msdn.microsoft.com/library/2asft85a)|The file exists and the overwrite parameter is not true.|


## See Also

### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

