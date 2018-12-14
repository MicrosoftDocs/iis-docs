---
title: DeploymentWebServerConfigurationSystemInfo.RedirectionConfigurationPath Property  (Microsoft.Web.Deployment)
TOCTitle: RedirectionConfigurationPath Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.RedirectionConfigurationPath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentwebserverconfigurationsysteminfo.redirectionconfigurationpath(v=VS.90)
ms:contentKeyID: 22753908
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.RedirectionConfigurationPath
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_RedirectionConfigurationPath
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.set_RedirectionConfigurationPath
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_RedirectionConfigurationPath
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.RedirectionConfigurationPath
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.set_RedirectionConfigurationPath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RedirectionConfigurationPath Property

Gets or sets the path to the redirection.config file.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyRedirectionConfigurationPathAsString
'Usage
DiminstanceAsDeploymentWebServerConfigurationSystemInfoDimvalueAsStringvalue = instance.RedirectionConfigurationPath

instance.RedirectionConfigurationPath = value
```

``` csharp
publicstringRedirectionConfigurationPath { get; set; }
```

``` c++
public:
propertyString^ RedirectionConfigurationPath {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getRedirectionConfigurationPath () : Stringfunction setRedirectionConfigurationPath (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Remarks

Contains the path to the redirection.config file.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentWebServerConfigurationSystemInfo Class](deploymentwebserverconfigurationsysteminfo-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

