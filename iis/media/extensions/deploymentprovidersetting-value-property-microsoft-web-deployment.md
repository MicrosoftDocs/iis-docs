---
title: DeploymentProviderSetting.Value Property  (Microsoft.Web.Deployment)
TOCTitle: Value Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentProviderSetting.Value
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentprovidersetting.value(v=VS.90)
ms:contentKeyID: 20208976
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderSetting.Value
- Microsoft.Web.Deployment.DeploymentProviderSetting.get_Value
- Microsoft.Web.Deployment.DeploymentProviderSetting.set_Value
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderSetting.get_Value
- Microsoft.Web.Deployment.DeploymentProviderSetting.set_Value
- Microsoft.Web.Deployment.DeploymentProviderSetting.Value
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Value Property

Gets or sets the value of the deployment provider setting.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyValueAsObject
'Usage
DiminstanceAsDeploymentProviderSettingDimvalueAsObjectvalue = instance.Value

instance.Value = value
```

``` csharp
publicObjectValue { get; set; }
```

``` c++
public:
propertyObject^ Value {
    Object^ get ();
    voidset (Object^ value);
}
```

``` jscript
function getValue () : Objectfunction setValue (value : Object)
```

#### Property Value

Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
An object that represents the value of the provider setting.  

## Remarks

The value is validated by an underlying [DeploymentProviderSettingInfo](deploymentprovidersettinginfo-class-microsoft-web-deployment.md) object. The implementation of the [DeploymentProviderSettingInfo](deploymentprovidersettinginfo-class-microsoft-web-deployment.md) object should throw an exception if validation fails.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderSetting Class](deploymentprovidersetting-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

