---
title: JobDefinition.InputFolderPath Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: InputFolderPath Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.InputFolderPath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.inputfolderpath(v=VS.90)
ms:contentKeyID: 35521079
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_InputFolderPath
- Microsoft.Web.Media.TransformManager.JobDefinition.InputFolderPath
- Microsoft.Web.Media.TransformManager.JobDefinition.set_InputFolderPath
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_InputFolderPath
- Microsoft.Web.Media.TransformManager.JobDefinition.set_InputFolderPath
- Microsoft.Web.Media.TransformManager.JobDefinition.InputFolderPath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InputFolderPath Property

Gets or sets the input folder path. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyInputFolderPathAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.InputFolderPath

instance.InputFolderPath = value
```

``` csharp
[DataMemberAttribute]
publicstringInputFolderPath { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ InputFolderPath {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberInputFolderPath : stringwithget, set
```

``` jscript
function getInputFolderPath () : Stringfunction setInputFolderPath (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The input folder path.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

