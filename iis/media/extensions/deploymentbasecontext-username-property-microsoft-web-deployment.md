---
title: DeploymentBaseContext.UserName Property  (Microsoft.Web.Deployment)
TOCTitle: UserName Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseContext.UserName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbasecontext.username(v=VS.90)
ms:contentKeyID: 20209083
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseContext.UserName
- Microsoft.Web.Deployment.DeploymentBaseContext.get_UserName
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseContext.get_UserName
- Microsoft.Web.Deployment.DeploymentBaseContext.UserName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# UserName Property

Gets the username used to access the deployment location.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyUserNameAsString
'Usage
DiminstanceAsDeploymentBaseContextDimvalueAsStringvalue = instance.UserName
```

``` csharp
publicstringUserName { get; }
```

``` c++
public:
propertyString^ UserName {
    String^ get ();
}
```

``` jscript
function getUserName () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the username.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseContext Class](deploymentbasecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

