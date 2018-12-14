---
title: ManifestProperty Constructor (XName, String) (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestProperty Constructor (XName, String)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ManifestProperty.#ctor(System.Xml.Linq.XName,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.manifestproperty(v=VS.90)
ms:contentKeyID: 31477655
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ManifestProperty Constructor (XName, String)

Initializes a new instance of the [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md) class using the specified name and value.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    nameAsXName, _
    valueAsString _
)
'Usage
DimnameAsXNameDimvalueAsStringDiminstanceAs NewManifestProperty(name, value)
```

``` csharp
publicManifestProperty(
    XNamename,
    stringvalue
)
```

``` c++
public:
ManifestProperty(
    XName^ name, 
    String^ value
)
```

``` fsharp
new : 
        name:XName * 
        value:string->ManifestProperty
```

``` jscript
publicfunctionManifestProperty(
    name : XName, 
    value : String
)
```

#### Parameters

  - name  
    Type: [System.Xml.Linq. . :: . .XName](https://msdn.microsoft.com/en-us/library/bb347810\(v=vs.90\))  
    The name of the manifest property.  

<!-- end list -->

  - value  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The value of the manifest property.  

## See Also

#### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[ManifestProperty Overload](manifestproperty-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

