---
title: ManifestPropertiesDictionary Constructor (XElement) (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestPropertiesDictionary Constructor (XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.#ctor(System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestpropertiesdictionary.manifestpropertiesdictionary(v=VS.90)
ms:contentKeyID: 35520558
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ManifestPropertiesDictionary Constructor (XElement)

Initializes a new instance of the [ManifestPropertiesDictionary](manifestpropertiesdictionary-class-microsoft-web-media-transformmanager.md) class using the specified properties.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    propertiesAsXElement _
)
'Usage
DimpropertiesAsXElementDiminstanceAs NewManifestPropertiesDictionary(properties)
```

``` csharp
publicManifestPropertiesDictionary(
    XElementproperties
)
```

``` c++
public:
ManifestPropertiesDictionary(
    XElement^ properties
)
```

``` fsharp
new : 
        properties:XElement->ManifestPropertiesDictionary
```

``` jscript
publicfunctionManifestPropertiesDictionary(
    properties : XElement
)
```

#### Parameters

  - properties  
    Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
    An XML element that contains properties.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>InvalidDataException</td>
<td><p>The element is equivalent to null or has no elements.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[ManifestPropertiesDictionary Class](manifestpropertiesdictionary-class-microsoft-web-media-transformmanager.md)

[ManifestPropertiesDictionary Overload](manifestpropertiesdictionary-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

