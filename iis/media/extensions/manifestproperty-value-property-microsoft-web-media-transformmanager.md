---
title: ManifestProperty.Value Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Value Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestProperty.Value
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.value(v=VS.90)
ms:contentKeyID: 35521030
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Value
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Value
- Microsoft.Web.Media.TransformManager.ManifestProperty.Value
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Value
- Microsoft.Web.Media.TransformManager.ManifestProperty.Value
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Value
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Value Property

Gets or sets the manifest property value.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyValueAsStringGetSet
'Usage
DiminstanceAsManifestPropertyDimvalueAsStringvalue = instance.Value

instance.Value = value
```

``` csharp
[DataMemberAttribute]
publicstringValue { get; set; }
```

``` c++
[DataMemberAttribute]
public:
virtualpropertyString^ Value {
    String^ get () sealed;
    voidset (String^ value) sealed;
}
```

``` fsharp
[<DataMemberAttribute>]
abstractValue : stringwithget, set
[<DataMemberAttribute>]
overrideValue : stringwithget, set
```

``` jscript
finalfunction getValue () : Stringfinalfunction setValue (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The value of the manifest property.  

#### Implements

[IManifestProperty. . :: . .Value](imanifestproperty-value-property-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

