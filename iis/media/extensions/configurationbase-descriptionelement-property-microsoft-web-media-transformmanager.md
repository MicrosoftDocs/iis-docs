---
title: ConfigurationBase.DescriptionElement Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: DescriptionElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.DescriptionElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.descriptionelement(v=VS.90)
ms:contentKeyID: 35521184
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.DescriptionElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_DescriptionElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_DescriptionElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.DescriptionElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_DescriptionElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_DescriptionElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DescriptionElement Property

Gets or set the XML element that contains the description of the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyDescriptionElementAsXElementGetSet
'Usage
DiminstanceAsConfigurationBaseDimvalueAsXElementvalue = instance.DescriptionElement

instance.DescriptionElement = value
```

``` csharp
publicXElementDescriptionElement { get; set; }
```

``` c++
public:
propertyXElement^ DescriptionElement {
    XElement^ get ();
    voidset (XElement^ value);
}
```

``` fsharp
memberDescriptionElement : XElementwithget, set
```

``` jscript
function getDescriptionElement () : XElementfunction setDescriptionElement (value : XElement)
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The XML element that contains the description of the IIS Transform Manager configuration.  

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

