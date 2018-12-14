---
title: DeploymentProviderSetting.Description Property  (Microsoft.Web.Deployment)
TOCTitle: Description Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentProviderSetting.Description
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentprovidersetting.description(v=VS.90)
ms:contentKeyID: 20208951
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderSetting.Description
- Microsoft.Web.Deployment.DeploymentProviderSetting.get_Description
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderSetting.Description
- Microsoft.Web.Deployment.DeploymentProviderSetting.get_Description
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Description Property

Gets a description of the deployment provider setting.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyDescriptionAsString
'Usage
DiminstanceAsDeploymentProviderSettingDimvalueAsStringvalue = instance.Description
```

``` csharp
publicstringDescription { get; }
```

``` c++
public:
virtualpropertyString^ Description {
    String^ get () sealed;
}
```

``` jscript
finalfunction getDescription () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The description of the deployment provider setting.  

#### Implements

[IDeploymentNameDescription. . :: . .Description](ideploymentnamedescription-description-property-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderSetting Class](deploymentprovidersetting-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

