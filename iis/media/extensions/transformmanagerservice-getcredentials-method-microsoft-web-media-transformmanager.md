---
title: TransformManagerService.GetCredentials Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetCredentials Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetCredentials
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getcredentials(v=VS.90)
ms:contentKeyID: 35520941
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetCredentials
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetCredentials
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetCredentials Method

Returns all of the [Credential](credential-class-microsoft-web-media-transformmanager.md) objects from the credential store of the service account.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionGetCredentialsAsCollection(OfCredential)
'Usage
DiminstanceAsTransformManagerServiceDimreturnValueAsCollection(OfCredential)

returnValue = instance.GetCredentials()
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicCollection<Credential> GetCredentials()
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualCollection<Credential^>^ GetCredentials() sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractGetCredentials : unit->Collection<Credential> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideGetCredentials : unit->Collection<Credential> 
```

``` jscript
publicfinalfunctionGetCredentials() : Collection<Credential>
```

#### Return Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[Credential](credential-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
The [Credential](credential-class-microsoft-web-media-transformmanager.md) objects.  

#### Implements

[IManagementService. . :: . .GetCredentials() () () ()](imanagementservice-getcredentials-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

