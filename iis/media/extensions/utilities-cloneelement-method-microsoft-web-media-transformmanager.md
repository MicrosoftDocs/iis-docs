---
title: Utilities.CloneElement Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CloneElement Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Utilities.CloneElement(System.Xml.Linq.XElement,System.Xml.Linq.XNamespace)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.utilities.cloneelement(v=VS.90)
ms:contentKeyID: 35521016
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Utilities.CloneElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Utilities.CloneElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CloneElement Method

Creates a duplicate of the provided element.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionCloneElement ( _
    elementAsXElement, _
    targetNamespaceAsXNamespace _
) AsXElement
'Usage
DimelementAsXElementDimtargetNamespaceAsXNamespaceDimreturnValueAsXElementreturnValue = Utilities.CloneElement(element, _
    targetNamespace)
```

``` csharp
publicstaticXElementCloneElement(
    XElementelement,
    XNamespacetargetNamespace
)
```

``` c++
public:
staticXElement^ CloneElement(
    XElement^ element, 
    XNamespace^ targetNamespace
)
```

``` fsharp
staticmemberCloneElement : 
        element:XElement * 
        targetNamespace:XNamespace->XElement
```

``` jscript
publicstaticfunctionCloneElement(
    element : XElement, 
    targetNamespace : XNamespace
) : XElement
```

#### Parameters

  - element  
    Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
    The element to clone.  

<!-- end list -->

  - targetNamespace  
    Type: [System.Xml.Linq. . :: . .XNamespace](https://msdn.microsoft.com/en-us/library/bb291898\(v=vs.90\))  
    The namespace of the element to clone.  

#### Return Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  

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
<td><p>element is null Nothing nullptr unit a null reference (Nothing in Visual Basic)</p></td>
</tr>
<tr class="even">
<td><a href="https://msdn.microsoft.com/en-us/library/27426hcy(v=vs.90)">ArgumentNullException</a></td>
<td><p>targetNamespace is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[Utilities Class](utilities-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

