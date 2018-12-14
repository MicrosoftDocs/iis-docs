---
title: JobDefinition.TemplateName Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TemplateName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.TemplateName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.templatename(v=VS.90)
ms:contentKeyID: 35520927
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.TemplateName
- Microsoft.Web.Media.TransformManager.JobDefinition.get_TemplateName
- Microsoft.Web.Media.TransformManager.JobDefinition.set_TemplateName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_TemplateName
- Microsoft.Web.Media.TransformManager.JobDefinition.TemplateName
- Microsoft.Web.Media.TransformManager.JobDefinition.set_TemplateName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TemplateName Property

Gets or sets the name of the job template that the current [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object uses.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyTemplateNameAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.TemplateName

instance.TemplateName = value
```

``` csharp
[DataMemberAttribute]
publicstringTemplateName { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ TemplateName {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberTemplateName : stringwithget, set
```

``` jscript
function getTemplateName () : Stringfunction setTemplateName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The name of the job template.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

