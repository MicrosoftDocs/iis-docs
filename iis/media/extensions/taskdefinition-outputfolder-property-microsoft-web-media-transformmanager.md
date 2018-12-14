---
title: TaskDefinition.OutputFolder Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: OutputFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.OutputFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.outputfolder(v=VS.90)
ms:contentKeyID: 35520650
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_OutputFolder
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_OutputFolder
- Microsoft.Web.Media.TransformManager.TaskDefinition.OutputFolder
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_OutputFolder
- Microsoft.Web.Media.TransformManager.TaskDefinition.OutputFolder
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_OutputFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# OutputFolder Property

Gets or sets the folder name to append to the working directory in order to write output files.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyOutputFolderAsStringGetSet
'Usage
DiminstanceAsTaskDefinitionDimvalueAsStringvalue = instance.OutputFolder

instance.OutputFolder = value
```

``` csharp
[DataMemberAttribute]
publicstringOutputFolder { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ OutputFolder {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberOutputFolder : stringwithget, set
```

``` jscript
function getOutputFolder () : Stringfunction setOutputFolder (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The folder name.  

## See Also

#### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

