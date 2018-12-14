---
title: TransformManagerService.DeleteCredential Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteCredential Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteCredential(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.deletecredential(v=VS.90)
ms:contentKeyID: 35520833
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteCredential
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteCredential
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeleteCredential Method

Deletes a [Credential](credential-class-microsoft-web-media-transformmanager.md) object for the service account from the Generic Credentials vault in Windows Credential Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicSubDeleteCredential ( _
    credentialIdAsString _
)
'Usage
DiminstanceAsTransformManagerServiceDimcredentialIdAsString

instance.DeleteCredential(credentialId)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicvoidDeleteCredential(
    stringcredentialId
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualvoidDeleteCredential(
    String^ credentialId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractDeleteCredential : 
        credentialId:string->unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideDeleteCredential : 
        credentialId:string->unit
```

``` jscript
publicfinalfunctionDeleteCredential(
    credentialId : String
)
```

#### Parameters

  - credentialId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the [Credential](credential-class-microsoft-web-media-transformmanager.md) object to delete.  

#### Implements

[IManagementService. . :: . .DeleteCredential(String)](imanagementservice-deletecredential-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

