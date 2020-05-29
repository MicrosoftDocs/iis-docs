---
title: Credential.Id Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Id Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.Id
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.credential.id(v=VS.90)
ms:contentKeyID: 35521167
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.Id
- Microsoft.Web.Media.TransformManager.Credential.set_Id
- Microsoft.Web.Media.TransformManager.Credential.get_Id
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.get_Id
- Microsoft.Web.Media.TransformManager.Credential.Id
- Microsoft.Web.Media.TransformManager.Credential.set_Id
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Id Property

Gets or sets an internal credential ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Id As String
    Get
    Set
'Usage

  Dim instance As Credential
Dim value As String

value = instance.Id

instance.Id = value
```

```csharp
[DataMemberAttribute]
public string Id { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ Id {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Id : string with get, set
```

```jscript
  function get Id () : String
function set Id (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A credential ID.  

## See Also

### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
