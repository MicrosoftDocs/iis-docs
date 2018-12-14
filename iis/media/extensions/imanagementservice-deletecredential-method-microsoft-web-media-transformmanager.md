---
title: IManagementService.DeleteCredential Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteCredential Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.DeleteCredential(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.deletecredential(v=VS.90)
ms:contentKeyID: 35520644
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.DeleteCredential
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.DeleteCredential
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
<OperationContractAttribute> _
SubDeleteCredential ( _
    credentialIdAsString _
)
'Usage
DiminstanceAsIManagementServiceDimcredentialIdAsString

instance.DeleteCredential(credentialId)
```

``` csharp
[OperationContractAttribute]
voidDeleteCredential(
    stringcredentialId
)
```

``` c++
[OperationContractAttribute]
voidDeleteCredential(
    String^ credentialId
)
```

``` fsharp
[<OperationContractAttribute>]
abstractDeleteCredential : 
        credentialId:string->unit
```

``` jscript
functionDeleteCredential(
    credentialId : String
)
```

#### Parameters

  - credentialId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the [Credential](credential-class-microsoft-web-media-transformmanager.md) object to delete.  

## See Also

#### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

