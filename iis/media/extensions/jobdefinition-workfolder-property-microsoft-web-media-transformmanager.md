---
title: JobDefinition.WorkFolder Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: WorkFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.WorkFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.workfolder(v=VS.90)
ms:contentKeyID: 46408745
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_WorkFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_WorkFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.WorkFolder
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_WorkFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_WorkFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.WorkFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WorkFolder Property

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyWorkFolderAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.WorkFolder

instance.WorkFolder = value
```

``` csharp
[DataMemberAttribute]
publicstringWorkFolder { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ WorkFolder {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberWorkFolder : stringwithget, set
```

``` jscript
function getWorkFolder () : Stringfunction setWorkFolder (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

