---
title: DeploymentRuleHandler.Update Method  (Microsoft.Web.Deployment)
TOCTitle: Update Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRuleHandler.Update(Microsoft.Web.Deployment.DeploymentSyncContext,Microsoft.Web.Deployment.DeploymentObject,Microsoft.Web.Deployment.DeploymentObject@,System.Boolean@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulehandler.update(v=VS.90)
ms:contentKeyID: 20208957
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleHandler.Update
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleHandler.Update
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Update Method

Performs an update in the context of a deployment rule handler.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableSubUpdate ( _
    syncContextAsDeploymentSyncContext, _
    destinationObjectAsDeploymentObject, _
    ByRefsourceObjectAsDeploymentObject, _
    ByRefproceedAsBoolean _
)
'Usage
DiminstanceAsDeploymentRuleHandlerDimsyncContextAsDeploymentSyncContextDimdestinationObjectAsDeploymentObjectDimsourceObjectAsDeploymentObjectDimproceedAsBoolean

instance.Update(syncContext, destinationObject, _
    sourceObject, proceed)
```

``` csharp
publicvirtualvoidUpdate(
    DeploymentSyncContextsyncContext,
    DeploymentObjectdestinationObject,
    refDeploymentObjectsourceObject,
    refboolproceed
)
```

``` c++
public:
virtualvoidUpdate(
    DeploymentSyncContext^ syncContext, 
    DeploymentObject^ destinationObject, 
    DeploymentObject^% sourceObject, 
    bool% proceed
)
```

``` jscript
publicfunctionUpdate(
    syncContext : DeploymentSyncContext, 
    destinationObject : DeploymentObject, 
    sourceObject : DeploymentObject, 
    proceed : boolean
)
```

#### Parameters

  - syncContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncContext](deploymentsynccontext-class-microsoft-web-deployment.md)  
    The synchronization context used in the current operation.  

<!-- end list -->

  - destinationObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  
    The destination deployment object used in the current operation.  

<!-- end list -->

  - sourceObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)%  
    The source deployment object used in the current operation.  

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

