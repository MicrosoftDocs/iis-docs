---
title: ConfigurationMessage.Name Property (Microsoft.Web.Media.TransformManager)
description: This article contains information about syntax for the ConfigurationMessage.Name property. There are also links to reference materials.
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationMessage.Name
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationmessage.name(v=VS.90)
ms:contentKeyID: 35520857
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_Name
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.Name
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_Name
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_Name
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.Name
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_Name
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Name Property

Gets or sets the name of the configuration object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Name As String
    Get
    Set
'Usage

  Dim instance As ConfigurationMessage
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
The name of the configuration object.  

## See Also

### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
