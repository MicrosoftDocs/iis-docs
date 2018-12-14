---
title: Utilities.FindElement Method (XContainer, XNamespace, String) (Microsoft.Web.Media.TransformManager)
TOCTitle: FindElement Method (XContainer, XNamespace, String)
ms:assetid: M:Microsoft.Web.Media.TransformManager.Utilities.FindElement(System.Xml.Linq.XContainer,System.Xml.Linq.XNamespace,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.utilities.findelement(v=VS.90)
ms:contentKeyID: 35520614
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

# FindElement Method (XContainer, XNamespace, String)

Finds a specific element in the container by using the XML container, the XML container namespace, and the XML element name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionFindElement ( _
    containerAsXContainer, _
    containerNamespaceAsXNamespace, _
    elementNameAsString _
) AsXElement
'Usage
DimcontainerAsXContainerDimcontainerNamespaceAsXNamespaceDimelementNameAsStringDimreturnValueAsXElementreturnValue = Utilities.FindElement(container, _
    containerNamespace, elementName)
```

``` csharp
publicstaticXElementFindElement(
    XContainercontainer,
    XNamespacecontainerNamespace,
    stringelementName
)
```

``` c++
public:
staticXElement^ FindElement(
    XContainer^ container, 
    XNamespace^ containerNamespace, 
    String^ elementName
)
```

``` fsharp
staticmemberFindElement : 
        container:XContainer * 
        containerNamespace:XNamespace * 
        elementName:string->XElement
```

``` jscript
publicstaticfunctionFindElement(
    container : XContainer, 
    containerNamespace : XNamespace, 
    elementName : String
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

#### Return Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  

## See Also

#### Reference

[Utilities Class](utilities-class-microsoft-web-media-transformmanager.md)

[FindElement Overload](utilities-findelement-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

