---
title: JobDefinition.InputFolder Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: InputFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.InputFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.inputfolder(v=VS.90)
ms:contentKeyID: 35520603
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.InputFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_InputFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.get_InputFolder
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_InputFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_InputFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.InputFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InputFolder Property

Gets or sets the input folder name. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyInputFolderAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.InputFolder

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
The input folder name.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

