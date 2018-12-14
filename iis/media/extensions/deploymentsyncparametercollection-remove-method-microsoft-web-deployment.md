---
title: DeploymentSyncParameterCollection.Remove Method  (Microsoft.Web.Deployment)
TOCTitle: Remove Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameterCollection.Remove(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametercollection.remove(v=VS.90)
ms:contentKeyID: 20208933
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection.Remove
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection.Remove
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Remove Method

Removes a parameter with the specified name from the current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubRemove ( _
    nameAsString _
)
'Usage
DiminstanceAsDeploymentSyncParameterCollectionDimnameAsString

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
    The name of the parameter to remove.  

## Remarks

No exceptions are thrown and no actions are performed if a parameter with the specified name is not found.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterCollection Class](deploymentsyncparametercollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

