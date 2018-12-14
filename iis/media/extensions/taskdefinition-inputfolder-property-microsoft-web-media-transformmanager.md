---
title: TaskDefinition.InputFolder Property  (Microsoft.Web.Media.TransformManager)
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
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_InputFolder
- Microsoft.Web.Media.TransformManager.TaskDefinition.InputFolder
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_InputFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InputFolder Property

Gets or sets the folder name to append to the working directory in order to find input files.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyInputFolderAsStringGetSet
'Usage
DiminstanceAsTaskDefinitionDimvalueAsStringvalue = instance.InputFolder

instance.InputFolder = value
```

``` csharp
[DataMemberAttribute]
publicstringInputFolder { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ InputFolder {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberInputFolder : stringwithget, set
```

``` jscript
function getInputFolder () : Stringfunction setInputFolder (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The folder name.  

## See Also

#### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

