---
title: DeploymentSyncParameterCollection.Add Method  (Microsoft.Web.Deployment)
TOCTitle: Add Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameterCollection.Add(Microsoft.Web.Deployment.DeploymentSyncParameter)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametercollection.add(v=VS.90)
ms:contentKeyID: 20208861
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection.Add
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection.Add
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Add Method

Adds a [DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md) to the current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubAdd ( _
    parameterAsDeploymentSyncParameter _
)
'Usage
DiminstanceAsDeploymentSyncParameterCollectionDimparameterAsDeploymentSyncParameter

instance.Add(parameter)
```

``` csharp
publicvoidAdd(
    DeploymentSyncParameterparameter
)
```

``` c++
public:
voidAdd(
    DeploymentSyncParameter^ parameter
)
```

``` jscript
publicfunctionAdd(
    parameter : DeploymentSyncParameter
)
```

#### Parameters

  - parameter  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md)  
    The [DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md) to add.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterCollection Class](deploymentsyncparametercollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

