---
title: DeploymentRuleHandler.PreSync Method  (Microsoft.Web.Deployment)
TOCTitle: PreSync Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRuleHandler.PreSync(Microsoft.Web.Deployment.DeploymentSyncContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulehandler.presync(v=VS.90)
ms:contentKeyID: 20209235
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleHandler.PreSync
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleHandler.PreSync
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PreSync Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableSubPreSync ( _
    syncContextAsDeploymentSyncContext _
)
'Usage
DiminstanceAsDeploymentRuleHandlerDimsyncContextAsDeploymentSyncContext

instance.PreSync(syncContext)
```

``` csharp
publicvirtualvoidPreSync(
    DeploymentSyncContextsyncContext
)
```

``` c++
public:
virtualvoidPreSync(
    DeploymentSyncContext^ syncContext
)
```

``` jscript
publicfunctionPreSync(
    syncContext : DeploymentSyncContext
)
```

#### Parameters

  - syncContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncContext](deploymentsynccontext-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleHandler Class](deploymentrulehandler-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

