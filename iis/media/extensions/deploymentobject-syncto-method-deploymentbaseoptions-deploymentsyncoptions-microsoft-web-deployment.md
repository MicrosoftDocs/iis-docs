---
title: DeploymentObject.SyncTo Method (DeploymentBaseOptions, DeploymentSyncOptions) (Microsoft.Web.Deployment)
TOCTitle: SyncTo Method (DeploymentBaseOptions, DeploymentSyncOptions)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObject.SyncTo(Microsoft.Web.Deployment.DeploymentBaseOptions,Microsoft.Web.Deployment.DeploymentSyncOptions)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobject.syncto(v=VS.90)
ms:contentKeyID: 20209150
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
- Microsoft.Web.Deployment.DeploymentObject.SyncTo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SyncTo Method (DeploymentBaseOptions, DeploymentSyncOptions)

Synchronizes the current [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) instance by using the base options and synchronization options specified.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionSyncTo ( _
    baseOptionsAsDeploymentBaseOptions, _
    syncOptionsAsDeploymentSyncOptions _
) AsDeploymentChangeSummary
'Usage
DiminstanceAsDeploymentObjectDimbaseOptionsAsDeploymentBaseOptionsDimsyncOptionsAsDeploymentSyncOptionsDimreturnValueAsDeploymentChangeSummaryreturnValue = instance.SyncTo(baseOptions, _
    syncOptions)
```

``` csharp
publicDeploymentChangeSummarySyncTo(
    DeploymentBaseOptionsbaseOptions,
    DeploymentSyncOptionssyncOptions
)
```

``` c++
public:
DeploymentChangeSummary^ SyncTo(
    DeploymentBaseOptions^ baseOptions, 
    DeploymentSyncOptions^ syncOptions
)
```

``` jscript
publicfunctionSyncTo(
    baseOptions : DeploymentBaseOptions, 
    syncOptions : DeploymentSyncOptions
) : DeploymentChangeSummary
```

#### Parameters

  - baseOptions  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentBaseOptions](deploymentbaseoptions-class-microsoft-web-deployment.md)  
    The base options used in the synchronization operation.  

<!-- end list -->

  - syncOptions  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncOptions](deploymentsyncoptions-class-microsoft-web-deployment.md)  
    The valid [DeploymentSyncOptions](deploymentsyncoptions-class-microsoft-web-deployment.md) instance used in the synchronization operation.  

#### Return Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentChangeSummary](deploymentchangesummary-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObject Class](deploymentobject-class-microsoft-web-deployment.md)

[SyncTo Overload](deploymentobject-syncto-method-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

