---
title: DeploymentSyncOptions.DoNotDelete Property  (Microsoft.Web.Deployment)
TOCTitle: DoNotDelete Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncOptions.DoNotDelete
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncoptions.donotdelete(v=VS.90)
ms:contentKeyID: 20208792
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncOptions.DoNotDelete
- Microsoft.Web.Deployment.DeploymentSyncOptions.get_DoNotDelete
- Microsoft.Web.Deployment.DeploymentSyncOptions.set_DoNotDelete
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncOptions.DoNotDelete
- Microsoft.Web.Deployment.DeploymentSyncOptions.get_DoNotDelete
- Microsoft.Web.Deployment.DeploymentSyncOptions.set_DoNotDelete
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DoNotDelete Property

Gets or sets a value that allows or prevents deletion from happening on the destination of a synchronization operation.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyDoNotDeleteAsBoolean
'Usage
DiminstanceAsDeploymentSyncOptionsDimvalueAsBooleanvalue = instance.DoNotDelete

instance.DoNotDelete = value
```

``` csharp
publicboolDoNotDelete { get; set; }
```

``` c++
public:
propertyboolDoNotDelete {
    boolget ();
    voidset (boolvalue);
}
```

``` jscript
function getDoNotDelete () : booleanfunction setDoNotDelete (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the [DeploymentSyncOptions](deploymentsyncoptions-class-microsoft-web-deployment.md) allows deletion, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncOptions Class](deploymentsyncoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

