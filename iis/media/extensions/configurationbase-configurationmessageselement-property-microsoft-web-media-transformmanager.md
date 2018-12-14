---
title: ConfigurationBase.ConfigurationMessagesElement Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationMessagesElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationMessagesElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.configurationmessageselement(v=VS.90)
ms:contentKeyID: 35520977
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationMessagesElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_ConfigurationMessagesElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_ConfigurationMessagesElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationMessagesElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_ConfigurationMessagesElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_ConfigurationMessagesElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConfigurationMessagesElement Property

Gets or sets an XML element that contains configuration messages for the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyConfigurationMessagesElementAsXElementGetSet
'Usage
DiminstanceAsConfigurationBaseDimvalueAsXElementvalue = instance.ConfigurationMessagesElement

instance.ConfigurationMessagesElement = value
```

``` csharp
publicXElementConfigurationMessagesElement { get; set; }
```

``` c++
public:
propertyXElement^ ConfigurationMessagesElement {
    XElement^ get ();
    voidset (XElement^ value);
}
```

``` fsharp
memberConfigurationMessagesElement : XElementwithget, set
```

``` jscript
function getConfigurationMessagesElement () : XElementfunction setConfigurationMessagesElement (value : XElement)
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
An XML element that contains configuration messages.  

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

