---
title: DeploymentObjectChangedEventArgs.OperationType Property  (Microsoft.Web.Deployment)
TOCTitle: OperationType Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.OperationType
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectchangedeventargs.operationtype(v=VS.90)
ms:contentKeyID: 22754020
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.OperationType
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.get_OperationType
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.get_OperationType
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.OperationType
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# OperationType Property

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyOperationTypeAsDeploymentOperationKind
'Usage
DiminstanceAsDeploymentObjectChangedEventArgsDimvalueAsDeploymentOperationKindvalue = instance.OperationType
```

``` csharp
publicDeploymentOperationKindOperationType { get; }
```

``` c++
public:
propertyDeploymentOperationKindOperationType {
    DeploymentOperationKindget ();
}
```

``` jscript
function getOperationType () : DeploymentOperationKind
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentOperationKind](deploymentoperationkind-enumeration-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectChangedEventArgs Class](deploymentobjectchangedeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

