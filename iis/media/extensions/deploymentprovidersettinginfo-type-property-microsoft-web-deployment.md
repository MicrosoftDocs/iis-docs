---
title: DeploymentProviderSettingInfo.Type Property  (Microsoft.Web.Deployment)
TOCTitle: Type Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentProviderSettingInfo.Type
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentprovidersettinginfo.type(v=VS.90)
ms:contentKeyID: 20209025
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderSettingInfo.Type
- Microsoft.Web.Deployment.DeploymentProviderSettingInfo.get_Type
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderSettingInfo.get_Type
- Microsoft.Web.Deployment.DeploymentProviderSettingInfo.Type
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Type Property

Gets the type of the [DeploymentProviderSettingInfo](deploymentprovidersettinginfo-class-microsoft-web-deployment.md) object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideReadOnlyPropertyTypeAsType
'Usage
DiminstanceAsDeploymentProviderSettingInfoDimvalueAsTypevalue = instance.Type
```

``` csharp
publicabstractTypeType { get; }
```

``` c++
public:
virtualpropertyType^ Type {
    Type^ get () abstract;
}
```

``` jscript
abstractfunction getType () : Type
```

#### Property Value

Type: [System. . :: . .Type](https://msdn.microsoft.com/en-us/library/42892f65\(v=vs.90\))  
The type of the [DeploymentProviderSettingInfo](deploymentprovidersettinginfo-class-microsoft-web-deployment.md) object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderSettingInfo Class](deploymentprovidersettinginfo-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

