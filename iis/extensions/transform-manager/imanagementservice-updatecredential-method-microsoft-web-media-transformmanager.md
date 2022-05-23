---
title: IManagementService.UpdateCredential Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateCredential Method
description: "The IManagementService.UpdateCredential method adds or replaces a Credential object for the service account from the Generic Credentials vault in Windows Credential Manager."
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.UpdateCredential(Microsoft.Web.Media.TransformManager.Credential)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanagementservice.updatecredential(v=VS.90)
ms:contentKeyID: 35521139
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.UpdateCredential
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.UpdateCredential
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# UpdateCredential Method

Adds or replaces a [Credential](credential-class-microsoft-web-media-transformmanager.md) object for the service account from the Generic Credentials vault in Windows Credential Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Sub UpdateCredential ( _
    credential As Credential _
)
'Usage

  Dim instance As IManagementService
Dim credential As Credential

instance.UpdateCredential(credential)
```

```csharp
[OperationContractAttribute]
void UpdateCredential(
    Credential credential
)
```

```cpp
[OperationContractAttribute]
void UpdateCredential(
    Credential^ credential
)
```

``` fsharp
[<OperationContractAttribute>]
abstract UpdateCredential : 
        credential:Credential -> unit 
```

```jscript
  function UpdateCredential(
    credential : Credential
)
```

### Parameters

  - credential  
    Type: [Microsoft.Web.Media.TransformManager.Credential](credential-class-microsoft-web-media-transformmanager.md)  
    A new or existing [Credential](credential-class-microsoft-web-media-transformmanager.md) object.  

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
