---
title: Credential.Description Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Description Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.Description
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.credential.description(v=VS.90)
ms:contentKeyID: 35520791
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.set_Description
- Microsoft.Web.Media.TransformManager.Credential.Description
- Microsoft.Web.Media.TransformManager.Credential.get_Description
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.Description
- Microsoft.Web.Media.TransformManager.Credential.get_Description
- Microsoft.Web.Media.TransformManager.Credential.set_Description
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Description Property

Gets or sets the credential description.

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

  Dim instance As Credential
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
The credential description.  

## See Also

### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

