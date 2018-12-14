---
title: ManifestProperty.LocalName Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: LocalName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestProperty.LocalName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.localname(v=VS.90)
ms:contentKeyID: 35521025
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_LocalName
- Microsoft.Web.Media.TransformManager.ManifestProperty.LocalName
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_LocalName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_LocalName
- Microsoft.Web.Media.TransformManager.ManifestProperty.LocalName
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_LocalName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LocalName Property

Gets or sets the LocalName element of the manifest property.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyLocalNameAsStringGetSet
'Usage
DiminstanceAsManifestPropertyDimvalueAsStringvalue = instance.LocalName

instance.LocalName = value
```

``` csharp
[DataMemberAttribute]
publicstringLocalName { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ LocalName {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberLocalName : stringwithget, set
```

``` jscript
function getLocalName () : Stringfunction setLocalName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The local name of the manifest property.  

## See Also

#### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

