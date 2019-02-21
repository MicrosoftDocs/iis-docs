---
title: TaskDefinition.TaskCodeType Property (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskCodeType Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.TaskCodeType
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.taskcodetype(v=VS.90)
ms:contentKeyID: 35520579
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_TaskCodeType
- Microsoft.Web.Media.TransformManager.TaskDefinition.TaskCodeType
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_TaskCodeType
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_TaskCodeType
- Microsoft.Web.Media.TransformManager.TaskDefinition.TaskCodeType
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_TaskCodeType
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TaskCodeType Property

Gets or sets the task type.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property TaskCodeType As String
    Get
    Set
'Usage

  Dim instance As TaskDefinition
Dim value As String

value = instance.TaskCodeType

instance.TaskCodeType = value
```

```csharp
[DataMemberAttribute]
public string TaskCodeType { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ TaskCodeType {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member TaskCodeType : string with get, set
```

```jscript
  function get TaskCodeType () : String
function set TaskCodeType (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The task type.  

## See Also

### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

