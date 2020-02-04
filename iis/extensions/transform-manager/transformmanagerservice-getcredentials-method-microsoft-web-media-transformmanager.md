---
title: TransformManagerService.GetCredentials Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetCredentials Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetCredentials
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.getcredentials(v=VS.90)
ms:contentKeyID: 35520941
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetCredentials
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetCredentials
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetCredentials Method

Returns all of the [Credential](credential-class-microsoft-web-media-transformmanager.md) objects from the credential store of the service account.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetCredentials As Collection(Of Credential)
'Usage

  Dim instance As TransformManagerService
Dim returnValue As Collection(Of Credential)

returnValue = instance.GetCredentials()
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public Collection<Credential> GetCredentials()
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual Collection<Credential^>^ GetCredentials() sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetCredentials : unit -> Collection<Credential> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetCredentials : unit -> Collection<Credential> 
```

```jscript
  public final function GetCredentials() : Collection<Credential>
```

### Return Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[Credential](credential-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
The [Credential](credential-class-microsoft-web-media-transformmanager.md) objects.  

### Implements

[IManagementService.GetCredentials() () () ()](imanagementservice-getcredentials-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

