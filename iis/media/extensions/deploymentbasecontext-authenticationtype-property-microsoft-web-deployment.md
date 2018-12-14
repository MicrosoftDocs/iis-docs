---
title: DeploymentBaseContext.AuthenticationType Property  (Microsoft.Web.Deployment)
TOCTitle: AuthenticationType Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseContext.AuthenticationType
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbasecontext.authenticationtype(v=VS.90)
ms:contentKeyID: 20208825
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseContext.AuthenticationType
- Microsoft.Web.Deployment.DeploymentBaseContext.get_AuthenticationType
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseContext.AuthenticationType
- Microsoft.Web.Deployment.DeploymentBaseContext.get_AuthenticationType
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AuthenticationType Property

Gets or sets a string that determines the type of authentication to use in the deployment operation.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyAuthenticationTypeAsString
'Usage
DiminstanceAsDeploymentBaseContextDimvalueAsStringvalue = instance.AuthenticationType
```

``` csharp
publicstringAuthenticationType { get; }
```

``` c++
public:
propertyString^ AuthenticationType {
    String^ get ();
}
```

``` jscript
function getAuthenticationType () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the authentication type.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseContext Class](deploymentbasecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

