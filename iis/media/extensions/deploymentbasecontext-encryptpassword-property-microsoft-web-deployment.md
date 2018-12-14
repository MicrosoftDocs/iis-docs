---
title: DeploymentBaseContext.EncryptPassword Property  (Microsoft.Web.Deployment)
TOCTitle: EncryptPassword Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseContext.EncryptPassword
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbasecontext.encryptpassword(v=VS.90)
ms:contentKeyID: 20209162
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseContext.EncryptPassword
- Microsoft.Web.Deployment.DeploymentBaseContext.get_EncryptPassword
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseContext.EncryptPassword
- Microsoft.Web.Deployment.DeploymentBaseContext.get_EncryptPassword
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# EncryptPassword Property

Gets the encrypted password.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyEncryptPasswordAsString
'Usage
DiminstanceAsDeploymentBaseContextDimvalueAsStringvalue = instance.EncryptPassword
```

``` csharp
publicstringEncryptPassword { get; }
```

``` c++
public:
propertyString^ EncryptPassword {
    String^ get ();
}
```

``` jscript
function getEncryptPassword () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the encrypted password.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseContext Class](deploymentbasecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

