---
title: TaskDefinition.FileName Property (Microsoft.Web.Media.TransformManager)
TOCTitle: FileName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.FileName
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskdefinition.filename(v=VS.90)
ms:contentKeyID: 35520584
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_FileName
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_FileName
- Microsoft.Web.Media.TransformManager.TaskDefinition.FileName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.FileName
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_FileName
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_FileName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# FileName Property

Gets or sets the name of the task definition configuration file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property FileName As String
    Get
    Set
'Usage

  Dim instance As TaskDefinition
Dim value As String

value = instance.FileName

instance.FileName = value
```

```csharp
[DataMemberAttribute]
public string FileName { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ FileName {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member FileName : string with get, set
```

```jscript
  function get FileName () : String
function set FileName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The name of the task definition configuration file.  

## See Also

### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
