---
title: ConfigurationBase.LastModified Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LastModified Property
description: "The ConfigurationBase.LastModified property gets or sets the date and time when the IIS Transform Manager configuration was last modified."
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.LastModified
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationbase.lastmodified(v=VS.90)
ms:contentKeyID: 35520753
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.LastModified
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_LastModified
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_LastModified
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_LastModified
- Microsoft.Web.Media.TransformManager.ConfigurationBase.LastModified
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_LastModified
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LastModified Property

Gets or sets the date and time when the IIS Transform Manager configuration was last modified.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property LastModified As DateTime
    Get
    Set
'Usage

  Dim instance As ConfigurationBase
Dim value As DateTime

value = instance.LastModified

instance.LastModified = value
```

```csharp
[DataMemberAttribute]
public DateTime LastModified { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property DateTime LastModified {
    DateTime get ();
    void set (DateTime value);
}
```

``` fsharp
[<DataMemberAttribute>]
member LastModified : DateTime with get, set
```

```jscript
  function get LastModified () : DateTime
function set LastModified (value : DateTime)
```

### Property Value

Type: [System.DateTime](https://msdn.microsoft.com/library/03ybds8y)  
The date and time when the IIS Transform Manager configuration was last modified.  

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
