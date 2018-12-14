---
title: TaskDefinition.FileName Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: FileName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.FileName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.filename(v=VS.90)
ms:contentKeyID: 35520584
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_FileName
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_FileName
- Microsoft.Web.Media.TransformManager.TaskDefinition.FileName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.FileName
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_FileName
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_FileName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FileName Property

Gets or sets the name of the task definition configuration file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyFileNameAsStringGetSet
'Usage
DiminstanceAsTaskDefinitionDimvalueAsStringvalue = instance.FileName

instance.FileName = value
```

``` csharp
[DataMemberAttribute]
publicstringFileName { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ FileName {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberFileName : stringwithget, set
```

``` jscript
function getFileName () : Stringfunction setFileName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The name of the task definition configuration file.  

## See Also

#### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

