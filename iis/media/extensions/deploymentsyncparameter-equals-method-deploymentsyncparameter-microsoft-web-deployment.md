---
title: DeploymentSyncParameter.Equals Method (DeploymentSyncParameter) (Microsoft.Web.Deployment)
TOCTitle: Equals Method (DeploymentSyncParameter)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameter.Equals(Microsoft.Web.Deployment.DeploymentSyncParameter)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameter.equals(v=VS.90)
ms:contentKeyID: 20208760
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameter.Equals
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Equals Method (DeploymentSyncParameter)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionEquals ( _
    otherAsDeploymentSyncParameter _
) AsBoolean
'Usage
DiminstanceAsDeploymentSyncParameterDimotherAsDeploymentSyncParameterDimreturnValueAsBooleanreturnValue = instance.Equals(other)
```

``` csharp
publicboolEquals(
    DeploymentSyncParameterother
)
```

``` c++
public:
virtualboolEquals(
    DeploymentSyncParameter^ other
) sealed
```

``` jscript
publicfinalfunctionEquals(
    other : DeploymentSyncParameter
) : boolean
```

#### Parameters

  - other  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md)  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  

#### Implements

[IEquatable\< (Of \< ( \<'T\> ) \> ) \>. . :: . .Equals(T)](https://msdn.microsoft.com/en-us/library/ms131190\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameter Class](deploymentsyncparameter-class-microsoft-web-deployment.md)

[Equals Overload](deploymentsyncparameter-equals-method-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

