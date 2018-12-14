---
title: ConfigurationBase.IdElement Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: IdElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.IdElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.idelement(v=VS.90)
ms:contentKeyID: 35520938
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.IdElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_IdElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_IdElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_IdElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.IdElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_IdElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IdElement Property

Gets or sets the XML ID element of a configuration object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyIdElementAsXElementGetSet
'Usage
DiminstanceAsConfigurationBaseDimvalueAsXElementvalue = instance.IdElement

instance.IdElement = value
```

``` csharp
publicXElementIdElement { get; set; }
```

``` c++
public:
propertyXElement^ IdElement {
    XElement^ get ();
    voidset (XElement^ value);
}
```

``` fsharp
memberIdElement : XElementwithget, set
```

``` jscript
function getIdElement () : XElementfunction setIdElement (value : XElement)
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The XML ID element of the IIS Transform Manager configuration.  

## Remarks

This property is an XElement object whose value is the ID of this configuration object. The XElement contains more information than just the value; in particular, it contains namespace information.

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

