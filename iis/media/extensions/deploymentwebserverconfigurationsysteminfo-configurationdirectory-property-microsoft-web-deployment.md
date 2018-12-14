---
title: DeploymentWebServerConfigurationSystemInfo.ConfigurationDirectory Property  (Microsoft.Web.Deployment)
TOCTitle: ConfigurationDirectory Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.ConfigurationDirectory
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentwebserverconfigurationsysteminfo.configurationdirectory(v=VS.90)
ms:contentKeyID: 22753872
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.ConfigurationDirectory
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_ConfigurationDirectory
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.set_ConfigurationDirectory
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.ConfigurationDirectory
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_ConfigurationDirectory
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.set_ConfigurationDirectory
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConfigurationDirectory Property

Gets or sets the path to the Web server’s configuration directory.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyConfigurationDirectoryAsString
'Usage
DiminstanceAsDeploymentWebServerConfigurationSystemInfoDimvalueAsStringvalue = instance.ConfigurationDirectory

instance.ConfigurationDirectory = value
```

``` csharp
publicstringConfigurationDirectory { get; set; }
```

``` c++
public:
propertyString^ ConfigurationDirectory {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getConfigurationDirectory () : Stringfunction setConfigurationDirectory (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
Contains the path to the Web server’s configuration directory.  

## Remarks

The configuration directory for IIS 7 contains the applicationHost.config, administration.config, and redirection.config files.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentWebServerConfigurationSystemInfo Class](deploymentwebserverconfigurationsysteminfo-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

