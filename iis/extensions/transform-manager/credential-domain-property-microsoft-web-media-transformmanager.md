---
title: Credential.Domain Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Domain Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.Domain
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.credential.domain(v=VS.90)
ms:contentKeyID: 35520701
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.get_Domain
- Microsoft.Web.Media.TransformManager.Credential.Domain
- Microsoft.Web.Media.TransformManager.Credential.set_Domain
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.Domain
- Microsoft.Web.Media.TransformManager.Credential.get_Domain
- Microsoft.Web.Media.TransformManager.Credential.set_Domain
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Domain Property

Gets or sets the credential domain.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Domain As String
    Get
    Set
'Usage

  Dim instance As Credential
Dim value As String

value = instance.Domain

instance.Domain = value
```

```csharp
[DataMemberAttribute]
public string Domain { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ Domain {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Domain : string with get, set
```

```jscript
  function get Domain () : String
function set Domain (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The credential domain.  

## See Also

### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

