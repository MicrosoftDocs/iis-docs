---
title: DeploymentWebServerConfigurationSystemInfo.ApplicationHostConfigurationPath Property  (Microsoft.Web.Deployment)
TOCTitle: ApplicationHostConfigurationPath Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.ApplicationHostConfigurationPath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentwebserverconfigurationsysteminfo.applicationhostconfigurationpath(v=VS.90)
ms:contentKeyID: 22754078
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.ApplicationHostConfigurationPath
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_ApplicationHostConfigurationPath
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.set_ApplicationHostConfigurationPath
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.ApplicationHostConfigurationPath
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_ApplicationHostConfigurationPath
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.set_ApplicationHostConfigurationPath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ApplicationHostConfigurationPath Property

Gets or sets the path to the applicationHost.config file.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyApplicationHostConfigurationPathAsString
'Usage
DiminstanceAsDeploymentWebServerConfigurationSystemInfoDimvalueAsStringvalue = instance.ApplicationHostConfigurationPath

instance.ApplicationHostConfigurationPath = value
```

``` csharp
publicstringApplicationHostConfigurationPath { get; set; }
```

``` c++
public:
propertyString^ ApplicationHostConfigurationPath {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getApplicationHostConfigurationPath () : Stringfunction setApplicationHostConfigurationPath (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
Contains the path to the applicationHost.config file.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentWebServerConfigurationSystemInfo Class](deploymentwebserverconfigurationsysteminfo-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

