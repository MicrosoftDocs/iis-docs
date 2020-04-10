---
title: ConfigurationBase Constructor (XNamespace) (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationBase Constructor (XNamespace)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ConfigurationBase.#ctor(System.Xml.Linq.XNamespace)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationbase.configurationbase(v=VS.90)
ms:contentKeyID: 35520749
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
- Microsoft.Web.Media.TransformManager.ConfigurationBase..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConfigurationBase Constructor (XNamespace)

Initializes a new instance of the [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md) class using the specified namespace.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    baseNamespace As XNamespace _
)
'Usage

  Dim baseNamespace As XNamespace

Dim instance As New ConfigurationBase(baseNamespace)
```

```csharp
  public ConfigurationBase(
    XNamespace baseNamespace
)
```

```cpp
  public:
ConfigurationBase(
    XNamespace^ baseNamespace
)
```

``` fsharp
  new : 
        baseNamespace:XNamespace -> ConfigurationBase
```

```jscript
  public function ConfigurationBase(
    baseNamespace : XNamespace
)
```

### Parameters

  - baseNamespace  
    Type: [System.Xml.Linq.XNamespace](https://msdn.microsoft.com/library/bb291898)  
    An XML namespace.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[ArgumentNullException](https://msdn.microsoft.com/library/27426hcy)|baseNamespace is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .|

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[ConfigurationBase Overload](configurationbase-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
