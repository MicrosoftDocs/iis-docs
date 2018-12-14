---
title: ManifestProperty.CultureInfo Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: CultureInfo Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestProperty.CultureInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.cultureinfo(v=VS.90)
ms:contentKeyID: 35520795
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_CultureInfo
- Microsoft.Web.Media.TransformManager.ManifestProperty.CultureInfo
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_CultureInfo
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.CultureInfo
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_CultureInfo
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_CultureInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CultureInfo Property

Gets or sets the culture information for the manifest property.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicPropertyCultureInfoAsCultureInfoGetSet
'Usage
DiminstanceAsManifestPropertyDimvalueAsCultureInfovalue = instance.CultureInfo

instance.CultureInfo = value
```

``` csharp
publicCultureInfoCultureInfo { get; set; }
```

``` c++
public:
virtualpropertyCultureInfo^ CultureInfo {
    CultureInfo^ get () sealed;
    voidset (CultureInfo^ value) sealed;
}
```

``` fsharp
abstractCultureInfo : CultureInfowithget, setoverrideCultureInfo : CultureInfowithget, set
```

``` jscript
finalfunction getCultureInfo () : CultureInfofinalfunction setCultureInfo (value : CultureInfo)
```

#### Property Value

Type: [System.Globalization. . :: . .CultureInfo](https://msdn.microsoft.com/en-us/library/kx54z3k7\(v=vs.90\))  
The culture information for the manifest property.  

#### Implements

[IManifestProperty. . :: . .CultureInfo](imanifestproperty-cultureinfo-property-microsoft-web-media-transformmanager.md)  

## Remarks

Culture information includes information about a specific culture, including the name of the culture, the writing system, and the calendar used, as well as access to culture-specific objects that provide information for common operations, such as formatting dates and sorting strings.

## See Also

#### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

