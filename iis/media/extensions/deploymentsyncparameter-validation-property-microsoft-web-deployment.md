---
title: DeploymentSyncParameter.Validation Property  (Microsoft.Web.Deployment)
TOCTitle: Validation Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameter.Validation
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameter.validation(v=VS.90)
ms:contentKeyID: 22753974
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameter.Validation
- Microsoft.Web.Deployment.DeploymentSyncParameter.get_Validation
- Microsoft.Web.Deployment.DeploymentSyncParameter.set_Validation
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameter.get_Validation
- Microsoft.Web.Deployment.DeploymentSyncParameter.set_Validation
- Microsoft.Web.Deployment.DeploymentSyncParameter.Validation
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Validation Property

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyValidationAsDeploymentSyncParameterValidation
'Usage
DiminstanceAsDeploymentSyncParameterDimvalueAsDeploymentSyncParameterValidationvalue = instance.Validation

instance.Validation = value
```

``` csharp
publicDeploymentSyncParameterValidationValidation { get; set; }
```

``` c++
public:
propertyDeploymentSyncParameterValidation^ Validation {
    DeploymentSyncParameterValidation^ get ();
    voidset (DeploymentSyncParameterValidation^ value);
}
```

``` jscript
function getValidation () : DeploymentSyncParameterValidationfunction setValidation (value : DeploymentSyncParameterValidation)
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameterValidation](deploymentsyncparametervalidation-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameter Class](deploymentsyncparameter-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

