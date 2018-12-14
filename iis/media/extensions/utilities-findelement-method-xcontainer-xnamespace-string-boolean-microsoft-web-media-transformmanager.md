---
title: Utilities.FindElement Method (XContainer, XNamespace, String, Boolean) (Microsoft.Web.Media.TransformManager)
TOCTitle: FindElement Method (XContainer, XNamespace, String, Boolean)
ms:assetid: M:Microsoft.Web.Media.TransformManager.Utilities.FindElement(System.Xml.Linq.XContainer,System.Xml.Linq.XNamespace,System.String,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.utilities.findelement(v=VS.90)
ms:contentKeyID: 35521076
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
- Microsoft.Web.Media.TransformManager.Utilities.FindElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FindElement Method (XContainer, XNamespace, String, Boolean)

Finds a specific element in the container by using the XML container, the XML container namespace, the XML element name, and a value that specifies whether the descendant elements should be searched.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionFindElement ( _
    containerAsXContainer, _
    containerNamespaceAsXNamespace, _
    elementNameAsString, _
    searchChildrenAsBoolean _
) AsXElement
'Usage
DimcontainerAsXContainerDimcontainerNamespaceAsXNamespaceDimelementNameAsStringDimsearchChildrenAsBooleanDimreturnValueAsXElementreturnValue = Utilities.FindElement(container, _
    containerNamespace, elementName, _
    searchChildren)
```

``` csharp
publicstaticXElementFindElement(
    XContainercontainer,
    XNamespacecontainerNamespace,
    stringelementName,
    boolsearchChildren
)
```

``` c++
public:
staticXElement^ FindElement(
    XContainer^ container, 
    XNamespace^ containerNamespace, 
    String^ elementName, 
    boolsearchChildren
)
```

``` fsharp
staticmemberFindElement : 
        container:XContainer * 
        containerNamespace:XNamespace * 
        elementName:string * 
        searchChildren:bool->XElement
```

``` jscript
publicstaticfunctionFindElement(
    container : XContainer, 
    containerNamespace : XNamespace, 
    elementName : String, 
    searchChildren : boolean
) : XElement
```

#### Parameters

  - container  
    Type: [System.Xml.Linq. . :: . .XContainer](https://msdn.microsoft.com/en-us/library/bb353736\(v=vs.90\))  
    An XML node to search.  

<!-- end list -->

  - containerNamespace  
    Type: [System.Xml.Linq. . :: . .XNamespace](https://msdn.microsoft.com/en-us/library/bb291898\(v=vs.90\))  
    The XML namespace of the XML container node.  

<!-- end list -->

  - elementName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the XML element to find.  

<!-- end list -->

  - searchChildren  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
    true if the descendant elements should be searched; otherwise, false.  

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
<td><p>container, containerNamespace, or elementName is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[Utilities Class](utilities-class-microsoft-web-media-transformmanager.md)

[FindElement Overload](utilities-findelement-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

