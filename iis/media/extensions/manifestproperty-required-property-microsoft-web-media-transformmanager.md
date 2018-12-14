---
title: ManifestProperty.Required Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Required Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestProperty.Required
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.required(v=VS.90)
ms:contentKeyID: 35520627
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.Required
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Required
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Required
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Required
- Microsoft.Web.Media.TransformManager.ManifestProperty.Required
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Required
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Required Property

Get or sets a value that specifies whether the manifest property is required.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyRequiredAsBooleanGetSet
'Usage
DiminstanceAsManifestPropertyDimvalueAsBooleanvalue = instance.Required

instance.Required = value
```

``` csharp
[DataMemberAttribute]
publicboolRequired { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyboolRequired {
    boolget ();
    voidset (boolvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberRequired : boolwithget, set
```

``` jscript
function getRequired () : booleanfunction setRequired (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the manifest property is required; otherwise, false.  

## See Also

#### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

