---
title: DeploymentBaseOptions.EncryptPassword Property  (Microsoft.Web.Deployment)
TOCTitle: EncryptPassword Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseOptions.EncryptPassword
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.encryptpassword(v=VS.90)
ms:contentKeyID: 20208866
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.EncryptPassword
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_EncryptPassword
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_EncryptPassword
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.EncryptPassword
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_EncryptPassword
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_EncryptPassword
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# EncryptPassword Property

Gets or sets the encrypted password.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyEncryptPasswordAsString
'Usage
DiminstanceAsDeploymentBaseOptionsDimvalueAsStringvalue = instance.EncryptPassword

instance.EncryptPassword = value
```

``` csharp
publicstringEncryptPassword { get; set; }
```

``` c++
public:
propertyString^ EncryptPassword {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getEncryptPassword () : Stringfunction setEncryptPassword (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the encrypted password.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseOptions Class](deploymentbaseoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

