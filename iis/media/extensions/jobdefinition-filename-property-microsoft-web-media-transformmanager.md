---
title: JobDefinition.FileName Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: FileName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.FileName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.filename(v=VS.90)
ms:contentKeyID: 35520612
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.FileName
- Microsoft.Web.Media.TransformManager.JobDefinition.set_FileName
- Microsoft.Web.Media.TransformManager.JobDefinition.get_FileName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.FileName
- Microsoft.Web.Media.TransformManager.JobDefinition.set_FileName
- Microsoft.Web.Media.TransformManager.JobDefinition.get_FileName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FileName Property

Gets or sets the name of the configuration file for the current job definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyFileNameAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.FileName

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
The name of the configuration file for the current job definition.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

