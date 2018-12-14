---
title: DeploymentManager.GetMethods Method  (Microsoft.Web.Deployment)
TOCTitle: GetMethods Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentManager.GetMethods
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanager.getmethods(v=VS.90)
ms:contentKeyID: 22753993
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManager.GetMethods
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManager.GetMethods
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetMethods Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionGetMethodsAsIEnumerable(OfDeploymentMethod)
'Usage
DimreturnValueAsIEnumerable(OfDeploymentMethod)

returnValue = DeploymentManager.GetMethods()
```

``` csharp
publicstaticIEnumerable<DeploymentMethod> GetMethods()
```

``` c++
public:
staticIEnumerable<DeploymentMethod^>^ GetMethods()
```

``` jscript
publicstaticfunctionGetMethods() : IEnumerable<DeploymentMethod>
```

#### Return Value

Type: [System.Collections.Generic. . :: . .IEnumerable](https://msdn.microsoft.com/en-us/library/9eekhta0\(v=vs.90\))\< (Of \< ( \<'[DeploymentMethod](deploymentmethod-class-microsoft-web-deployment.md)\> ) \> ) \>  
Returns [IEnumerable\<(Of \<(\<'T\>)\>)\>](https://msdn.microsoft.com/en-us/library/9eekhta0\(v=vs.90\)).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManager Class](deploymentmanager-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

