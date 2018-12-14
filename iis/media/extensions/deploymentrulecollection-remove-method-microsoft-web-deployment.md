---
title: DeploymentRuleCollection.Remove Method  (Microsoft.Web.Deployment)
TOCTitle: Remove Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRuleCollection.Remove(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulecollection.remove(v=VS.90)
ms:contentKeyID: 20208908
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleCollection.Remove
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleCollection.Remove
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Remove Method

Removes the [DeploymentRule](deploymentrule-class-microsoft-web-deployment.md) with the specified name from the current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubRemove ( _
    nameAsString _
)
'Usage
DiminstanceAsDeploymentRuleCollectionDimnameAsString

instance.Remove(name)
```

``` csharp
publicvoidRemove(
    stringname
)
```

``` c++
public:
voidRemove(
    String^ name
)
```

``` jscript
publicfunctionRemove(
    name : String
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the [DeploymentRule](deploymentrule-class-microsoft-web-deployment.md) to remove from the current collection.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleCollection Class](deploymentrulecollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

