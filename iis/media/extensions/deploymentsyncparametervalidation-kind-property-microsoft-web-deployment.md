---
title: DeploymentSyncParameterValidation.Kind Property  (Microsoft.Web.Deployment)
TOCTitle: Kind Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameterValidation.Kind
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametervalidation.kind(v=VS.90)
ms:contentKeyID: 22754044
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterValidation.Kind
- Microsoft.Web.Deployment.DeploymentSyncParameterValidation.get_Kind
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterValidation.get_Kind
- Microsoft.Web.Deployment.DeploymentSyncParameterValidation.Kind
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Kind Property

Retrieves the [DeploymentSyncParameterValidationKind](deploymentsyncparametervalidationkind-enumeration-microsoft-web-deployment.md) for the [DeploymentSyncParameterValidation](deploymentsyncparametervalidation-class-microsoft-web-deployment.md).

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyKindAsDeploymentSyncParameterValidationKind
'Usage
DiminstanceAsDeploymentSyncParameterValidationDimvalueAsDeploymentSyncParameterValidationKindvalue = instance.Kind
```

``` csharp
publicDeploymentSyncParameterValidationKindKind { get; }
```

``` c++
public:
propertyDeploymentSyncParameterValidationKindKind {
    DeploymentSyncParameterValidationKindget ();
}
```

``` jscript
function getKind () : DeploymentSyncParameterValidationKind
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameterValidationKind](deploymentsyncparametervalidationkind-enumeration-microsoft-web-deployment.md)  
The [DeploymentSyncParameterValidationKind](deploymentsyncparametervalidationkind-enumeration-microsoft-web-deployment.md) for the [DeploymentSyncParameterValidation](deploymentsyncparametervalidation-class-microsoft-web-deployment.md).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterValidation Class](deploymentsyncparametervalidation-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

