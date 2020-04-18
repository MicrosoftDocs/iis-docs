---
title: IManagementService.DeleteCredential Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteCredential Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.DeleteCredential(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanagementservice.deletecredential(v=VS.90)
ms:contentKeyID: 35520644
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.DeleteCredential
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.DeleteCredential
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DeleteCredential Method

Deletes a [Credential](credential-class-microsoft-web-media-transformmanager.md) object for the service account from the Generic Credentials vault in Windows Credential Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Sub DeleteCredential ( _
    credentialId As String _
)
'Usage

  Dim instance As IManagementService
Dim credentialId As String

instance.DeleteCredential(credentialId)
```

```csharp
[OperationContractAttribute]
void DeleteCredential(
    string credentialId
)
```

```cpp
[OperationContractAttribute]
void DeleteCredential(
    String^ credentialId
)
```

``` fsharp
[<OperationContractAttribute>]
abstract DeleteCredential : 
        credentialId:string -> unit 
```

```jscript
  function DeleteCredential(
    credentialId : String
)
```

### Parameters

  - credentialId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the [Credential](credential-class-microsoft-web-media-transformmanager.md) object to delete.  

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
