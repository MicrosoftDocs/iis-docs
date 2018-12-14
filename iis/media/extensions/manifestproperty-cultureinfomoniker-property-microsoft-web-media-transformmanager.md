---
title: ManifestProperty.CultureInfoMoniker Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: CultureInfoMoniker Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestProperty.CultureInfoMoniker
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.cultureinfomoniker(v=VS.90)
ms:contentKeyID: 35521031
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.CultureInfoMoniker
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_CultureInfoMoniker
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_CultureInfoMoniker
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.CultureInfoMoniker
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_CultureInfoMoniker
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_CultureInfoMoniker
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CultureInfoMoniker Property

Gets or sets a value that represents the culture language.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyCultureInfoMonikerAsStringGetSet
'Usage
DiminstanceAsManifestPropertyDimvalueAsStringvalue = instance.CultureInfoMoniker

instance.CultureInfoMoniker = value
```

``` csharp
[DataMemberAttribute]
publicstringCultureInfoMoniker { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ CultureInfoMoniker {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberCultureInfoMoniker : stringwithget, set
```

``` jscript
function getCultureInfoMoniker () : Stringfunction setCultureInfoMoniker (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The culture language.  

## See Also

#### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

