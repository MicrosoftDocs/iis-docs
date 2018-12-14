---
title: DeploymentObjectProvider.Update Method  (Microsoft.Web.Deployment)
TOCTitle: Update Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectProvider.Update(Microsoft.Web.Deployment.DeploymentObject,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectprovider.update(v=VS.90)
ms:contentKeyID: 20208902
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectProvider.Update
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectProvider.Update
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Update Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableSubUpdate ( _
    sourceAsDeploymentObject, _
    whatIfAsBoolean _
)
'Usage
DiminstanceAsDeploymentObjectProviderDimsourceAsDeploymentObjectDimwhatIfAsBoolean

instance.Update(source, whatIf)
```

``` csharp
publicvirtualvoidUpdate(
    DeploymentObjectsource,
    boolwhatIf
)
```

``` c++
public:
virtualvoidUpdate(
    DeploymentObject^ source, 
    boolwhatIf
)
```

``` jscript
publicfunctionUpdate(
    source : DeploymentObject, 
    whatIf : boolean
)
```

#### Parameters

  - source  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  

<!-- end list -->

  - whatIf  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectProvider Class](deploymentobjectprovider-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

