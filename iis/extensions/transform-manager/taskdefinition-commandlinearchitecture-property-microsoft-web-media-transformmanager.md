---
title: TaskDefinition.CommandLineArchitecture Property (Microsoft.Web.Media.TransformManager)
TOCTitle: CommandLineArchitecture Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.CommandLineArchitecture
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.commandlinearchitecture(v=VS.90)
ms:contentKeyID: 35520588
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.CommandLineArchitecture
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_CommandLineArchitecture
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_CommandLineArchitecture
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.CommandLineArchitecture
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_CommandLineArchitecture
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_CommandLineArchitecture
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CommandLineArchitecture Property

Gets or sets the architecture of the command-line executable.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property CommandLineArchitecture As String
    Get
    Set
'Usage

  Dim instance As TaskDefinition
Dim value As String

value = instance.CommandLineArchitecture

instance.CommandLineArchitecture = value
```

```csharp
[DataMemberAttribute]
public string CommandLineArchitecture { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ CommandLineArchitecture {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member CommandLineArchitecture : string with get, set
```

```jscript
  function get CommandLineArchitecture () : String
function set CommandLineArchitecture (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The architecture of the command-line executable.  

## Remarks

The architecture of the command-line executable is returned if the executable is architecture specific. For example, if you write a command-line executable that runs only on an x86 computer, IIS Transform Manager invokes the executable from an x86 version of the IIS Transform Manager task engine.

## See Also

### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

