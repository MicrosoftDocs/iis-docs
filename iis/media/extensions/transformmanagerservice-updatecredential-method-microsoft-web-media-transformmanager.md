---
title: TransformManagerService.UpdateCredential Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateCredential Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateCredential(Microsoft.Web.Media.TransformManager.Credential)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.updatecredential(v=VS.90)
ms:contentKeyID: 35520608
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateCredential
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateCredential
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# UpdateCredential Method

Adds or replaces a [Credential](credential-class-microsoft-web-media-transformmanager.md) object that is in the credential store of the service account.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicSubUpdateCredential ( _
    credentialAsCredential _
)
'Usage
DiminstanceAsTransformManagerServiceDimcredentialAsCredential

instance.UpdateCredential(credential)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicvoidUpdateCredential(
    Credentialcredential
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualvoidUpdateCredential(
    Credential^ credential
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractUpdateCredential : 
        credential:Credential->unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideUpdateCredential : 
        credential:Credential->unit
```

``` jscript
publicfinalfunctionUpdateCredential(
    credential : Credential
)
```

#### Parameters

  - credential  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .Credential](credential-class-microsoft-web-media-transformmanager.md)  
    A new or existing [Credential](credential-class-microsoft-web-media-transformmanager.md) object.  

#### Implements

[IManagementService. . :: . .UpdateCredential(Credential)](imanagementservice-updatecredential-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

