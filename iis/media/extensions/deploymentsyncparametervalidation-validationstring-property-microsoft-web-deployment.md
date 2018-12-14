---
title: DeploymentSyncParameterValidation.ValidationString Property  (Microsoft.Web.Deployment)
TOCTitle: ValidationString Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameterValidation.ValidationString
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametervalidation.validationstring(v=VS.90)
ms:contentKeyID: 22753912
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterValidation.ValidationString
- Microsoft.Web.Deployment.DeploymentSyncParameterValidation.get_ValidationString
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterValidation.get_ValidationString
- Microsoft.Web.Deployment.DeploymentSyncParameterValidation.ValidationString
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ValidationString Property

Retrieves a string that contains the validation value for the [DeploymentSyncParameterValidation](deploymentsyncparametervalidation-class-microsoft-web-deployment.md).

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyValidationStringAsString
'Usage
DiminstanceAsDeploymentSyncParameterValidationDimvalueAsStringvalue = instance.ValidationString
```

``` csharp
publicstringValidationString { get; }
```

``` c++
public:
propertyString^ ValidationString {
    String^ get ();
}
```

``` jscript
function getValidationString () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the validation value for the [DeploymentSyncParameterValidation](deploymentsyncparametervalidation-class-microsoft-web-deployment.md).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterValidation Class](deploymentsyncparametervalidation-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

