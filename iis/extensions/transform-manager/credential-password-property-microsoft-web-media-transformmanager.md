---
title: Credential.Password Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Password Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.Password
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.credential.password(v=VS.90)
ms:contentKeyID: 35521012
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.get_Password
- Microsoft.Web.Media.TransformManager.Credential.set_Password
- Microsoft.Web.Media.TransformManager.Credential.Password
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.get_Password
- Microsoft.Web.Media.TransformManager.Credential.Password
- Microsoft.Web.Media.TransformManager.Credential.set_Password
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Password Property

Gets or sets an internal credential password.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Password As String
    Get
    Set
'Usage

  Dim instance As Credential
Dim value As String

value = instance.Password

instance.Password = value
```

```csharp
[DataMemberAttribute]
public string Password { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ Password {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Password : string with get, set
```

```jscript
  function get Password () : String
function set Password (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A credential password.  

## See Also

### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
