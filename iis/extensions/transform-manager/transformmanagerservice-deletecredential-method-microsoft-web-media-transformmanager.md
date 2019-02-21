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
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
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
---

# DeleteCredential Method

Deletes a [Credential](credential-class-microsoft-web-media-transformmanager.md) object for the service account from the Generic Credentials vault in Windows Credential Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub DeleteCredential ( _
    credentialId As String _
)
'Usage

  Dim instance As TransformManagerService
Dim credentialId As String

instance.DeleteCredential(credentialId)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void DeleteCredential(
    string credentialId
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void DeleteCredential(
    String^ credentialId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract DeleteCredential : 
        credentialId:string -> unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override DeleteCredential : 
        credentialId:string -> unit 
```

```jscript
  public final function DeleteCredential(
    credentialId : String
)
```

### Parameters

  - credentialId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the [Credential](credential-class-microsoft-web-media-transformmanager.md) object to delete.  

### Implements

[IManagementService.DeleteCredential(String)](imanagementservice-deletecredential-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

