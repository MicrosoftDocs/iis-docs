---
title: DeploymentWebServerConfigurationSystemInfo.WebServerManifest Property  (Microsoft.Web.Deployment)
TOCTitle: WebServerManifest Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.WebServerManifest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentwebserverconfigurationsysteminfo.webservermanifest(v=VS.90)
ms:contentKeyID: 22753970
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.WebServerManifest
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_WebServerManifest
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.set_WebServerManifest
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_WebServerManifest
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.set_WebServerManifest
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.WebServerManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WebServerManifest Property

Gets or sets the path to the directory that contains the manifest files for IIS.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyWebServerManifestAsString
'Usage
DiminstanceAsDeploymentWebServerConfigurationSystemInfoDimvalueAsStringvalue = instance.WebServerManifest

instance.WebServerManifest = value
```

``` csharp
publicstringWebServerManifest { get; set; }
```

``` c++
public:
propertyString^ WebServerManifest {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getWebServerManifest () : Stringfunction setWebServerManifest (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
Contains the path to the directory that contains the manifest files for IIS.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentWebServerConfigurationSystemInfo Class](deploymentwebserverconfigurationsysteminfo-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

