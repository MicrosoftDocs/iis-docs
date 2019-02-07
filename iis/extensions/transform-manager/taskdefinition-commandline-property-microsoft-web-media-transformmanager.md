---
title: TaskDefinition.CommandLine Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: CommandLine Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.CommandLine
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.commandline(v=VS.90)
ms:contentKeyID: 35520653
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_CommandLine
- Microsoft.Web.Media.TransformManager.TaskDefinition.CommandLine
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_CommandLine
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.CommandLine
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_CommandLine
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_CommandLine
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CommandLine Property

Gets or sets a command line for the task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
Public Property CommandLine As String
    Get
    Set
'Usage

  Dim instance As TaskDefinition
Dim value As String

value = instance.CommandLine

instance.CommandLine = value
```

``` csharp
[DataMemberAttribute]
public string CommandLine { get; set; }
```

``` c++
[DataMemberAttribute]
public:
property String^ CommandLine {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member CommandLine : string with get, set
```

``` jscript
  function get CommandLine () : String
function set CommandLine (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The command line.  

## Remarks

If the command line includes a path that contains spaces, the string must have double quotation marks around it.

## See Also

#### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

