---
title: DeploymentObjectAttributeValue.Equals Method  (Microsoft.Web.Deployment)
TOCTitle: Equals Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttributeValue.Equals(System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributevalue.equals(v=VS.90)
ms:contentKeyID: 22753860
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.Equals
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.Equals
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Equals Method

This member overrides [Object. . :: . .Equals(Object)](https://msdn.microsoft.com/en-us/library/bsc2ak47\(v=vs.90\)).

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridesFunctionEquals ( _
    objAsObject _
) AsBoolean
'Usage
DiminstanceAsDeploymentObjectAttributeValueDimobjAsObjectDimreturnValueAsBooleanreturnValue = instance.Equals(obj)
```

``` csharp
publicoverrideboolEquals(
    Objectobj
)
```

``` c++
public:
virtualboolEquals(
    Object^ obj
) override
```

``` jscript
publicoverridefunctionEquals(
    obj : Object
) : boolean
```

#### Parameters

  - obj  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
Returns [Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\)).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeValue Class](deploymentobjectattributevalue-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

