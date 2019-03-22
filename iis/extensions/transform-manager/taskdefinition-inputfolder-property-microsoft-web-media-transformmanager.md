---
title: TaskDefinition.InputFolder Property (Microsoft.Web.Media.TransformManager)
TOCTitle: InputFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.InputFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.inputfolder(v=VS.90)
ms:contentKeyID: 35520787
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.InputFolder
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_InputFolder
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_InputFolder
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_InputFolder
- Microsoft.Web.Media.TransformManager.TaskDefinition.InputFolder
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_InputFolder
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# InputFolder Property

Gets or sets the folder name to append to the working directory in order to find input files.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property InputFolder As String
    Get
    Set
'Usage

  Dim instance As TaskDefinition
Dim value As String

value = instance.InputFolder

instance.InputFolder = value
```

```csharp
[DataMemberAttribute]
public string InputFolder { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ InputFolder {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member InputFolder : string with get, set
```

```jscript
  function get InputFolder () : String
function set InputFolder (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The folder name.  

## See Also

### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

