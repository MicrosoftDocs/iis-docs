---
title: DeploymentAddAttributeContext.SetObjectException Method  (Microsoft.Web.Deployment)
TOCTitle: SetObjectException Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentAddAttributeContext.SetObjectException(Microsoft.Web.Deployment.DeploymentException)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentaddattributecontext.setobjectexception(v=VS.90)
ms:contentKeyID: 20579890
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAddAttributeContext.SetObjectException
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAddAttributeContext.SetObjectException
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetObjectException Method

Specifies the deployment exception for the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubSetObjectException ( _
    exAsDeploymentException _
)
'Usage
DiminstanceAsDeploymentAddAttributeContextDimexAsDeploymentException

instance.SetObjectException(ex)
```

``` csharp
publicvoidSetObjectException(
    DeploymentExceptionex
)
```

``` c++
public:
voidSetObjectException(
    DeploymentException^ ex
)
```

``` jscript
publicfunctionSetObjectException(
    ex : DeploymentException
)
```

#### Parameters

  - ex  
    Type: DeploymentException  
    The DeploymentException object for the current object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAddAttributeContext Class](deploymentaddattributecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

