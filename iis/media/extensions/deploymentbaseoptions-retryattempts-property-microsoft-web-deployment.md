---
title: DeploymentBaseOptions.RetryAttempts Property  (Microsoft.Web.Deployment)
TOCTitle: RetryAttempts Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseOptions.RetryAttempts
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.retryattempts(v=VS.90)
ms:contentKeyID: 20209258
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.RetryAttempts
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_RetryAttempts
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_RetryAttempts
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_RetryAttempts
- Microsoft.Web.Deployment.DeploymentBaseOptions.RetryAttempts
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_RetryAttempts
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RetryAttempts Property

Gets or sets the number of times to attempt a deployment operation.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyRetryAttemptsAsInteger
'Usage
DiminstanceAsDeploymentBaseOptionsDimvalueAsIntegervalue = instance.RetryAttempts

instance.RetryAttempts = value
```

``` csharp
publicintRetryAttempts { get; set; }
```

``` c++
public:
propertyintRetryAttempts {
    intget ();
    voidset (intvalue);
}
```

``` jscript
function getRetryAttempts () : intfunction setRetryAttempts (value : int)
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The number of times to attempt a deployment operation.  

## Remarks

The default value is 5 retry attempts.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseOptions Class](deploymentbaseoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

