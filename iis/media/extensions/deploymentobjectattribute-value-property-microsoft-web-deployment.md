---
title: DeploymentObjectAttribute.Value Property  (Microsoft.Web.Deployment)
TOCTitle: Value Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectAttribute.Value
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattribute.value(v=VS.90)
ms:contentKeyID: 22753961
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.Value
- Microsoft.Web.Deployment.DeploymentObjectAttribute.get_Value
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.get_Value
- Microsoft.Web.Deployment.DeploymentObjectAttribute.Value
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Value Property

Gets the value of the deployment attribute.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyValueAsDeploymentObjectAttributeValue
'Usage
DiminstanceAsDeploymentObjectAttributeDimvalueAsDeploymentObjectAttributeValuevalue = instance.Value
```

``` csharp
publicDeploymentObjectAttributeValueValue { get; }
```

``` c++
public:
propertyDeploymentObjectAttributeValue^ Value {
    DeploymentObjectAttributeValue^ get ();
}
```

``` jscript
function getValue () : DeploymentObjectAttributeValue
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeValue](deploymentobjectattributevalue-class-microsoft-web-deployment.md)  
A [DeploymentObjectAttributeValue](deploymentobjectattributevalue-class-microsoft-web-deployment.md) object that contains the value of the deployment attribute.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttribute Class](deploymentobjectattribute-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

