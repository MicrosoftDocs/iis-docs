---
title: ManifestProperty.Name Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestProperty.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.name(v=VS.90)
ms:contentKeyID: 35520908
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Name
- Microsoft.Web.Media.TransformManager.ManifestProperty.Name
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Name
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Name
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Name
- Microsoft.Web.Media.TransformManager.ManifestProperty.Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Name Property

Gets or sets the Name element of the manifest property.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicPropertyNameAsXNameGetSet
'Usage
DiminstanceAsManifestPropertyDimvalueAsXNamevalue = instance.Name

instance.Name = value
```

``` csharp
publicXNameName { get; set; }
```

``` c++
public:
virtualpropertyXName^ Name {
    XName^ get () sealed;
    voidset (XName^ value) sealed;
}
```

``` fsharp
abstractName : XNamewithget, setoverrideName : XNamewithget, set
```

``` jscript
finalfunction getName () : XNamefinalfunction setName (value : XName)
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XName](https://msdn.microsoft.com/en-us/library/bb347810\(v=vs.90\))  
The name of the manifest property.  

#### Implements

[IManifestProperty. . :: . .Name](imanifestproperty-name-property-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

