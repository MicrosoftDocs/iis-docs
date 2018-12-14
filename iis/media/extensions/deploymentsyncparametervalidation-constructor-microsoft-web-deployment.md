---
title: DeploymentSyncParameterValidation Constructor  (Microsoft.Web.Deployment)
TOCTitle: DeploymentSyncParameterValidation Constructor
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameterValidation.#ctor(Microsoft.Web.Deployment.DeploymentSyncParameterValidationKind,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametervalidation.deploymentsyncparametervalidation(v=VS.90)
ms:contentKeyID: 22754063
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterValidation.DeploymentSyncParameterValidation
- Microsoft.Web.Deployment.DeploymentSyncParameterValidation.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterValidation..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentSyncParameterValidation Constructor

Creates an instance of a [DeploymentSyncParameterValidation](deploymentsyncparametervalidation-class-microsoft-web-deployment.md) object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    kindAsDeploymentSyncParameterValidationKind, _
    validationAsString _
)
'Usage
DimkindAsDeploymentSyncParameterValidationKindDimvalidationAsStringDiminstanceAs NewDeploymentSyncParameterValidation(kind, validation)
```

``` csharp
publicDeploymentSyncParameterValidation(
    DeploymentSyncParameterValidationKindkind,
    stringvalidation
)
```

``` c++
public:
DeploymentSyncParameterValidation(
    DeploymentSyncParameterValidationKindkind, 
    String^ validation
)
```

``` jscript
publicfunctionDeploymentSyncParameterValidation(
    kind : DeploymentSyncParameterValidationKind, 
    validation : String
)
```

#### Parameters

  - kind  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameterValidationKind](deploymentsyncparametervalidationkind-enumeration-microsoft-web-deployment.md)  
    The [DeploymentSyncParameterValidationKind](deploymentsyncparametervalidationkind-enumeration-microsoft-web-deployment.md) for the validation  

<!-- end list -->

  - validation  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string that contains the value to validate.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterValidation Class](deploymentsyncparametervalidation-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

