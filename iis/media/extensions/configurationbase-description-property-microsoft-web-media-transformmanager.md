---
title: ConfigurationBase.Description Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Description Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.Description
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.description(v=VS.90)
ms:contentKeyID: 35520764
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_Description
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_Description
- Microsoft.Web.Media.TransformManager.ConfigurationBase.Description
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.Description
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_Description
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_Description
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Description Property

Gets or sets a description of the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyDescriptionAsStringGetSet
'Usage
DiminstanceAsConfigurationBaseDimvalueAsStringvalue = instance.Description

instance.Description = value
```

``` csharp
[DataMemberAttribute]
publicstringDescription { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ Description {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberDescription : stringwithget, set
```

``` jscript
function getDescription () : Stringfunction setDescription (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The description of the IIS Transform Manager configuration.  

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

