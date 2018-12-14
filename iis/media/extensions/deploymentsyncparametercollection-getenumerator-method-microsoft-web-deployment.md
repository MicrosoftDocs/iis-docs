---
title: DeploymentSyncParameterCollection.GetEnumerator Method  (Microsoft.Web.Deployment)
TOCTitle: GetEnumerator Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameterCollection.GetEnumerator
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametercollection.getenumerator(v=VS.90)
ms:contentKeyID: 20208992
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection.GetEnumerator
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection.GetEnumerator
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetEnumerator Method

Returns an enumerator that iterates through the collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetEnumeratorAsIEnumerator(OfDeploymentSyncParameter)
'Usage
DiminstanceAsDeploymentSyncParameterCollectionDimreturnValueAsIEnumerator(OfDeploymentSyncParameter)

returnValue = instance.GetEnumerator()
```

``` csharp
publicIEnumerator<DeploymentSyncParameter> GetEnumerator()
```

``` c++
public:
virtualIEnumerator<DeploymentSyncParameter^>^ GetEnumerator() sealed
```

``` jscript
publicfinalfunctionGetEnumerator() : IEnumerator<DeploymentSyncParameter>
```

#### Return Value

Type: [System.Collections.Generic. . :: . .IEnumerator](https://msdn.microsoft.com/en-us/library/78dfe2yb\(v=vs.90\))\< (Of \< ( \<'[DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md)\> ) \> ) \>  
A IEnumerator\<T\> that iterates through the collection.  

#### Implements

[IEnumerable\< (Of \< ( \<'T\> ) \> ) \>. . :: . .GetEnumerator() () () ()](https://msdn.microsoft.com/en-us/library/s793z9y2\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterCollection Class](deploymentsyncparametercollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

