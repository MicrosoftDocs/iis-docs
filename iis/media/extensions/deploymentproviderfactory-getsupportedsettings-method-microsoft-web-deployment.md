---
title: DeploymentProviderFactory.GetSupportedSettings Method  (Microsoft.Web.Deployment)
TOCTitle: GetSupportedSettings Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentProviderFactory.GetSupportedSettings
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentproviderfactory.getsupportedsettings(v=VS.90)
ms:contentKeyID: 20209027
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderFactory.GetSupportedSettings
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderFactory.GetSupportedSettings
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetSupportedSettings Method

Gets an array of [DeploymentProviderSettingInfo](deploymentprovidersettinginfo-class-microsoft-web-deployment.md) objects associated with the current deployment provider factory.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableFunctionGetSupportedSettingsAsDeploymentProviderSettingInfo()
'Usage
DiminstanceAsDeploymentProviderFactoryDimreturnValueAsDeploymentProviderSettingInfo()

returnValue = instance.GetSupportedSettings()
```

``` csharp
publicvirtualDeploymentProviderSettingInfo[] GetSupportedSettings()
```

``` c++
public:
virtualarray<DeploymentProviderSettingInfo^>^ GetSupportedSettings()
```

``` jscript
publicfunctionGetSupportedSettings() : DeploymentProviderSettingInfo[]
```

#### Return Value

Type: array\<[Microsoft.Web.Deployment. . :: . .DeploymentProviderSettingInfo](deploymentprovidersettinginfo-class-microsoft-web-deployment.md)\> \[\] () \[\] \[\]  
An array of [DeploymentProviderSettingInfo](deploymentprovidersettinginfo-class-microsoft-web-deployment.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderFactory Class](deploymentproviderfactory-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

