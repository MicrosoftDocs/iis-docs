---
title: DeploymentRuleHandler.PostSync Method  (Microsoft.Web.Deployment)
TOCTitle: PostSync Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRuleHandler.PostSync(Microsoft.Web.Deployment.DeploymentSyncContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulehandler.postsync(v=VS.90)
ms:contentKeyID: 20209020
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleHandler.PostSync
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleHandler.PostSync
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PostSync Method

Performs actions after a synchronization action is executed.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableSubPostSync ( _
    syncContextAsDeploymentSyncContext _
)
'Usage
DiminstanceAsDeploymentRuleHandlerDimsyncContextAsDeploymentSyncContext

instance.PostSync(syncContext)
```

``` csharp
publicvirtualvoidPostSync(
    DeploymentSyncContextsyncContext
)
```

``` c++
public:
virtualvoidPostSync(
    DeploymentSyncContext^ syncContext
)
```

``` jscript
publicfunctionPostSync(
    syncContext : DeploymentSyncContext
)
```

#### Parameters

  - syncContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncContext](deploymentsynccontext-class-microsoft-web-deployment.md)  
    The synchronization context used in the current operation.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleHandler Class](deploymentrulehandler-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

