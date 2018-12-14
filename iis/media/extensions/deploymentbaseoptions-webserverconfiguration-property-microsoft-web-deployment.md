---
title: DeploymentBaseOptions.WebServerConfiguration Property  (Microsoft.Web.Deployment)
TOCTitle: WebServerConfiguration Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseOptions.WebServerConfiguration
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.webserverconfiguration(v=VS.90)
ms:contentKeyID: 22753891
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.WebServerConfiguration
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_WebServerConfiguration
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_WebServerConfiguration
- Microsoft.Web.Deployment.DeploymentBaseOptions.WebServerConfiguration
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WebServerConfiguration Property

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyWebServerConfigurationAsDeploymentWebServerConfigurationSystemInfo
'Usage
DiminstanceAsDeploymentBaseOptionsDimvalueAsDeploymentWebServerConfigurationSystemInfovalue = instance.WebServerConfiguration
```

``` csharp
publicDeploymentWebServerConfigurationSystemInfoWebServerConfiguration { get; }
```

``` c++
public:
propertyDeploymentWebServerConfigurationSystemInfo^ WebServerConfiguration {
    DeploymentWebServerConfigurationSystemInfo^ get ();
}
```

``` jscript
function getWebServerConfiguration () : DeploymentWebServerConfigurationSystemInfo
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentWebServerConfigurationSystemInfo](deploymentwebserverconfigurationsysteminfo-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseOptions Class](deploymentbaseoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

