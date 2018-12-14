---
title: DeclaredParameter.Validation Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Validation Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.DeclaredParameter.Validation
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.declaredparameter.validation(v=VS.90)
ms:contentKeyID: 22195870
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.DeclaredParameter.Validation
- Microsoft.Web.PlatformInstaller.DeclaredParameter.get_Validation
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.DeclaredParameter.get_Validation
- Microsoft.Web.PlatformInstaller.DeclaredParameter.Validation
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Validation Property

Gets a type that performs validation on user input.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyValidationAsDeploymentSyncParameterValidationGet
'Usage
DiminstanceAsDeclaredParameterDimvalueAsDeploymentSyncParameterValidationvalue = instance.Validation
```

``` csharp
publicDeploymentSyncParameterValidationValidation { get; }
```

``` c++
public:
propertyDeploymentSyncParameterValidation^ Validation {
    DeploymentSyncParameterValidation^ get ();
}
```

``` jscript
function getValidation () : DeploymentSyncParameterValidation
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameterValidation](deploymentsyncparametervalidation-class-microsoft-web-deployment.md)  
A DeploymentSyncParameterValidation instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[DeclaredParameter Class](declaredparameter-class-microsoft-web-platforminstaller.md)

[DeclaredParameter Members](declaredparameter-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

