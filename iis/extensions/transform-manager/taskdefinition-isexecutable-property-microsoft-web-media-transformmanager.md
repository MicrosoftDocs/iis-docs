---
title: TaskDefinition.IsExecutable Property (Microsoft.Web.Media.TransformManager)
TOCTitle: IsExecutable Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.IsExecutable
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskdefinition.isexecutable(v=VS.90)
ms:contentKeyID: 35520820
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_IsExecutable
- Microsoft.Web.Media.TransformManager.TaskDefinition.IsExecutable
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_IsExecutable
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_IsExecutable
- Microsoft.Web.Media.TransformManager.TaskDefinition.IsExecutable
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_IsExecutable
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IsExecutable Property

Gets or sets a value that specifies whether the type of task is an executable or an [ITask](itask-interface-microsoft-web-media-transformmanager.md) interface.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property IsExecutable As Boolean
    Get
    Set
'Usage

  Dim instance As TaskDefinition
Dim value As Boolean

value = instance.IsExecutable

instance.IsExecutable = value
```

```csharp
[DataMemberAttribute]
public bool IsExecutable { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property bool IsExecutable {
    bool get ();
    void set (bool value);
}
```

``` fsharp
[<DataMemberAttribute>]
member IsExecutable : bool with get, set
```

```jscript
  function get IsExecutable () : boolean
function set IsExecutable (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the type of task is an executable; otherwise, false.  

## See Also

### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
