---
title: ConfigurationMessage.RegKeyFound Property (Microsoft.Web.Media.TransformManager)
description: Describes the RegKeyFound property type associated with Microsoft.Web.Media.TransformManager and details its properties.
TOCTitle: RegKeyFound Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationMessage.RegKeyFound
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationmessage.regkeyfound(v=VS.90)
ms:contentKeyID: 35521134
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_RegKeyFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.RegKeyFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_RegKeyFound
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_RegKeyFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.RegKeyFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_RegKeyFound
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# RegKeyFound Property

Gets or sets a message to post when the registration key value is found.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property RegKeyFound As String
    Get
    Set
'Usage

  Dim instance As ConfigurationMessage
Dim value As String

value = instance.RegKeyFound

instance.RegKeyFound = value
```

```csharp
[DataMemberAttribute]
public string RegKeyFound { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ RegKeyFound {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member RegKeyFound : string with get, set
```

```jscript
  function get RegKeyFound () : String
function set RegKeyFound (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The message that is posted when the registration key is found.  

## See Also

### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
