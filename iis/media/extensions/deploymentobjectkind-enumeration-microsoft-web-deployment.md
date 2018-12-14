---
title: DeploymentObjectKind Enumeration (Microsoft.Web.Deployment)
TOCTitle: DeploymentObjectKind Enumeration
ms:assetid: T:Microsoft.Web.Deployment.DeploymentObjectKind
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectkind(v=VS.90)
ms:contentKeyID: 22753868
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectKind.OrderMatters
- Microsoft.Web.Deployment.DeploymentObjectKind.None
- Microsoft.Web.Deployment.DeploymentObjectKind
- Microsoft.Web.Deployment.DeploymentObjectKind.ContainsStream
- Microsoft.Web.Deployment.DeploymentObjectKind.IgnoreOnCompare
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectKind
- Microsoft.Web.Deployment.DeploymentObjectKind.ContainsStream
- Microsoft.Web.Deployment.DeploymentObjectKind.None
- Microsoft.Web.Deployment.DeploymentObjectKind.OrderMatters
- Microsoft.Web.Deployment.DeploymentObjectKind.IgnoreOnCompare
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentObjectKind Enumeration

Represents an enumeration of flags used in deployment operations.

This enumeration has a [FlagsAttribute](https://msdn.microsoft.com/en-us/library/dk06fkbc\(v=vs.90\)) attribute that allows a bitwise combination of its member values.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
<FlagsAttribute> _
PublicEnumerationDeploymentObjectKind
'Usage
DiminstanceAsDeploymentObjectKind
```

``` csharp
[FlagsAttribute]
publicenumDeploymentObjectKind
```

``` c++
[FlagsAttribute]
publicenum classDeploymentObjectKind
```

``` jscript
publicenum DeploymentObjectKind
```

## Remarks

These flags are used by deployment providers to provide context to various operations.

## See Also

#### Reference

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

