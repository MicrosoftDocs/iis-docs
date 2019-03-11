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
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Utilities.FindElement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# FindElement Method (XContainer, XNamespace, String, Boolean)

Finds a specific element in the container by using the XML container, the XML container namespace, the XML element name, and a value that specifies whether the descendant elements should be searched.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function FindElement ( _
    container As XContainer, _
    containerNamespace As XNamespace, _
    elementName As String, _
    searchChildren As Boolean _
) As XElement
'Usage

  Dim container As XContainer
Dim containerNamespace As XNamespace
Dim elementName As String
Dim searchChildren As Boolean
Dim returnValue As XElement

returnValue = Utilities.FindElement(container, _
    containerNamespace, elementName, _
    searchChildren)
```

```csharp
  public static XElement FindElement(
    XContainer container,
    XNamespace containerNamespace,
    string elementName,
    bool searchChildren
)
```

```cpp
  public:
static XElement^ FindElement(
    XContainer^ container, 
    XNamespace^ containerNamespace, 
    String^ elementName, 
    bool searchChildren
)
```

``` fsharp
  static member FindElement : 
        container:XContainer * 
        containerNamespace:XNamespace * 
        elementName:string * 
        searchChildren:bool -> XElement 
```

```jscript
  public static function FindElement(
    container : XContainer, 
    containerNamespace : XNamespace, 
    elementName : String, 
    searchChildren : boolean
) : XElement
```

### Parameters

  - container  
    Type: [System.Xml.Linq.XContainer](https://msdn.microsoft.com/library/bb353736)  
    An XML node to search.  

<!-- end list -->

  - containerNamespace  
    Type: [System.Xml.Linq.XNamespace](https://msdn.microsoft.com/library/bb291898)  
    The XML namespace of the XML container node.  

<!-- end list -->

  - elementName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the XML element to find.  

<!-- end list -->

  - searchChildren  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
    true if the descendant elements should be searched; otherwise, false.  

### Return Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  

## Exceptions

|Exception|Condition|
|--- |--- |
|[ArgumentNullException](https://msdn.microsoft.com/library/27426hcy)|container, containerNamespace, or elementName is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .|

## See Also

### Reference

[Utilities Class](utilities-class-microsoft-web-media-transformmanager.md)

[FindElement Overload](utilities-findelement-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

