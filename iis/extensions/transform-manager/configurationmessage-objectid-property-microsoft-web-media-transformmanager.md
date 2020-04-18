---
title: ConfigurationMessage.ObjectId Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ObjectId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationMessage.ObjectId
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationmessage.objectid(v=VS.90)
ms:contentKeyID: 35520624
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_ObjectId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_ObjectId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.ObjectId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_ObjectId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.ObjectId
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_ObjectId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ObjectId Property

Gets or sets the ID of configuration object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property ObjectId As String
    Get
    Set
'Usage

  Dim instance As ConfigurationMessage
Dim value As String

value = instance.ObjectId

instance.ObjectId = value
```

```csharp
[DataMemberAttribute]
public string ObjectId { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ ObjectId {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member ObjectId : string with get, set
```

```jscript
  function get ObjectId () : String
function set ObjectId (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The ID of configuration object.  

## See Also

### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
