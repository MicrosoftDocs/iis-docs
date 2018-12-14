---
title: DeploymentSkipDirective.GetEnumerator Method  (Microsoft.Web.Deployment)
TOCTitle: GetEnumerator Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSkipDirective.GetEnumerator
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirective.getenumerator(v=VS.90)
ms:contentKeyID: 20208996
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirective.GetEnumerator
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirective.GetEnumerator
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetEnumerator Method

Gets an enumerator that can be used to iterate through the [DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md) objects in the current instance.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetEnumeratorAsIEnumerator(OfDeploymentSkipDirectiveEntry)
'Usage
DiminstanceAsDeploymentSkipDirectiveDimreturnValueAsIEnumerator(OfDeploymentSkipDirectiveEntry)

returnValue = instance.GetEnumerator()
```

``` csharp
publicIEnumerator<DeploymentSkipDirectiveEntry> GetEnumerator()
```

``` c++
public:
virtualIEnumerator<DeploymentSkipDirectiveEntry^>^ GetEnumerator() sealed
```

``` jscript
publicfinalfunctionGetEnumerator() : IEnumerator<DeploymentSkipDirectiveEntry>
```

#### Return Value

Type: [System.Collections.Generic. . :: . .IEnumerator](https://msdn.microsoft.com/en-us/library/78dfe2yb\(v=vs.90\))\< (Of \< ( \<'[DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md)\> ) \> ) \>  

#### Implements

[IEnumerable\< (Of \< ( \<'T\> ) \> ) \>. . :: . .GetEnumerator() () () ()](https://msdn.microsoft.com/en-us/library/s793z9y2\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirective Class](deploymentskipdirective-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

