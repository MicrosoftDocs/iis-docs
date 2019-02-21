---
title: IManagementService.GetCredentials Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetCredentials Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.GetCredentials
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.getcredentials(v=VS.90)
ms:contentKeyID: 35520846
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.GetCredentials
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.GetCredentials
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# GetCredentials Method

Returns all [Credential](credential-class-microsoft-web-media-transformmanager.md) objects for the service account from the Generic Credentials vault in Windows Credential Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Function GetCredentials As Collection(Of Credential)
'Usage

  Dim instance As IManagementService
Dim returnValue As Collection(Of Credential)

returnValue = instance.GetCredentials()
```

```csharp
[OperationContractAttribute]
Collection<Credential> GetCredentials()
```

```cpp
[OperationContractAttribute]
Collection<Credential^>^ GetCredentials()
```

``` fsharp
[<OperationContractAttribute>]
abstract GetCredentials : unit -> Collection<Credential> 
```

```jscript
  function GetCredentials() : Collection<Credential>
```

### Return Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[Credential](credential-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
The [Credential](credential-class-microsoft-web-media-transformmanager.md) objects.  

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

