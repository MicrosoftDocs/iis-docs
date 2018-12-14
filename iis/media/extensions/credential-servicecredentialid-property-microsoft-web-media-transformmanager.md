---
title: Credential.ServiceCredentialId Property  (Microsoft.Web.Media.TransformManager)
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
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.get_ServiceCredentialId
- Microsoft.Web.Media.TransformManager.Credential.ServiceCredentialId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ServiceCredentialId Property

Gets the value of the credential GUID that IIS Transform Manager uses to run.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedReadOnlyPropertyServiceCredentialIdAsStringGet
'Usage
DimvalueAsStringvalue = Credential.ServiceCredentialId
```

``` csharp
publicstaticstringServiceCredentialId { get; }
```

``` c++
public:
staticpropertyString^ ServiceCredentialId {
    String^ get ();
}
```

``` fsharp
staticmemberServiceCredentialId : string
```

``` jscript
staticfunction getServiceCredentialId () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A credential GUID.  

## See Also

#### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

