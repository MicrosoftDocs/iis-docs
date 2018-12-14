---
title: DeploymentBaseContext.Password Property  (Microsoft.Web.Deployment)
TOCTitle: Password Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseContext.Password
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbasecontext.password(v=VS.90)
ms:contentKeyID: 20208874
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseContext.Password
- Microsoft.Web.Deployment.DeploymentBaseContext.get_Password
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseContext.get_Password
- Microsoft.Web.Deployment.DeploymentBaseContext.Password
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Password Property

Gets the password used to access the deployment location.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyPasswordAsString
'Usage
DiminstanceAsDeploymentBaseContextDimvalueAsStringvalue = instance.Password
```

``` csharp
publicstringPassword { get; }
```

``` c++
public:
propertyString^ Password {
    String^ get ();
}
```

``` jscript
function getPassword () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the unencrypted password.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseContext Class](deploymentbasecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

