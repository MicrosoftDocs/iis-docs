---
title: Credential.UserName Property (Microsoft.Web.Media.TransformManager)
TOCTitle: UserName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.UserName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.credential.username(v=VS.90)
ms:contentKeyID: 35520664
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.set_UserName
- Microsoft.Web.Media.TransformManager.Credential.get_UserName
- Microsoft.Web.Media.TransformManager.Credential.UserName
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.get_UserName
- Microsoft.Web.Media.TransformManager.Credential.set_UserName
- Microsoft.Web.Media.TransformManager.Credential.UserName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# UserName Property

Gets or sets a credential user name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property UserName As String
    Get
    Set
'Usage

  Dim instance As Credential
Dim value As String

value = instance.UserName

instance.UserName = value
```

```csharp
[DataMemberAttribute]
public string UserName { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ UserName {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member UserName : string with get, set
```

```jscript
  function get UserName () : String
function set UserName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A credential user name.  

## See Also

### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

