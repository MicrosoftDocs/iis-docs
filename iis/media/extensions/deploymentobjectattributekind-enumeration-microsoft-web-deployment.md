---
title: DeploymentObjectAttributeKind Enumeration (Microsoft.Web.Deployment)
TOCTitle: DeploymentObjectAttributeKind Enumeration
ms:assetid: T:Microsoft.Web.Deployment.DeploymentObjectAttributeKind
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributekind(v=VS.90)
ms:contentKeyID: 22753998
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind.CaseInsensitiveCompare
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind.ExpandEnvironmentVariables
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind.SecureAttribute
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind.IgnoreOnCompare
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind.None
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind.CaseInsensitiveCompare
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind.ExpandEnvironmentVariables
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind.IgnoreOnCompare
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind.None
- Microsoft.Web.Deployment.DeploymentObjectAttributeKind.SecureAttribute
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentObjectAttributeKind Enumeration

Defines a set of flags that are used to provide information about attributes.

This enumeration has a [FlagsAttribute](https://msdn.microsoft.com/en-us/library/dk06fkbc\(v=vs.90\)) attribute that allows a bitwise combination of its member values.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
<FlagsAttribute> _
PublicEnumerationDeploymentObjectAttributeKind
'Usage
DiminstanceAsDeploymentObjectAttributeKind
```

``` csharp
[FlagsAttribute]
publicenumDeploymentObjectAttributeKind
```

``` c++
[FlagsAttribute]
publicenum classDeploymentObjectAttributeKind
```

``` jscript
publicenum DeploymentObjectAttributeKind
```

## Remarks

The DeploymentObjectAttributeKind enumeration is used when comparing source and destination deployment objects. These flags provide additional information about the attribute to provide direction in the comparison operation.

## See Also

#### Reference

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

