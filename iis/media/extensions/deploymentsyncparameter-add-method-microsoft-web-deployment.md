---
title: DeploymentSyncParameter.Add Method  (Microsoft.Web.Deployment)
TOCTitle: Add Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameter.Add(Microsoft.Web.Deployment.DeploymentSyncParameterEntry)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameter.add(v=VS.90)
ms:contentKeyID: 20209284
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameter.Add
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameter.Add
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Add Method

Adds a DeploymentSyncParameterEntry to the underlying list of entries.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubAdd ( _
    entryAsDeploymentSyncParameterEntry _
)
'Usage
DiminstanceAsDeploymentSyncParameterDimentryAsDeploymentSyncParameterEntry

instance.Add(entry)
```

``` csharp
publicvoidAdd(
    DeploymentSyncParameterEntryentry
)
```

``` c++
public:
voidAdd(
    DeploymentSyncParameterEntry^ entry
)
```

``` jscript
publicfunctionAdd(
    entry : DeploymentSyncParameterEntry
)
```

#### Parameters

  - entry  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameterEntry](deploymentsyncparameterentry-class-microsoft-web-deployment.md)  
    The new DeploymentSyncParameterEntry to add.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameter Class](deploymentsyncparameter-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

