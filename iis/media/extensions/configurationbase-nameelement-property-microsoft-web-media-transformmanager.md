---
title: ConfigurationBase.NameElement Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: NameElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.NameElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.nameelement(v=VS.90)
ms:contentKeyID: 35520928
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_NameElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_NameElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.NameElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_NameElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.NameElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_NameElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# NameElement Property

Gets or sets an XML element that contains name details.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyNameElementAsXElementGetSet
'Usage
DiminstanceAsConfigurationBaseDimvalueAsXElementvalue = instance.NameElement

instance.NameElement = value
```

``` csharp
publicXElementNameElement { get; set; }
```

``` c++
public:
propertyXElement^ NameElement {
    XElement^ get ();
    voidset (XElement^ value);
}
```

``` fsharp
memberNameElement : XElementwithget, set
```

``` jscript
function getNameElement () : XElementfunction setNameElement (value : XElement)
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The XML element that contains name details.  

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

