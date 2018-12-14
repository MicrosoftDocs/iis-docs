---
title: DeploymentObjectAttributeValue.TryGetValue(T) Method  (Microsoft.Web.Deployment)
TOCTitle: TryGetValue(T) Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttributeValue.TryGetValue``1(``0@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee402882(v=VS.90)
ms:contentKeyID: 22754070
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.TryGetValue``1
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.TryGetValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TryGetValue(T) Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionTryGetValue(Of T) ( _
    <OutAttribute> ByRefvalueAs T _
) AsBoolean
'Usage
DiminstanceAsDeploymentObjectAttributeValueDimvalueAs T
DimreturnValueAsBooleanreturnValue = instance.TryGetValue(value)
```

``` csharp
publicboolTryGetValue<T>(
    out T value
)
```

``` c++
public:
generic<typename T>
boolTryGetValue(
    [OutAttribute] T% value
)
```

``` jscript
JScript does not support generic types or methods.
```

#### Type Parameters

  - T  

#### Parameters

  - value  
    Type: T%  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
Returns [Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\)).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeValue Class](deploymentobjectattributevalue-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

