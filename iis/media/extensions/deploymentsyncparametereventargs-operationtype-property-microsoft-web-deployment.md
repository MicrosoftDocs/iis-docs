---
title: DeploymentSyncParameterEventArgs.OperationType Property  (Microsoft.Web.Deployment)
TOCTitle: OperationType Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.OperationType
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametereventargs.operationtype(v=VS.90)
ms:contentKeyID: 22753936
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.OperationType
- Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.get_OperationType
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.get_OperationType
- Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.OperationType
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# OperationType Property

Gets the DeploymentOperationKind associated with the event arguments for a deployment synchronization parameter.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyOperationTypeAsDeploymentOperationKind
'Usage
DiminstanceAsDeploymentSyncParameterEventArgsDimvalueAsDeploymentOperationKindvalue = instance.OperationType
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
A DeploymentOperationKind that is associated with the event arguments for a deployment synchronization parameter.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterEventArgs Class](deploymentsyncparametereventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

