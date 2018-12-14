---
title: DeploymentSyncParameterCollection.IEnumerable.GetEnumerator Method  (Microsoft.Web.Deployment)
TOCTitle: IEnumerable.GetEnumerator Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameterCollection.System#Collections#IEnumerable#GetEnumerator
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd543085(v=VS.90)
ms:contentKeyID: 20208852
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection.IEnumerable.GetEnumerator
- Microsoft::Web::Deployment::DeploymentSyncParameterCollection::IEnumerable::GetEnumerator
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

# IEnumerable.GetEnumerator Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PrivateFunctionGetEnumeratorAsIEnumeratorImplementsIEnumerable.GetEnumerator
'Usage
DiminstanceAsDeploymentSyncParameterCollectionDimreturnValueAsIEnumeratorreturnValue = CType(instance, IEnumerable).GetEnumerator()
```

``` csharp
IEnumeratorIEnumerable.GetEnumerator()
```

``` c++
private:
virtualIEnumerator^ GetEnumerator() sealed = IEnumerable::GetEnumerator
```

``` jscript
JScript does not support explicit interface implementations.
```

#### Return Value

Type: [System.Collections. . :: . .IEnumerator](https://msdn.microsoft.com/en-us/library/1t2267t6\(v=vs.90\))  

#### Implements

[IEnumerable. . :: . .GetEnumerator() () () ()](https://msdn.microsoft.com/en-us/library/5zae5365\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterCollection Class](deploymentsyncparametercollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

