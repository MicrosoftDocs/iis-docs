---
title: DeploymentObject.SyncParameters Property  (Microsoft.Web.Deployment)
TOCTitle: SyncParameters Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObject.SyncParameters
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobject.syncparameters(v=VS.90)
ms:contentKeyID: 20208807
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObject.SyncParameters
- Microsoft.Web.Deployment.DeploymentObject.get_SyncParameters
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObject.get_SyncParameters
- Microsoft.Web.Deployment.DeploymentObject.SyncParameters
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SyncParameters Property

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySyncParametersAsDeploymentSyncParameterCollection
'Usage
DiminstanceAsDeploymentObjectDimvalueAsDeploymentSyncParameterCollectionvalue = instance.SyncParameters
```

``` csharp
publicDeploymentSyncParameterCollectionSyncParameters { get; }
```

``` c++
public:
propertyDeploymentSyncParameterCollection^ SyncParameters {
    DeploymentSyncParameterCollection^ get ();
}
```

``` jscript
function getSyncParameters () : DeploymentSyncParameterCollection
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameterCollection](deploymentsyncparametercollection-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObject Class](deploymentobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

