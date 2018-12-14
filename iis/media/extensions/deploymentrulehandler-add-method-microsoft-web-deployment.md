---
title: DeploymentRuleHandler.Add Method  (Microsoft.Web.Deployment)
TOCTitle: Add Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRuleHandler.Add(Microsoft.Web.Deployment.DeploymentSyncContext,Microsoft.Web.Deployment.DeploymentObject,Microsoft.Web.Deployment.DeploymentObject@,System.Boolean@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulehandler.add(v=VS.90)
ms:contentKeyID: 22753893
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleHandler.Add
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleHandler.Add
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Add Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableSubAdd ( _
    syncContextAsDeploymentSyncContext, _
    destinationObjectAsDeploymentObject, _
    ByRefsourceObjectAsDeploymentObject, _
    ByRefproceedAsBoolean _
)
'Usage
DiminstanceAsDeploymentRuleHandlerDimsyncContextAsDeploymentSyncContextDimdestinationObjectAsDeploymentObjectDimsourceObjectAsDeploymentObjectDimproceedAsBoolean

instance.Add(syncContext, destinationObject, _
    sourceObject, proceed)
```

``` csharp
publicvirtualvoidAdd(
    DeploymentSyncContextsyncContext,
    DeploymentObjectdestinationObject,
    refDeploymentObjectsourceObject,
    refboolproceed
)
```

``` c++
public:
virtualvoidAdd(
    DeploymentSyncContext^ syncContext, 
    DeploymentObject^ destinationObject, 
    DeploymentObject^% sourceObject, 
    bool% proceed
)
```

``` jscript
publicfunctionAdd(
    syncContext : DeploymentSyncContext, 
    destinationObject : DeploymentObject, 
    sourceObject : DeploymentObject, 
    proceed : boolean
)
```

#### Parameters

  - syncContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncContext](deploymentsynccontext-class-microsoft-web-deployment.md)  

<!-- end list -->

  - destinationObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  

<!-- end list -->

  - sourceObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)%  

<!-- end list -->

  - proceed  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))%  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleHandler Class](deploymentrulehandler-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

