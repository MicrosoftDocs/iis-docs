---
title: TaskDefinition.CommandLineArchitecture Property  (Microsoft.Web.Media.TransformManager)
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
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# CommandLineArchitecture Property

Gets or sets the architecture of the command-line executable.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyCommandLineArchitectureAsStringGetSet
'Usage
DiminstanceAsTaskDefinitionDimvalueAsStringvalue = instance.CommandLineArchitecture

instance.CommandLineArchitecture = value
```

``` csharp
[DataMemberAttribute]
publicstringCommandLineArchitecture { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ CommandLineArchitecture {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberCommandLineArchitecture : stringwithget, set
```

``` jscript
function getCommandLineArchitecture () : Stringfunction setCommandLineArchitecture (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The architecture of the command-line executable.  

## Remarks

The architecture of the command-line executable is returned if the executable is architecture specific. For example, if you write a command-line executable that runs only on an x86 computer, IIS Transform Manager invokes the executable from an x86 version of the IIS Transform Manager task engine.

## See Also

#### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

