---
title: ConfigurationBase.BaseNamespace Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: BaseNamespace Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.BaseNamespace
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.basenamespace(v=VS.90)
ms:contentKeyID: 35521160
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.BaseNamespace
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_BaseNamespace
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_BaseNamespace
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.BaseNamespace
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_BaseNamespace
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_BaseNamespace
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# BaseNamespace Property

Gets or sets the XML namespace for the configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyBaseNamespaceAsXNamespaceGetSet
'Usage
DiminstanceAsConfigurationBaseDimvalueAsXNamespacevalue = instance.BaseNamespace

instance.BaseNamespace = value
```

``` csharp
publicXNamespaceBaseNamespace { get; set; }
```

``` c++
public:
propertyXNamespace^ BaseNamespace {
    XNamespace^ get ();
    voidset (XNamespace^ value);
}
```

``` fsharp
memberBaseNamespace : XNamespacewithget, set
```

``` jscript
function getBaseNamespace () : XNamespacefunction setBaseNamespace (value : XNamespace)
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XNamespace](https://msdn.microsoft.com/en-us/library/bb291898\(v=vs.90\))  
The XML namespace.  

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

