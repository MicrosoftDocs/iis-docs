---
title: ConfigurationBase.Id Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Id Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.Id
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.id(v=VS.90)
ms:contentKeyID: 35520889
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_Id
- Microsoft.Web.Media.TransformManager.ConfigurationBase.Id
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_Id
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_Id
- Microsoft.Web.Media.TransformManager.ConfigurationBase.Id
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_Id
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Id Property

Gets or sets the XML element ID of a configuration object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyIdAsStringGetSet
'Usage
DiminstanceAsConfigurationBaseDimvalueAsStringvalue = instance.Id

instance.Id = value
```

``` csharp
[DataMemberAttribute]
publicstringId { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ Id {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberId : stringwithget, set
```

``` jscript
function getId () : Stringfunction setId (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The XML ID of the IIS Transform Manager configuration.  

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

