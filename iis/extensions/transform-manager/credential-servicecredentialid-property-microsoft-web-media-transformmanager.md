---
title: Credential.ServiceCredentialId Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ServiceCredentialId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.ServiceCredentialId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.credential.servicecredentialid(v=VS.90)
ms:contentKeyID: 35520947
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.ServiceCredentialId
- Microsoft.Web.Media.TransformManager.Credential.get_ServiceCredentialId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.ServiceCredentialId
- Microsoft.Web.Media.TransformManager.Credential.get_ServiceCredentialId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ServiceCredentialId Property

Gets the value of the credential GUID that IIS Transform Manager uses to run.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared ReadOnly Property ServiceCredentialId As String
    Get
'Usage

  Dim value As String

value = Credential.ServiceCredentialId
```

```csharp
  public static string ServiceCredentialId { get; }
```

```cpp
  public:
static property String^ ServiceCredentialId {
    String^ get ();
}
```

``` fsharp
  static member ServiceCredentialId : string
```

```jscript
  static function get ServiceCredentialId () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A credential GUID.  

## See Also

### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

