---
title: ManifestPropertiesDictionary.Namespace Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Namespace Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.Namespace
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestpropertiesdictionary.namespace(v=VS.90)
ms:contentKeyID: 35520707
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.Namespace
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.set_Namespace
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.get_Namespace
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.get_Namespace
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.Namespace
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.set_Namespace
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Namespace Property

Gets or sets the value from the namespace attribute of the XML element.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyNamespaceAsStringGetSet
'Usage
DiminstanceAsManifestPropertiesDictionaryDimvalueAsStringvalue = instance.Namespace

instance.Namespace = value
```

``` csharp
[DataMemberAttribute]
publicstringNamespace { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ Namespace {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberNamespace : stringwithget, set
```

``` jscript
function getNamespace () : Stringfunction setNamespace (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The value of the namespace attribute of the XML element.  

## See Also

#### Reference

[ManifestPropertiesDictionary Class](manifestpropertiesdictionary-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

