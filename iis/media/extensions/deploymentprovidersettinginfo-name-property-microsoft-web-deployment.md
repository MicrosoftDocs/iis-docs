---
title: DeploymentProviderSettingInfo.Name Property  (Microsoft.Web.Deployment)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentProviderSettingInfo.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentprovidersettinginfo.name(v=VS.90)
ms:contentKeyID: 20209328
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderSettingInfo.Name
- Microsoft.Web.Deployment.DeploymentProviderSettingInfo.get_Name
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderSettingInfo.get_Name
- Microsoft.Web.Deployment.DeploymentProviderSettingInfo.Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Name Property

Gets the name of the [DeploymentProviderSettingInfo](deploymentprovidersettinginfo-class-microsoft-web-deployment.md) object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideReadOnlyPropertyNameAsString
'Usage
DiminstanceAsDeploymentProviderSettingInfoDimvalueAsStringvalue = instance.Name
```

``` csharp
publicabstractstringName { get; }
```

``` c++
public:
virtualpropertyString^ Name {
    String^ get () abstract;
}
```

``` jscript
abstractfunction getName () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The name of the [DeploymentProviderSettingInfo](deploymentprovidersettinginfo-class-microsoft-web-deployment.md) object.  

#### Implements

[IDeploymentNameDescription. . :: . .Name](ideploymentnamedescription-name-property-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderSettingInfo Class](deploymentprovidersettinginfo-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

