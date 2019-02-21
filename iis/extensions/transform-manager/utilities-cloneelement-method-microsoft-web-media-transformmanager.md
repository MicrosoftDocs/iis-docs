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
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
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
---

# CloneElement Method

Creates a duplicate of the provided element.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function CloneElement ( _
    element As XElement, _
    targetNamespace As XNamespace _
) As XElement
'Usage

  Dim element As XElement
Dim targetNamespace As XNamespace
Dim returnValue As XElement

returnValue = Utilities.CloneElement(element, _
    targetNamespace)
```

```csharp
  public static XElement CloneElement(
    XElement element,
    XNamespace targetNamespace
)
```

```cpp
  public:
static XElement^ CloneElement(
    XElement^ element, 
    XNamespace^ targetNamespace
)
```

``` fsharp
  static member CloneElement : 
        element:XElement * 
        targetNamespace:XNamespace -> XElement 
```

```jscript
  public static function CloneElement(
    element : XElement, 
    targetNamespace : XNamespace
) : XElement
```

### Parameters

  - element  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    The element to clone.  

<!-- end list -->

  - targetNamespace  
    Type: [System.Xml.Linq.XNamespace](https://msdn.microsoft.com/library/bb291898)  
    The namespace of the element to clone.  

### Return Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  

## Exceptions

|Exception|Condition|
|--- |--- |
|[ArgumentNullException](https://msdn.microsoft.com/library/27426hcy)|element is null Nothing nullptr unit a null reference (Nothing in Visual Basic)|
|[ArgumentNullException](https://msdn.microsoft.com/library/27426hcy)|targetNamespace is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .|

## See Also

### Reference

[Utilities Class](utilities-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

