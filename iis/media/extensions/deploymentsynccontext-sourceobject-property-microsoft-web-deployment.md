---
title: DeploymentSyncContext.SourceObject Property  (Microsoft.Web.Deployment)
TOCTitle: SourceObject Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncContext.SourceObject
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsynccontext.sourceobject(v=VS.90)
ms:contentKeyID: 20208985
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncContext.SourceObject
- Microsoft.Web.Deployment.DeploymentSyncContext.get_SourceObject
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncContext.get_SourceObject
- Microsoft.Web.Deployment.DeploymentSyncContext.SourceObject
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SourceObject Property

Gets the source [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) for the current deployment synchronization context.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySourceObjectAsDeploymentObject
'Usage
DiminstanceAsDeploymentSyncContextDimvalueAsDeploymentObjectvalue = instance.SourceObject
```

``` csharp
publicDeploymentObjectSourceObject { get; }
```

``` c++
public:
propertyDeploymentObject^ SourceObject {
    DeploymentObject^ get ();
}
```

``` jscript
function getSourceObject () : DeploymentObject
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  
A [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) used as the source for the current synchronization context.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncContext Class](deploymentsynccontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

