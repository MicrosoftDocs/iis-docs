---
title: TransformManagerService.GetCredential Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetCredential Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetCredential(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getcredential(v=VS.90)
ms:contentKeyID: 35520826
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetCredential
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetCredential
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetCredential Method

Returns a [Credential](credential-class-microsoft-web-media-transformmanager.md) object from the credential store of the service account.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionGetCredential ( _
    credentialIdAsString _
) AsCredential
'Usage
DiminstanceAsTransformManagerServiceDimcredentialIdAsStringDimreturnValueAsCredentialreturnValue = instance.GetCredential(credentialId)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicCredentialGetCredential(
    stringcredentialId
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualCredential^ GetCredential(
    String^ credentialId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractGetCredential : 
        credentialId:string->Credential 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideGetCredential : 
        credentialId:string->Credential
```

``` jscript
publicfinalfunctionGetCredential(
    credentialId : String
) : Credential
```

#### Parameters

  - credentialId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of a [Credential](credential-class-microsoft-web-media-transformmanager.md) object to get.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .Credential](credential-class-microsoft-web-media-transformmanager.md)  

#### Implements

[IManagementService. . :: . .GetCredential(String)](imanagementservice-getcredential-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

