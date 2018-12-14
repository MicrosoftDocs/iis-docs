---
title: DeploymentBaseOptions.RetryInterval Property  (Microsoft.Web.Deployment)
TOCTitle: RetryInterval Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseOptions.RetryInterval
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.retryinterval(v=VS.90)
ms:contentKeyID: 20209184
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.RetryInterval
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_RetryInterval
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_RetryInterval
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_RetryInterval
- Microsoft.Web.Deployment.DeploymentBaseOptions.RetryInterval
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_RetryInterval
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RetryInterval Property

Gets or sets the interval, in milliseconds, to wait between retry attempts.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyRetryIntervalAsInteger
'Usage
DiminstanceAsDeploymentBaseOptionsDimvalueAsIntegervalue = instance.RetryInterval

instance.RetryInterval = value
```

``` csharp
publicintRetryInterval { get; set; }
```

``` c++
public:
propertyintRetryInterval {
    intget ();
    voidset (intvalue);
}
```

``` jscript
function getRetryInterval () : intfunction setRetryInterval (value : int)
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The interval, in milliseconds, to wait between retry attempts.  

## Remarks

The default value is 1000 milliseconds.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseOptions Class](deploymentbaseoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

