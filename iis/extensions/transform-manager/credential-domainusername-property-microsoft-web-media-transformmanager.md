---
title: Credential.DomainUserName Property (Microsoft.Web.Media.TransformManager)
description: Learn how the DomainUserName property gets or sets the credential domain that uses the credential user name.
TOCTitle: DomainUserName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.DomainUserName
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.credential.domainusername(v=VS.90)
ms:contentKeyID: 35521186
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.DomainUserName
- Microsoft.Web.Media.TransformManager.Credential.get_DomainUserName
- Microsoft.Web.Media.TransformManager.Credential.set_DomainUserName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.DomainUserName
- Microsoft.Web.Media.TransformManager.Credential.get_DomainUserName
- Microsoft.Web.Media.TransformManager.Credential.set_DomainUserName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DomainUserName Property

Gets or sets the credential domain that uses the credential user name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property DomainUserName As String
    Get
    Set
'Usage

  Dim instance As Credential
Dim value As String

value = instance.DomainUserName

instance.DomainUserName = value
```

```csharp
[DataMemberAttribute]
public string DomainUserName { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ DomainUserName {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member DomainUserName : string with get, set
```

```jscript
  function get DomainUserName () : String
function set DomainUserName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The credential domain that uses the credential user name.  

## See Also

### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
