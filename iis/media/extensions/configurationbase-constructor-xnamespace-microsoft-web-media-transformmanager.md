---
title: ConfigurationBase Constructor (XNamespace) (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationBase Constructor (XNamespace)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ConfigurationBase.#ctor(System.Xml.Linq.XNamespace)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.configurationbase(v=VS.90)
ms:contentKeyID: 35520749
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
- Microsoft.Web.Media.TransformManager.ConfigurationBase..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConfigurationBase Constructor (XNamespace)

Initializes a new instance of the [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md) class using the specified namespace.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    baseNamespaceAsXNamespace _
)
'Usage
DimbaseNamespaceAsXNamespaceDiminstanceAs NewConfigurationBase(baseNamespace)
```

``` csharp
publicConfigurationBase(
    XNamespacebaseNamespace
)
```

``` c++
public:
ConfigurationBase(
    XNamespace^ baseNamespace
)
```

``` fsharp
new : 
        baseNamespace:XNamespace->ConfigurationBase
```

``` jscript
publicfunctionConfigurationBase(
    baseNamespace : XNamespace
)
```

#### Parameters

  - baseNamespace  
    Type: [System.Xml.Linq. . :: . .XNamespace](https://msdn.microsoft.com/en-us/library/bb291898\(v=vs.90\))  
    An XML namespace.  

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
<td><a href="https://msdn.microsoft.com/en-us/library/27426hcy(v=vs.90)">ArgumentNullException</a></td>
<td><p>baseNamespace is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[ConfigurationBase Overload](configurationbase-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

