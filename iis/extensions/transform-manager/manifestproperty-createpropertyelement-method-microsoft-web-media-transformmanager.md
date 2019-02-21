---
title: ManifestProperty.CreatePropertyElement Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CreatePropertyElement Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.ManifestProperty.CreatePropertyElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.createpropertyelement(v=VS.90)
ms:contentKeyID: 35521196
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.CreatePropertyElement
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.CreatePropertyElement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CreatePropertyElement Method

Creates a manifest property element.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Function CreatePropertyElement As XElement
'Usage

  Dim instance As ManifestProperty
Dim returnValue As XElement

returnValue = instance.CreatePropertyElement()
```

```csharp
  public XElement CreatePropertyElement()
```

```cpp
  public:
XElement^ CreatePropertyElement()
```

``` fsharp
  member CreatePropertyElement : unit -> XElement 
```

```jscript
  public function CreatePropertyElement() : XElement
```

### Return Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The manifest property element.  

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

