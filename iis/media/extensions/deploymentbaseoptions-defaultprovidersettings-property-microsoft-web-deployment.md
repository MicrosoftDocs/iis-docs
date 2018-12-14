---
title: DeploymentBaseOptions.DefaultProviderSettings Property  (Microsoft.Web.Deployment)
TOCTitle: DefaultProviderSettings Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseOptions.DefaultProviderSettings
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.defaultprovidersettings(v=VS.90)
ms:contentKeyID: 20579889
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.DefaultProviderSettings
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_DefaultProviderSettings
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.DefaultProviderSettings
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_DefaultProviderSettings
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DefaultProviderSettings Property

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyDefaultProviderSettingsAsIEnumerable(OfDeploymentProviderSetting)
'Usage
DiminstanceAsDeploymentBaseOptionsDimvalueAsIEnumerable(OfDeploymentProviderSetting)

value = instance.DefaultProviderSettings
```

``` csharp
publicIEnumerable<DeploymentProviderSetting> DefaultProviderSettings { get; }
```

``` c++
public:
propertyIEnumerable<DeploymentProviderSetting^>^ DefaultProviderSettings {
    IEnumerable<DeploymentProviderSetting^>^ get ();
}
```

``` jscript
function getDefaultProviderSettings () : IEnumerable<DeploymentProviderSetting>
```

#### Property Value

Type: [System.Collections.Generic. . :: . .IEnumerable](https://msdn.microsoft.com/en-us/library/9eekhta0\(v=vs.90\))\< (Of \< ( \<'[DeploymentProviderSetting](deploymentprovidersetting-class-microsoft-web-deployment.md)\> ) \> ) \>  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseOptions Class](deploymentbaseoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

