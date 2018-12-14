---
title: DeploymentCancelCallback Delegate (Microsoft.Web.Deployment)
TOCTitle: DeploymentCancelCallback Delegate
ms:assetid: T:Microsoft.Web.Deployment.DeploymentCancelCallback
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentcancelcallback(v=VS.90)
ms:contentKeyID: 20208669
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentCancelCallback
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentCancelCallback
- Microsoft.Web.Deployment.DeploymentCancelCallback..ctor
- Microsoft.Web.Deployment.DeploymentCancelCallback.BeginInvoke
- Microsoft.Web.Deployment.DeploymentCancelCallback.EndInvoke
- Microsoft.Web.Deployment.DeploymentCancelCallback.Invoke
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentCancelCallback Delegate

Delegate called at numerous points during a synchronization process to determine if the operation should continue.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicDelegateFunctionDeploymentCancelCallbackAsBoolean
'Usage
DiminstanceAsNewDeploymentCancelCallback(AddressOf HandlerMethod)
```

``` csharp
publicdelegateboolDeploymentCancelCallback()
```

``` c++
publicdelegateboolDeploymentCancelCallback()
```

``` jscript
JScript does not support delegates.
```

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the operation should be cancelled , otherwise false.  

## See Also

#### Reference

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

