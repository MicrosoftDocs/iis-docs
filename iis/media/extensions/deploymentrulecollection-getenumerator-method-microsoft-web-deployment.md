---
title: DeploymentRuleCollection.GetEnumerator Method  (Microsoft.Web.Deployment)
TOCTitle: GetEnumerator Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRuleCollection.GetEnumerator
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulecollection.getenumerator(v=VS.90)
ms:contentKeyID: 20209142
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleCollection.GetEnumerator
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleCollection.GetEnumerator
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetEnumerator Method

Gets an enumerator that can be used to iterate through the current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetEnumeratorAsIEnumerator(OfDeploymentRule)
'Usage
DiminstanceAsDeploymentRuleCollectionDimreturnValueAsIEnumerator(OfDeploymentRule)

returnValue = instance.GetEnumerator()
```

``` csharp
publicIEnumerator<DeploymentRule> GetEnumerator()
```

``` c++
public:
virtualIEnumerator<DeploymentRule^>^ GetEnumerator() sealed
```

``` jscript
publicfinalfunctionGetEnumerator() : IEnumerator<DeploymentRule>
```

#### Return Value

Type: [System.Collections.Generic. . :: . .IEnumerator](https://msdn.microsoft.com/en-us/library/78dfe2yb\(v=vs.90\))\< (Of \< ( \<'[DeploymentRule](deploymentrule-class-microsoft-web-deployment.md)\> ) \> ) \>  
An IEnumerator\<DeploymentRule\>.  

#### Implements

[IEnumerable\< (Of \< ( \<'T\> ) \> ) \>. . :: . .GetEnumerator() () () ()](https://msdn.microsoft.com/en-us/library/s793z9y2\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleCollection Class](deploymentrulecollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

