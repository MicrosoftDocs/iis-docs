---
title: DeploymentProviderSettingInfo.Validate Method  (Microsoft.Web.Deployment)
TOCTitle: Validate Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentProviderSettingInfo.Validate(System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentprovidersettinginfo.validate(v=VS.90)
ms:contentKeyID: 20208920
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderSettingInfo.Validate
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderSettingInfo.Validate
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Validate Method

Validates the data represented by the supplied value parameter.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableFunctionValidate ( _
    valueAsObject _
) AsObject
'Usage
DiminstanceAsDeploymentProviderSettingInfoDimvalueAsObjectDimreturnValueAsObjectreturnValue = instance.Validate(value)
```

``` csharp
publicvirtualObjectValidate(
    Objectvalue
)
```

``` c++
public:
virtualObject^ Validate(
    Object^ value
)
```

``` jscript
publicfunctionValidate(
    value : Object
) : Object
```

#### Parameters

  - value  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    The value to validate.  

#### Return Value

Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  

## Remarks

Implementers should validate the object and throw a DeploymentException if validation fails.

**Notes to Inheritors**

When you inherit from [DeploymentProviderSettingInfo](deploymentprovidersettinginfo-class-microsoft-web-deployment.md), you must override all members except for the Validate method.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderSettingInfo Class](deploymentprovidersettinginfo-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

