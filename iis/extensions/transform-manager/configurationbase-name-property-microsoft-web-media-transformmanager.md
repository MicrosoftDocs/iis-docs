---
title: ConfigurationBase.Name Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.name(v=VS.90)
ms:contentKeyID: 35520942
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.Name
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_Name
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_Name
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_Name
- Microsoft.Web.Media.TransformManager.ConfigurationBase.Name
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Name Property

Gets or sets the XML element name of the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Name As String
    Get
    Set
'Usage

  Dim instance As ConfigurationBase
Dim value As String

value = instance.Name

instance.Name = value
```

```csharp
[DataMemberAttribute]
public string Name { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ Name {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Name : string with get, set
```

```jscript
  function get Name () : String
function set Name (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The name of the XML element.  

## Remarks

This property is a string value that is the name of the configuration object that this object is the base of. The base class exposes properties and a corresponding XElement object that is useful for creating the XML representation for persistence.

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

