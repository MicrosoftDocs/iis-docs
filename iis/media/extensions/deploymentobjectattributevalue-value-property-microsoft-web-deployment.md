---
title: DeploymentObjectAttributeValue.Value Property  (Microsoft.Web.Deployment)
TOCTitle: Value Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectAttributeValue.Value
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributevalue.value(v=VS.90)
ms:contentKeyID: 22753877
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.Value
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.get_Value
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.get_Value
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.Value
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Value Property

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideReadOnlyPropertyValueAsObject
'Usage
DiminstanceAsDeploymentObjectAttributeValueDimvalueAsObjectvalue = instance.Value
```

``` csharp
publicabstractObjectValue { get; }
```

``` c++
public:
virtualpropertyObject^ Value {
    Object^ get () abstract;
}
```

``` jscript
abstractfunction getValue () : Object
```

#### Property Value

Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
Returns [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\)).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeValue Class](deploymentobjectattributevalue-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

