---
title: DeploymentObjectAttributeValue.CreateInstance Method (String) (Microsoft.Web.Deployment)
TOCTitle: CreateInstance Method (String)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttributeValue.CreateInstance(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributevalue.createinstance(v=VS.90)
ms:contentKeyID: 22754015
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.CreateInstance
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CreateInstance Method (String)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideFunctionCreateInstance ( _
    cultureInvariantValueAsString _
) AsDeploymentObjectAttributeValue
'Usage
DiminstanceAsDeploymentObjectAttributeValueDimcultureInvariantValueAsStringDimreturnValueAsDeploymentObjectAttributeValuereturnValue = instance.CreateInstance(cultureInvariantValue)
```

``` csharp
publicabstractDeploymentObjectAttributeValueCreateInstance(
    stringcultureInvariantValue
)
```

``` c++
public:
virtualDeploymentObjectAttributeValue^ CreateInstance(
    String^ cultureInvariantValue
) abstract
```

``` jscript
publicabstractfunctionCreateInstance(
    cultureInvariantValue : String
) : DeploymentObjectAttributeValue
```

#### Parameters

  - cultureInvariantValue  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

#### Return Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeValue](deploymentobjectattributevalue-class-microsoft-web-deployment.md)  
Returns [DeploymentObjectAttributeValue](deploymentobjectattributevalue-class-microsoft-web-deployment.md).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeValue Class](deploymentobjectattributevalue-class-microsoft-web-deployment.md)

[CreateInstance Overload](deploymentobjectattributevalue-createinstance-method-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

