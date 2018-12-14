---
title: DeploymentObjectAttributeData.Value Property  (Microsoft.Web.Deployment)
TOCTitle: Value Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectAttributeData.Value
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributedata.value(v=VS.90)
ms:contentKeyID: 22753880
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.Value
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.get_Value
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.get_Value
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.Value
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
PublicReadOnlyPropertyValueAsDeploymentObjectAttributeValue
'Usage
DiminstanceAsDeploymentObjectAttributeDataDimvalueAsDeploymentObjectAttributeValuevalue = instance.Value
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
Returns [DeploymentObjectAttributeValue](deploymentobjectattributevalue-class-microsoft-web-deployment.md).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeData Class](deploymentobjectattributedata-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

