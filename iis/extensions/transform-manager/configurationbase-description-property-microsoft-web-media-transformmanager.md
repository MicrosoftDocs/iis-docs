---
title: ConfigurationBase.Description Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Description Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.Description
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationbase.description(v=VS.90)
ms:contentKeyID: 35520764
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_Description
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_Description
- Microsoft.Web.Media.TransformManager.ConfigurationBase.Description
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.Description
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_Description
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_Description
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Description Property

Gets or sets a description of the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Description As String
    Get
    Set
'Usage

  Dim instance As ConfigurationBase
Dim value As String

value = instance.Description

instance.Description = value
```

```csharp
[DataMemberAttribute]
public string Description { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ Description {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Description : string with get, set
```

```jscript
  function get Description () : String
function set Description (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The description of the IIS Transform Manager configuration.  

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

