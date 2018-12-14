---
title: DeploymentRuleHandler.Delete Method  (Microsoft.Web.Deployment)
TOCTitle: Delete Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRuleHandler.Delete(Microsoft.Web.Deployment.DeploymentSyncContext,Microsoft.Web.Deployment.DeploymentObject,Microsoft.Web.Deployment.DeploymentObject,System.Boolean@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulehandler.delete(v=VS.90)
ms:contentKeyID: 20209212
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleHandler.Delete
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleHandler.Delete
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Delete Method

Performs a delete operation for the current rule handler.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableSubDelete ( _
    syncContextAsDeploymentSyncContext, _
    destinationObjectAsDeploymentObject, _
    sourceParentObjectAsDeploymentObject, _
    ByRefproceedAsBoolean _
)
'Usage
DiminstanceAsDeploymentRuleHandlerDimsyncContextAsDeploymentSyncContextDimdestinationObjectAsDeploymentObjectDimsourceParentObjectAsDeploymentObjectDimproceedAsBoolean

instance.Delete(syncContext, destinationObject, _
    sourceParentObject, proceed)
```

``` csharp
publicvirtualvoidDelete(
    DeploymentSyncContextsyncContext,
    DeploymentObjectdestinationObject,
    DeploymentObjectsourceParentObject,
    refboolproceed
)
```

``` c++
public:
virtualvoidDelete(
    DeploymentSyncContext^ syncContext, 
    DeploymentObject^ destinationObject, 
    DeploymentObject^ sourceParentObject, 
    bool% proceed
)
```

``` jscript
publicfunctionDelete(
    syncContext : DeploymentSyncContext, 
    destinationObject : DeploymentObject, 
    sourceParentObject : DeploymentObject, 
    proceed : boolean
)
```

#### Parameters

  - syncContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncContext](deploymentsynccontext-class-microsoft-web-deployment.md)  
    The synchronization context used in the delete operation.  

<!-- end list -->

  - destinationObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  
    The destination deployment object used in the delete operation.  

<!-- end list -->

  - sourceParentObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  
    The source deployment object used in the delete operation.  

<!-- end list -->

  - proceed  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))%  
    Reference parameter used to determine if the next deployment operation should proceed.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleHandler Class](deploymentrulehandler-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

