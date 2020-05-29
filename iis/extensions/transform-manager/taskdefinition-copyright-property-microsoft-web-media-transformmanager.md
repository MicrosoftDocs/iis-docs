---
title: TaskDefinition.Copyright Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Copyright Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.Copyright
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskdefinition.copyright(v=VS.90)
ms:contentKeyID: 35520607
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_Copyright
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_Copyright
- Microsoft.Web.Media.TransformManager.TaskDefinition.Copyright
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.Copyright
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_Copyright
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_Copyright
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Copyright Property

Gets or sets the copyright string that has been supplied by the task author.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property Copyright As String
    Get
    Set
'Usage

  Dim instance As TaskDefinition
Dim value As String

value = instance.Copyright

instance.Copyright = value
```

```csharp
  public string Copyright { get; set; }
```

```cpp
  public:
property String^ Copyright {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  member Copyright : string with get, set
```

```jscript
  function get Copyright () : String
function set Copyright (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The copyright string.  

## See Also

### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
